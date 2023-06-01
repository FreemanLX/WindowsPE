#pragma once
#pragma warning(disable:4996)

#include <windows.h>
#include <wingdi.h>
#include <stdio.h>
#include <stdlib.h>

#include "NativeClasses/StringUnsafe/stringUnsafe.h"
#include "NativeClasses/LinkedListUnsafe/LinkedListUnsafe.h"

class EnumScreenResolutionUnsafe
{
	LinkedList_unsafe<string_unsafe> AvailableScreenResolution; //out variable not declared until allocating the variable in constructor
    
	void getResolutions(LPCWSTR deviceName){
	     DEVMODEW devmode = {0};
	     devmode.dmSize = sizeof(DEVMODEW);
         int i = 0;
         while (EnumDisplaySettingsExW(deviceName, i++, &devmode, 0)){  
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

	EnumScreenResolutionUnsafe(int display){
		DISPLAY_DEVICEW display_device = {0};
		display_device.cb = sizeof(DISPLAY_DEVICEW);
	    if(EnumDisplayDevicesW(NULL, display, &display_device, EDD_GET_DEVICE_INTERFACE_NAME)){
		     getResolutions(display_device.DeviceName);
		}
	}

	EnumScreenResolutionUnsafe(){
		 getResolutions(NULL);
	}

	auto GetList(){
	   return AvailableScreenResolution;
	}

	auto GetArray(){
		return AvailableScreenResolution.ToArray();
	}

	char** convertToCharArrays(){
	     
	}

	int Size(){
	   return AvailableScreenResolution.Size();
	}

	int byteSize(){
	   return AvailableScreenResolution.byteSize();
	}

};