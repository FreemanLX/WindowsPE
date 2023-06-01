// dllmain.cpp : Defines the entry point for the DLL application.
#include <windows.h>
#include <wingdi.h>
#include <WinUser.h>
#include <commdlg.h>
#include <stdio.h>
#include <stdlib.h>

#include "DisplaySettings/EnumScreenResolutionUnsafe.h"
#include "DisplaySettings/DisplaySettingsUnsafe.h"
#include "NativeClasses/LinkedListUnsafe/pairUnsafe.h"
#include "Firewall/firewall.h"

#define DllExport   __declspec( dllexport )
#pragma warning(disable:4996)
#pragma comment(lib, "Netapi32.lib")
#pragma comment(lib, "Advapi32.lib")
#include <LM.h>
#include <combaseapi.h>


const wchar_t *getWchar(const char* data){
   const size_t size = strlen(data) + 1;
   wchar_t* wchar = new wchar_t[size];
   mbstowcs(wchar, data, size);
   return wchar;
}

extern "C"
{
	 //Firewall
	 bool DllExport FirewallDataClear(firewallData* data, int size){
	     delete[] data;
		 data = nullptr;
		 return true;
	 }

	 int DllExport GetFirewallData(firewallData** data, int* size){
	      firewall* firewallObj = new firewall();
 		  if(!firewallObj->Initialize()) return -1; //in case when unable to initalize
		  if(!firewallObj->GettingFirewallSetting()) { //in case when unable to return the data
 		      delete firewallObj;
			  return -2; //unable to return the data
		  }
		  *data = firewallObj->getFirewallEnum();
		  *size = firewallObj->Length();
		  delete firewallObj;
		  return size > 0; //errors 1 and 2 means it completes with succes, but when on 0, it means no firewall entries
	 }

	 bool DllExport AddFirewallRule(firewallData* rule)
	 {
	     firewall* firewallObj = new firewall();
		 if(!firewallObj->Initialize()) return false; //in case when unable to initalize
		 bool status = firewallObj->addFirewallEntry(*rule);
		 delete firewallObj;
		 return status;
	 }

	 bool DllExport DeleteFirewallRule(char* ruleName)
	 {
	     firewall* firewallObj = new firewall();
		 if(!firewallObj->Initialize()) return false; //in case when unable to initalize
		 bool status = firewallObj->deleteFirewallEntry(ruleName);
		 delete firewallObj;
		 return status;
	 }


	 bool DllExport EnableFirewall(NET_FW_PROFILE_TYPE2 firewallType)
	 { 
		 firewall* firewallObj = new firewall();
		 if(!firewallObj->Initialize()) return false;
		 bool status = firewallObj->EnableFirewall(firewallType);
		 delete firewallObj;
		 return status;
	 }

	 bool DllExport DisableFirewall(NET_FW_PROFILE_TYPE2 firewallType)
	 {
		 
	     firewall* firewallObj = new firewall();
		 if(!firewallObj->Initialize()) return false;
		 bool status = firewallObj->DisableFirewall(firewallType);
		 delete firewallObj;
		 return status;
	 }

	 int DllExport CheckFirewall(NET_FW_PROFILE_TYPE2 profile)
	 {
	      firewall* firewallObj = new firewall();
 		  if(!firewallObj->Initialize()) return -1; //in case when unable to initalize
		  
		  bool status = firewallObj->CheckIfFirewallIsEnabled(profile);
		  delete firewallObj;
		  return status;
	 }

	 //File sharing part of the code
	 void DllExport GetFileSharing(char** &netname, char** &path, int &size){
		 PSHARE_INFO_502 BufPtr, pointer;
		 NET_API_STATUS netapistatus;
		 DWORD entries = 0, totalentries = 0, resume_handle = 0;
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
		 for(int i = 0; i<size; i++){
			 char* array = arrayofPairs[i].first.c_str();
			 netname[i] = (char*)CoTaskMemAlloc(strlen(array) + 1);
			 strcpy(netname[i], array);
		     netname[i][strlen(array) + 1] = '\0';
			 array = arrayofPairs[i].second.c_str();
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

	 //Personalization part of the code
	 bool DllExport SetBackgroundLayout(char* layoutType){
	      if(strlen(layoutType) > 0)
		  {
		      return SystemParametersInfoA(SPI_SETDESKPATTERN, 0, layoutType, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
		  }
		  return false;
	 }

	 bool DllExport SetFontSmoothing(){
	    return SystemParametersInfo(SPI_SETFONTSMOOTHING,
                     TRUE,
                     0,
                     SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
	 }

	 bool DllExport ChangeBackgroundWallpaper(){
		   OPENFILENAMEA OpenDialog = {0};
		   char filePath[MAX_PATH] = "";
		   OpenDialog.lStructSize = sizeof(OpenDialog);
		   OpenDialog.hwndOwner = NULL;
		   OpenDialog.lpstrFilter = "All Files (*.*)\0*.*\0";
		   OpenDialog.lpstrFile = filePath;
		   OpenDialog.nMaxFile = MAX_PATH;
		   OpenDialog.Flags = OFN_EXPLORER | OFN_FILEMUSTEXIST | OFN_HIDEREADONLY;
		   OpenDialog.lpstrDefExt = "";
		   if (GetOpenFileNameA(&OpenDialog))
		   {
			   return SystemParametersInfoA(SPI_SETDESKWALLPAPER, 0, filePath, SPIF_UPDATEINIFILE);
		   }
		   return false;
	 }

	//Screen settings stuff..
    int DllExport ChangeScreenResolutionU(int height, int width){
		DisplaySettings_unsafe displaySettings(height, width);
		return displaySettings.Set();
	}

	bool DllExport GetAvailableScreenResolutionIndex(int** output, int& size){
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
		*output = indexNoList.ToArray();
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
			    char* array = outputinStrings[i].c_str();
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