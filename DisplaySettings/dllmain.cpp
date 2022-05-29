// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#define DllExport   __declspec( dllexport )
#include <stdio.h>
#include <stdlib.h>
#pragma warning(disable:4996)


class string{
    char* chararray;
	char* append(char* array, char element, int n){
        char* aux = new char[n + 1];
       
	    for (; array != array + n; (void)++array, (void)++aux) {
                *aux = *array;
        }

        aux[n] = element;
        return aux;
      }
   public:
	   string(){
	       chararray = new char[1024];
	   }
	   string(char* costantchar){
		   chararray = new char[1024];
	       strcpy(chararray, costantchar);
	   }
	   size_t Size(){
	      return strlen(chararray);
	   }
	   size_t Length(){
	      return strlen(chararray);
	   }
	   void clear(){
	      delete chararray;
	   }
	   bool empty(){
	      return strlen(chararray) == 0;
	   }
	   char operator[](int index){
	      return chararray[index];
	   }
	   string operator+=(string& obj){
	        return strcat(this->chararray, obj.chararray);
	   }
	   string operator+=(const char* str){
	        return strcat(this->chararray, str);
	   }
	   char* toCharArray(){
	      return chararray;
	   }
};


inline bool operator==(string obj1, string obj2){
	 return strcmp(obj1.toCharArray(), obj2.toCharArray()) == 0;
}


template <class T>
class Node{
private:
    T data;
	Node<T>* next;

public:
	Node(){
	   data = 1;
	   next = NULL;
	}
	Node(T data){
	   this->data = data;
	   next = NULL;
	}

	T GetData(){
	   return data;
	}

	Node<T>* getNext(){
	   return next;
	}

	void setNext(Node<T>* node){
	   next = node;
	}
};


template <class T>
class LinkedList
{
	Node<T>* elements;
	int elemcount;

public:
	LinkedList(){
	   elements = NULL;
	}

	Node<T>* GetElements(){
	    return elements; 
	}


	void push_back(T element){
        if (elements == NULL) elements = new Node<T>(element);
		else
		{
			Node<T>* last = elements; 
			while (last->getNext() != nullptr)
			{
				last = last->getNext();
			}
			last->setNext(new Node<T>(element));
		}
	    elemcount++;
	}

	int Size(){
	    return elemcount;
	}

	T* ToArray(){
        T* array = new T[elemcount];
		int i = 0;
		Node<T>* node = elements;
		while(node != NULL){
			array[i++] = node->GetData();
			node = node->getNext();
		}
		return array;
    }

};




class EnumAvailableScreenResolution{
   LinkedList<string>* AvailableScreenResolution;

public:
	EnumAvailableScreenResolution()
	{
	     AvailableScreenResolution = new LinkedList<string>();
		 DEVMODE devmode;
		 memset(&devmode, 0, sizeof(DEVMODE));
	     devmode.dmSize = sizeof(DEVMODE);
         int i = 0;
         while (EnumDisplaySettings(NULL, i++, &devmode) != 0)
		 {
			  if(devmode.dmPelsHeight * devmode.dmPelsWidth >= 1024*768 ){
				  char message[24];
				  sprintf_s(message, "%dx%d\n", devmode.dmPelsWidth, devmode.dmPelsHeight);
				  AvailableScreenResolution->push_back(string(message));
			  }
         }
	}

	auto GetArray(){
		return AvailableScreenResolution->ToArray();
	}

	int Size(){
	   return AvailableScreenResolution->Size();
	}
};


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
						(char*)&("The required resolution of %d x %d is not supported.\nPlease contact your Systems Hardware Vendor.") ;
					case DISP_CHANGE_SUCCESSFUL:
						(char*)&("%s requires this video mode to operate.\nYour normal view will be returned on exit.", "MyApp") ;
					default:
						return (char*)&("Success!");
			}
		    	    
		}
};




class DisplaySettings{
    int height;
	int width;
	int rate;
	int color;

	void DisplaySettingsMethod(int heightParm, int widthParm, int resolutionRate, int displayColor){
			     this->height = heightParm;
		         this->width = widthParm;
				 this->color = displayColor;
				 this->rate = resolutionRate;
	}

    public:

		//DisplaySettings
		//height the height of the resolution
		//width the width of the resolution
		DisplaySettings(int heightParm, int widthParm){
			DisplaySettingsMethod(heightParm, widthParm, 60, 32);
		}
		DisplaySettings(int heightParm, int widthParm, int resolutionRate){
		    DisplaySettingsMethod(heightParm, widthParm, resolutionRate, 32);
		}

		DisplaySettings(int heightParm, int widthParm, int resolutionRate, int displayColor){
		    DisplaySettingsMethod(heightParm, widthParm, resolutionRate, displayColor);
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
				devmode.dmDisplayFrequency = rate;
				devmode.dmColor = color;
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

extern "C" {
	void DllExport ChangeScreenResolution(Resolution* resolution){
		  DisplaySettings* displaySettings = new DisplaySettings(resolution->height, resolution->width);
		  resolution->output = displaySettings->Set();
	}
}

//FROM C++ to C (external functions) => import function in C#
extern "C"{
    void DllExport ChangeScreenResolutionW(int height, int width, char* output){
		  DisplaySettings* displaySettings = new DisplaySettings(height, width);
		  output = displaySettings->Set();
	}

	bool DllExport EnumScreenResolution(char*** Poutput, int* Psize){
	    EnumAvailableScreenResolution screenResolutions;
		int size = screenResolutions.Size();
		*Psize = size;
		char** output = new char*[size];
		//char** output = (char**) malloc(sizeof(char) * (size));
		if(size > 0){
		   string* outputinStrings = screenResolutions.GetArray();
		   for(int i = 0; i<size; i++){ 
			    char* array = outputinStrings[i].toCharArray();
			    //output[i] = (char*) malloc(sizeof(char) * strlen(array));
				output[i] = new char[strlen(array)];
				strcpy(output[i], array);
				delete array;
		   }
		   *Poutput = output;
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