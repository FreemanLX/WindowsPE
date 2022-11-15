#pragma once
#include <stdlib.h>
#include <windows.h>
#include <comutil.h>
#include <atlcomcli.h>
#include <netfw.h>

#pragma comment(lib, "ole32.lib")
#pragma comment(lib, "oleaut32.lib")
#pragma comment(lib, "comsuppw.lib")

#define NET_FW_RULE_DIR_IN_NAME L"In"
#define NET_FW_RULE_DIR_OUT_NAME L"Out"

#define NET_FW_RULE_ENABLE_IN_NAME L"TRUE"
#define NET_FW_RULE_DISABLE_IN_NAME L"FALSE"


struct firewallData{
	     char* program;
	     char* name;
		 char* localAddress;
		 char* remoteAddress;
		 char* profile;
		 char* localPort;
		 char* remotePort;
		 char* action;
		 char* protocol;
		 bool enabled;
		 bool outbound; //true - out, false - in

		 void copy(char* output, char* set){
		      output = (char*) malloc ((strlen(set) + 1) * sizeof(char));
			  strcpy(output, set);
		 }
		 
		 void alloc(char* output, int size){
		      output = (char*) malloc(size * sizeof(char));
		 }

		 firewallData(){
			  localPort = (char*) malloc(7 * sizeof(char));
			  remotePort = (char*) malloc(7 * sizeof(char));
			  protocol = (char*) malloc(7 * sizeof(char));
			  strcpy(protocol, "Any");
			  strcpy(localPort, "Any");
			  strcpy(remotePort, "Any");
		 }
		  
		 firewallData(char* _program, char* _name, char* _localAddress, char* _remoteAddress, 
			          char* _profile, char* _localPort, char* _remotePort, char* _action, 
			          char* _protocol, bool _enabled, bool _outbound){
		      
			 copy(program, _program);
			 copy(name, _name);
			 copy(localAddress, _localAddress);
			 copy(remoteAddress, _remoteAddress);
			 copy(profile, _profile);
			 copy(localPort, _localPort);
			 copy(remotePort, _remotePort);
			 copy(action, _action);
			 copy(protocol, _protocol);
			 enabled = _enabled;
			 outbound = _outbound;
		 }
};


class firewall
{
    LinkedList_unsafe<firewallData> data;
	HRESULT hrComInit = S_OK;
	HRESULT hr = S_OK;
	IUnknown *pEnumerator;
    IEnumVARIANT* pVariant;
    INetFwPolicy2 *pNetFwPolicy2;
    INetFwRules *pFwRules;
    INetFwRule *pFwRule;
	bool initialization;
	long size;
	long memsize;

	//(C) Microsoft Corp Function Example
	HRESULT WFCOMInitialize(INetFwPolicy2** ppNetFwPolicy2)
	{
		HRESULT hr = S_OK;

		hr = CoCreateInstance(
			__uuidof(NetFwPolicy2), 
			NULL, 
			CLSCTX_INPROC_SERVER, 
			__uuidof(INetFwPolicy2), 
			(void**)ppNetFwPolicy2);

		if (FAILED(hr))
		{
			wprintf(L"CoCreateInstance for INetFwPolicy2 failed: 0x%08lx\n", hr);
			return hr;  
		}
		return hr;
	}


public:
	firewall(){
      	 //   data = (firewallData*) malloc(sizeof(firewallData));
        pVariant = NULL;
        pNetFwPolicy2 = NULL;
        pFwRules = NULL;
        pFwRule = NULL; 
		initialization = false;
		//data = new LinkedList_unsafe<firewallData>();
		size = 0;
		memsize = 0;
	}

	~firewall(){
		if (pFwRule != NULL) pFwRule->Release();
		if (pNetFwPolicy2 != NULL) pNetFwPolicy2->Release();
		if(initialization) CoUninitialize();
		initialization = false;
	  //  free(data);
	}


	bool Initialize(){
		if(FAILED(CoInitializeEx(0, COINITBASE_MULTITHREADED))){
		   return false; //failed
		}
		if(FAILED(WFCOMInitialize(&pNetFwPolicy2))){
		    return false;
		}
		initialization = true;
		return true;
	}


