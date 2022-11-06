#include "framework.h"
#include "NativeClasses/StringUnsafe/stringUnsafe.h"
#include "NativeClasses/LinkedListUnsafe/LinkedListUnsafe.h"
#pragma once
#pragma warning(disable:4996)

class EnumScreenResolutionUnsafe
{
	LinkedList_unsafe<string_unsafe> AvailableScreenResolution; //out variable not declared until allocating the variable in constructor
    
	void getResolutions(LPCWSTR deviceName){
	     DEVMODE devmode = {0};
	     devmode.dmSize = sizeof(DEVMODE);
         int i = 0;
         while (EnumDisplaySettingsEx(deviceName, i++, &devmode, 0))
		 {  
			  if(devmode.dmPelsHeight * devmode.dmPelsWidth >= 1024*768 ){
				  char message[24];
				  sprintf_s(message, "%dx%d", devmode.dmPelsWidth, devmode.dmPelsHeight);
				  message[strlen(message) + 1] = '\0';
				  string_unsafe message_s(message); //ok
				  AvailableScreenResolution.push_back(message_s);
			  }
		 }
		 
	}
public:

	EnumScreenResolutionUnsafe(int display)
	{
		DISPLAY_DEVICE display_device = {0};
		display_device.cb = sizeof(DISPLAY_DEVICE);
	    if(EnumDisplayDevices(NULL, display, &display_device, EDD_GET_DEVICE_INTERFACE_NAME)){
		     getResolutions(display_device.DeviceName);
		}
	}

	EnumScreenResolutionUnsafe()
	{
		 getResolutions(NULL);
	}

	~EnumScreenResolutionUnsafe(){
	    
	}

	auto GetList(){
	   return AvailableScreenResolution;
	}

	auto GetArray(){
		return AvailableScreenResolution.ToArray();
	}

	int Size(){
	   return AvailableScreenResolution.Size();
	}

	int byteSize(){
	   return AvailableScreenResolution.byteSize();
	}

};