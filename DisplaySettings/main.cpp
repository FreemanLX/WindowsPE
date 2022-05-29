#include "main.h"



class DisplayExceptions{
    private:
	int errorcode_;
    public:
		DisplayExceptions(int errorcode) : errorcode_(errorcode){}
		DisplayExceptions(const DisplayExceptions& obj){
			this->errorcode_ = obj.errorcode_;
		}

		int GetErrorCode(){
		   return errorcode_;
		}

		char* GetMessageCode(){
			switch (errorcode_)
			{
				case DISP_CHANGE_BADFLAGS:
					case DISP_CHANGE_BADMODE:
						return (char*)&("An error has occured while trying to change screen resolution.\nPlease Technical Support.") ;
					case DISP_CHANGE_FAILED:
						return (char*)&("The required resolution of %d x %d is not supported.\nPlease contact your Systems Hardware Vendor.") ;
					case DISP_CHANGE_SUCCESSFUL:
						return (char*)&("It requires this video mode to operate.\nYour normal view will be returned on exit.") ;
					default:
						return (char*)&("Success!");
			}

		}
};


class DisplaySettings{
    int height;
	int width;

    public:
		//DisplaySettings
		//height the height of the resolution
		//width the width of the resolution
		DisplaySettings(int heightParm, int widthParm){
		   if (GetSystemMetrics(SM_CXSCREEN) < widthParm &&
			   GetSystemMetrics(SM_CYSCREEN) < heightParm && widthParm * heightParm >= 786432){
			     this->height = heightParm;
		         this->width = widthParm;
		   }
		}
		char* Set(){
			long error = 0;
			DEVMODE devmode;
			memset(&devmode, 0, sizeof(DEVMODE));
			devmode.dmSize = sizeof(DEVMODE);
			devmode.dmDriverExtra = *((unsigned short*) GlobalAlloc(GHND, sizeof(DEVNAMES)));
			if (EnumDisplaySettings(NULL, ENUM_CURRENT_SETTINGS, &devmode))
			{
				devmode.dmPelsHeight = height;
				devmode.dmPelsWidth = width;
				devmode.dmFields = DM_PELSHEIGHT | DM_PELSWIDTH;
				error = ChangeDisplaySettings(&devmode, CDS_FULLSCREEN);
			}
			GlobalFree((void*) devmode.dmDriverExtra) ;
			DisplayExceptions exception(error);
			return exception.GetMessageCode();
		}

};

struct Resolution{
    int height;
    int width;
    LPCSTR output;
};

void DLL_EXPORT ChangeScreenResolution(Resolution* resolution){
      DisplaySettings* displaySettings = new DisplaySettings(resolution->height, resolution->width);
	  resolution->output = displaySettings->Set();
}
// a sample exported function
void DLL_EXPORT SomeFunction(const LPCSTR sometext)
{
    MessageBoxA(0, sometext, "DLL Message", MB_OK | MB_ICONINFORMATION);
}

extern "C" DLL_EXPORT BOOL APIENTRY DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpvReserved)
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