	bool GettingFirewallSetting()
	{
 	    if(FAILED(pNetFwPolicy2->get_Rules(&pFwRules)))
		{
		    return false;
		}
		hr = pFwRules->get_Count(&size);
		if(FAILED(hr)) return false;
 		pFwRules->get__NewEnum(&pEnumerator);
		if(pEnumerator)
		    hr = pEnumerator->QueryInterface(__uuidof(IEnumVARIANT), (void **) &pVariant);
		
		CComVariant var;
		long i = 0;
		unsigned long cFeteched = 0;
		while(SUCCEEDED(hr) && hr != S_FALSE)
		{
			firewallData dataline; 
		    var.Clear();
			hr = pVariant ->Next(1, &var, &cFeteched);
			if(S_FALSE != hr && SUCCEEDED(hr))
			{
			    if(SUCCEEDED(var.ChangeType(VT_DISPATCH)) && SUCCEEDED((V_DISPATCH(&var))->QueryInterface(__uuidof(INetFwRule), reinterpret_cast<void**>(&pFwRule))))
				{
				    BSTR bstrVal;
					if(SUCCEEDED(pFwRule->get_Name(&bstrVal)))
					{
						dataline.name = _com_util::ConvertBSTRToString(bstrVal);
					}
					if (SUCCEEDED(pFwRule->get_ApplicationName(&bstrVal)))
					{
						dataline.program = _com_util::ConvertBSTRToString(bstrVal);
					}
					if (SUCCEEDED(pFwRule->get_LocalAddresses(&bstrVal)))
					{
						dataline.localAddress = _com_util::ConvertBSTRToString(bstrVal);
					}
					if (SUCCEEDED(pFwRule->get_RemoteAddresses(&bstrVal)))
					{
						dataline.remoteAddress = _com_util::ConvertBSTRToString(bstrVal);
					}
					long lVal;
					if (SUCCEEDED(pFwRule->get_Protocol(&lVal)))
					{
						dataline.protocol = new char[4];
						switch(lVal)
						{
							case NET_FW_IP_PROTOCOL_TCP: 
								strcpy(dataline.protocol, "TCP");			
								break;

							case NET_FW_IP_PROTOCOL_UDP: 
								strcpy(dataline.protocol, "UDP");
								break;

							default:
								break;
						}
						if(lVal != NET_FW_IP_VERSION_V4 && lVal != NET_FW_IP_VERSION_V6)
						{
							
							if (SUCCEEDED(pFwRule->get_LocalPorts(&bstrVal)))
							{    
								dataline.localPort = _com_util::ConvertBSTRToString(bstrVal);
							}

							if (SUCCEEDED(pFwRule->get_RemotePorts(&bstrVal)))
							{
								dataline.remotePort = _com_util::ConvertBSTRToString(bstrVal);
							}
						}
						else
						{
							if (SUCCEEDED(pFwRule->get_IcmpTypesAndCodes(&bstrVal)))
							{
								dataline.localPort = new char[5];
								dataline.remotePort = new char[5];
								strcpy(dataline.protocol, "ICMP");
								strcpy(dataline.remotePort, "None");
								strcpy(dataline.localPort, "None");
							}
						}

				    }
					else {
					    dataline.localPort = new char[5];
					    dataline.remotePort = new char[5];
						strcpy(dataline.protocol, "Any");
						strcpy(dataline.remotePort, "Any");
						strcpy(dataline.localPort, "Any");
					}
					NET_FW_ACTION fwAction;
					NET_FW_RULE_DIRECTION fwDirection;
					dataline.action = new char[6];
					if (SUCCEEDED(pFwRule->get_Action(&fwAction)))
					{
						switch(fwAction)
						{
							case NET_FW_ACTION_BLOCK:
								strcpy(dataline.action, "Block");
								break;

							case NET_FW_ACTION_ALLOW:
								strcpy(dataline.action, "Allow");
								break;

							default:
								break;
						}
					}
					if (SUCCEEDED(pFwRule->get_Direction(&fwDirection)))
				    {
						dataline.outbound = (fwDirection == NET_FW_RULE_DIR_OUT) ? true : false;
				    }
					VARIANT_BOOL enabled;
					if (SUCCEEDED(pFwRule->get_Enabled(&enabled)))
				    {
						dataline.enabled = (enabled == -1) ? true : false;
				    }
					dataline.profile = new char[5];
					strcpy(dataline.profile, "None");
			    }
			}
			//i++;
			data.push_back(dataline);
		}
		memsize = data.byteSize();
	    return true;
	}

    bool addFirewallEntry(firewallData* firewallEntry){
	    hr = WFCOMInitialize(&pNetFwPolicy2);
		if(FAILED(hr)) return false;
		hr = pNetFwPolicy2->get_Rules(&pFwRules);
		if(FAILED(hr)) return false;
		hr = CoCreateInstance(__uuidof(NetFwRule), NULL, CLSCTX_INPROC_SERVER, __uuidof(INetFwRule), (void**)&pFwRule);
		if(FAILED(hr)){
		   return false;
		}
		pFwRule->put_Name((BSTR)firewallEntry->name);
		pFwRule->put_Description((BSTR)"");
		if(strcmp(firewallEntry->protocol, "ICMP") == 0){
			 pFwRule->put_Protocol(0);
		}
		else
		{
		   
		}
		pFwRule->put_Profiles(NET_FW_PROFILE2_PRIVATE);
		pFwRule->put_Action(NET_FW_ACTION_ALLOW);
		pFwRule->put_Enabled(VARIANT_TRUE);

	}

	bool deleteFirewallEntry(firewallData& firewallEntry){
	   
	}

	int Length(){
	   return size;
	}

	int MemSize(){
	   return memsize;
	}

	firewallData* getFirewallEnum(){
		firewallData* firewalldata = data.ToArray();
		return firewalldata;
	}

};