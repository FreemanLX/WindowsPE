// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include "DisplaySettings/EnumScreenResolutionUnsafe.h"
#include "DisplaySettings/DisplaySettingsUnsafe.h"
#include <combaseapi.h>
#include <LM.h>
#include "NativeClasses/LinkedListUnsafe/pairUnsafe.h"
#include "Firewall/firewall.h"

#define DllExport   __declspec( dllexport )
#pragma warning(disable:4996)
#pragma comment(lib, "Netapi32.lib")
#pragma comment(lib, "Advapi32.lib")


const wchar_t *getWchar(const char* data){
   const size_t size = strlen(data) + 1;
   wchar_t* wchar = new wchar_t[size];
   mbstowcs(wchar, data, size);
   return wchar;
}

extern "C"{

	 int DllExport GetFirewallData(firewallData** data, int* size, int* memsize){
	      firewall* firewallObj = new firewall();
		  if(!firewallObj->Initialize()) return -1;
		  if(!firewallObj->GettingFirewallSetting()) return -1;
		  *data = firewallObj->getFirewallEnum();
		  *size = firewallObj->Length();
		  *memsize = firewallObj->MemSize();
		  delete firewallObj;
		  if(sizeof(*data) > 0) return 1;
		  return 0;
	 }

	 void DllExport GetFileSharing(char** &netname, char** &path, int &size){
		 PSHARE_INFO_502 BufPtr, pointer;
		 NET_API_STATUS netapistatus;
		 DWORD entries = 0;
		 DWORD totalentries = 0;
		 DWORD resume_handle = 0;
		 LinkedList_unsafe<pair_unsafe<string_unsafe, string_unsafe> > data;
	     do
		 {   
			 netapistatus = NetShareEnum(NULL, 502, (LPBYTE*) &BufPtr, MAX_PREFERRED_LENGTH, &entries, &totalentries, &resume_handle);
		     if(netapistatus  == ERROR_SUCCESS || netapistatus == ERROR_MORE_DATA){
		          pointer = BufPtr;
				  for(unsigned int i = 0; i<entries; i++){
					 string_unsafe netname(pointer->shi502_netname);
					 string_unsafe netpath(pointer->shi502_path);
					 pair_unsafe<string_unsafe, string_unsafe> net(netname, netpath);
				     data.push_back(net);
					 pointer++;
				  }
			 }	 
		 }
		 while(netapistatus == ERROR_MORE_DATA);
		 pair_unsafe<string_unsafe, string_unsafe>* arrayofPairs = data.ToArray();
		 netname = (char**)CoTaskMemAlloc(data.byteSize());
		 path = (char**)CoTaskMemAlloc(data.byteSize());
		 size = data.Size();
		 for(int i = 0; i<data.Size(); i++){
			 char* array = arrayofPairs[i].first.toCharArray();
			 netname[i] = (char*)CoTaskMemAlloc(strlen(array) + 1);
			 strcpy(netname[i], array);
		     netname[i][strlen(array) + 1] = '\0';
			 array = arrayofPairs[i].second.toCharArray();
			 path[i] = (char*)CoTaskMemAlloc(strlen(array) + 1);
			 strcpy(path[i], array);
		     path[i][strlen(array) + 1] = '\0';
		 }
	 }


	 bool DllExport DeleteFileSharing(char* netname){
		DWORD reversed = 0;
	    NET_API_STATUS netapistatus = NetShareDel(NULL, (LPWSTR)getWchar(netname), reversed);
		return (netapistatus == ERROR_SUCCESS);
	 }
	 
	 bool DllExport AddFileSharing(SHARE_INFO_2 shareinfo){
		 DWORD error = 0;
		 NET_API_STATUS netapistatus = NetShareAdd(NULL, 2, (LPBYTE)&shareinfo, &error);
	     return (netapistatus == ERROR_SUCCESS);
	 }

	 void DllExport OpenFileDialog(char** path){
		        OPENFILENAMEA OpenDialog = {0};
				char fileName[MAX_PATH] = "";
				OpenDialog.lStructSize = sizeof(OpenDialog);
				OpenDialog.hwndOwner = NULL;
				OpenDialog.lpstrFilter = "All Files (*.*)\0*.*\0";
				OpenDialog.lpstrFile = fileName;
				OpenDialog.nMaxFile = MAX_PATH;
				OpenDialog.Flags = OFN_EXPLORER | OFN_FILEMUSTEXIST | OFN_HIDEREADONLY;
			    OpenDialog.lpstrDefExt = "";
				if (GetOpenFileNameA(&OpenDialog)){ ///atribuie adresa
					 *path = (char*) CoTaskMemAlloc(strlen(fileName) * sizeof(char) + 1);
					 strcpy(*path, fileName);
				}
	 }

    int DllExport ChangeScreenResolutionU(int height, int width){
		  DisplaySettings_unsafe displaySettings(height, width);
		  return displaySettings.Set();
	}

	bool DllExport GetAvailableScreenResolutionIndex(int* &output, int &size){
	    DISPLAY_DEVICE display_device = {0};
		display_device.cb = sizeof(DISPLAY_DEVICE);
		int i = 0;
		LinkedList_unsafe<int> indexNoList;
		while(EnumDisplayDevices(NULL, i, &display_device, EDD_GET_DEVICE_INTERFACE_NAME)){
		   	   DEVMODE devmode = {0};
	           devmode.dmSize = sizeof(DEVMODE);
               if (EnumDisplaySettings(display_device.DeviceName, 0, &devmode) != 0){
				     indexNoList.push_back(i);
			   }
			   i++;
		}
		output = indexNoList.ToArray();
		size = indexNoList.Size();
		return true;
	}

	bool DllExport EnumScreenResolutionU(int display, char** &output, int &size){
		string_unsafe* outputinStrings = nullptr;
	    EnumScreenResolutionUnsafe screenResolutions(display);
		size = screenResolutions.Size();
		int byteSize = screenResolutions.byteSize();
		if(size > 0){
		   outputinStrings = screenResolutions.GetArray();
		   output = (char**)CoTaskMemAlloc(byteSize);
		   for(int i = 0; i<size; i++){ 
			    char* array = outputinStrings[i].toCharArray();
			    output[i] = (char*)CoTaskMemAlloc(strlen(array) + 1);
			    strcpy(output[i], array);
				output[i][strlen(array) + 1] = '\0';
		   }
		   delete[] outputinStrings;
		   return true;
		}
		return false;
	
	}
}

BOOL APIENTRY DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpvReserved)
{
    switch (fdwReason)
    {
        case DLL_PROCESS_ATTACH:
            // attach to process
            // return FALSE to fail DLL load
            break;

        case DLL_PROCESS_DETACH:
            // detach from process
            break;

        case DLL_THREAD_ATTACH:
            // attach to thread
            break;

        case DLL_THREAD_DETACH:
            // detach from thread
            break;
    }
    return TRUE; // succesful
}