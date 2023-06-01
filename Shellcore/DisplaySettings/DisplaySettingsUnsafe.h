#include <windows.h>
#include <wingdi.h>
#include <WinUser.h>
#include <commdlg.h>
#include <stdio.h>
#include <stdlib.h>
#include <commdlg.h>

#pragma once
class DisplaySettings_unsafe
{
	int height;
	int width;
	int rate;
	int color;
	DEVMODE devmode;


	void DisplaySettingsMethod(int heightParm, int widthParm, int resolutionRate, int displayColor){
			     this->height = heightParm;
		         this->width = widthParm;
				 this->color = displayColor;
				 this->rate = resolutionRate;
				 this->devmode = {0};
				 devmode.dmSize = sizeof(DEVMODE);
				 devmode.dmDriverExtra = *((unsigned short*) GlobalAlloc(GHND, sizeof(DEVNAMES)));
	}

    public:

		//DisplaySettings
		//height the height of the resolution
		//width the width of the resolution
		DisplaySettings_unsafe(int heightParm, int widthParm){
			DisplaySettingsMethod(heightParm, widthParm, 60, 32);
		}
		DisplaySettings_unsafe(int heightParm, int widthParm, int resolutionRate){
		    DisplaySettingsMethod(heightParm, widthParm, resolutionRate, 32);
		}

		DisplaySettings_unsafe(int heightParm, int widthParm, int resolutionRate, int displayColor){
		    DisplaySettingsMethod(heightParm, widthParm, resolutionRate, displayColor);
		}

		int Set(){
			long error = 0;
			if (EnumDisplaySettings(NULL, ENUM_CURRENT_SETTINGS, &devmode))
			{
				devmode.dmPelsHeight = height;
				devmode.dmPelsWidth = width;
				devmode.dmDisplayFrequency = rate;
				devmode.dmColor = color;
				devmode.dmFields = DM_PELSHEIGHT | DM_PELSWIDTH;
				error = ChangeDisplaySettings(&devmode, CDS_UPDATEREGISTRY | CDS_GLOBAL | CDS_RESET);
			}
			return error;
		}

		~DisplaySettings_unsafe(){
		    GlobalFree((void*) devmode.dmDriverExtra);
		}

};

