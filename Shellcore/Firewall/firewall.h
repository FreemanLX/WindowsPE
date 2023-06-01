#pragma once
#include <stdlib.h>
#include <windows.h>
#include <comutil.h>
#include <atlcomcli.h>
#include <netfw.h>

#include "../Shellcore/NativeClasses/StringUnsafe/stringUnsafe.h" //defining the string unsafe.

#pragma comment(lib, "ole32.lib")
#pragma comment(lib, "oleaut32.lib")
#pragma comment(lib, "comsuppw.lib")

//struct for extracting data
struct firewallData
{
	int protocol; //6 - tcp, 17 - udp, 0 - icmpv4
    int enabled;
	int outbound; //true - out, false - in
	int action;
	long profile;
	COM::string_unsafe program;
	COM::string_unsafe name;
	COM::string_unsafe localAddress;
	COM::string_unsafe remoteAddress;
	COM::string_unsafe localPort;
	COM::string_unsafe remotePort;
};

class firewall
{
    LinkedList_unsafe<firewallData> data;
    INetFwPolicy2 *pNetFwPolicy2;
	bool initialization;
	long size;

	HRESULT WFCOMInitialize(INetFwPolicy2** ppNetFwPolicy2) {
		HRESULT tmp = CoCreateInstance(
			__uuidof(NetFwPolicy2), 
			NULL, 
			CLSCTX_INPROC_SERVER, 
			__uuidof(INetFwPolicy2), 
			(void**)ppNetFwPolicy2);
		return tmp;
	}

public:
	firewall(){
        pNetFwPolicy2 = NULL;
		initialization = false;
		size = 0;
	}


	//Cleaning what was initialized with com per se.
	~firewall(){
		if(pNetFwPolicy2 != NULL) {
			pNetFwPolicy2->Release();
		}
		if(initialization) CoUninitialize();
		initialization = false;
	}

	//Initializing the COM.
	bool Initialize() {
		HRESULT coerror = CoInitializeEx(0, COINIT_APARTMENTTHREADED);
		if(FAILED(coerror) || 
			FAILED(WFCOMInitialize(&pNetFwPolicy2))) return false;
		
		initialization = true;
		return true;
	}

	bool CheckIfFirewallIsEnabled(NET_FW_PROFILE_TYPE2 firewallType) {
		VARIANT_BOOL enabled = 0;
	    if(!(FAILED(pNetFwPolicy2->get_FirewallEnabled(firewallType, &enabled)))) {
		    return (enabled == 0) ? false : true;
		}
		return false;
	}

	bool EnableFirewall(NET_FW_PROFILE_TYPE2 firewallType) {
	    if(!CheckIfFirewallIsEnabled(firewallType)) { 
		    return SUCCEEDED(pNetFwPolicy2->put_FirewallEnabled(firewallType, -1));
		}
	    return true; //is already enabled
	}

	bool DisableFirewall(NET_FW_PROFILE_TYPE2 firewallType) {
	    if(CheckIfFirewallIsEnabled(firewallType)) { 
		    return SUCCEEDED(pNetFwPolicy2->put_FirewallEnabled(firewallType, 0));
		}
	    return true; //is already disabled
	}

	bool GettingFirewallSetting() {
		HRESULT hr;

		//defining the firewall rules
		INetFwRules *pFwRules;

		//defining the rule for extraction
        INetFwRule *pFwRule;

		//iterations
		IUnknown *pEnumerator;
        IEnumVARIANT* pVariant = NULL;

		//retrieving the firewall rules.
 	    if(FAILED(pNetFwPolicy2->get_Rules(&pFwRules)) || 
			FAILED(pFwRules->get_Count(&size))) {
		    
			pFwRules->Release();
			return false; 
		}
		
		//retrieving the enumerator pointer
		pFwRules->get__NewEnum(&pEnumerator);
		if(pEnumerator)
		    hr = pEnumerator->QueryInterface(__uuidof(IEnumVARIANT), (void **) &pVariant);
		
		CComVariant var;
		unsigned long cFeteched = 0;
		while(SUCCEEDED(hr) && hr != S_FALSE)
		{
			firewallData dataline; 
		    var.Clear();
			hr = pVariant->Next(1, &var, &cFeteched);
			if(S_FALSE != hr && SUCCEEDED(hr)) {
			    if(SUCCEEDED(var.ChangeType(VT_DISPATCH)) && 
					   SUCCEEDED((V_DISPATCH(&var))->QueryInterface(__uuidof(INetFwRule), reinterpret_cast<void**>(&pFwRule)))) {
				    BSTR bstrVal;
					NET_FW_ACTION fwAction;
					NET_FW_RULE_DIRECTION fwDirection;
					VARIANT_BOOL enabled;
					
					//because on string_unsafe we defined explicitely conversion from BSTR, now is taking directly.
					if(SUCCEEDED(pFwRule->get_Name(&bstrVal)))
						dataline.name = bstrVal;
					
					if (SUCCEEDED(pFwRule->get_ApplicationName(&bstrVal)))
						dataline.program = bstrVal;
					
					if (SUCCEEDED(pFwRule->get_LocalAddresses(&bstrVal)))
						dataline.localAddress = bstrVal;
					
					if (SUCCEEDED(pFwRule->get_RemoteAddresses(&bstrVal)))
						dataline.remoteAddress = bstrVal;
					
					long lVal;
					if (SUCCEEDED(pFwRule->get_Protocol(&lVal))) {
						   dataline.protocol = lVal;
						   
						   if(lVal != 1 && lVal != 58) {
							   if (SUCCEEDED(pFwRule->get_LocalPorts(&bstrVal)))
								  dataline.localPort = bstrVal;
						
							   if (SUCCEEDED(pFwRule->get_RemotePorts(&bstrVal)))
								  dataline.remotePort = bstrVal;
						   }
				    }
					
					if (SUCCEEDED(pFwRule->get_Action(&fwAction)))
						dataline.action = fwAction;
					
					if (SUCCEEDED(pFwRule->get_Direction(&fwDirection)))
						dataline.outbound = fwDirection - 1;
				    
					if (SUCCEEDED(pFwRule->get_Enabled(&enabled)))
				     	dataline.enabled = (enabled == -1) ? true : false;
				    					
					pFwRule->get_Profiles(&dataline.profile);
					pFwRule->Release(); 
			    }
			}
			data.push_back(dataline);
		}		

		//cleaning up the extracted rules.
		pFwRules->Release();
	    return true;
	}

	//add firewall entry
    bool addFirewallEntry(firewallData firewallEntry) {
		 
		  INetFwRules *pFwRules;
          INetFwRule *pFwRule;

		  //trying to retrieve the rules.
		  if (FAILED(pNetFwPolicy2->get_Rules(&pFwRules))) return false;
		
		  //trying to create instance of a new pointer rule
		  if(FAILED(CoCreateInstance(__uuidof(NetFwRule), NULL, CLSCTX_INPROC_SERVER, __uuidof(INetFwRule), (void**)&pFwRule))) return false;
		
		  //checking if we can insert info per every object
		  if(FAILED(pFwRule->put_Name(firewallEntry.name.b_str()))) return false;
		  pFwRule->put_Action((NET_FW_ACTION)firewallEntry.action); //1 - allow and 0 - block
		  pFwRule->put_Enabled(VARIANT_TRUE);
 
		  if(firewallEntry.program.length() > 0 && 
			         FAILED(pFwRule->put_ApplicationName(firewallEntry.program.b_str())))
		       return false;
		 
	      if(FAILED(pFwRule->put_Protocol(firewallEntry.protocol))) 
			   return false;

		  if(firewallEntry.localPort.length() > 0 && 
			          FAILED(pFwRule->put_LocalPorts(firewallEntry.localPort.b_str())))
			   return false;

		  if(firewallEntry.remotePort.length() > 0 &&  
			          FAILED(pFwRule->put_RemotePorts(firewallEntry.remotePort.b_str())))
			   return false;
				 
		  if(firewallEntry.localAddress.length() > 0 && 
			          FAILED(pFwRule->put_LocalAddresses(firewallEntry.localAddress.b_str())))
			   return false;

		  if(firewallEntry.remoteAddress.length() > 0 && 
			          FAILED(pFwRule->put_RemoteAddresses(firewallEntry.remoteAddress.b_str())))
			   return false;
		 
		  pFwRule->put_Profiles(firewallEntry.profile);
		  pFwRule->put_Direction((NET_FW_RULE_DIRECTION) (firewallEntry.outbound + 1));
		 
		  //adding and checking the rule.
		  HRESULT HR = pFwRules->Add(pFwRule);
		  bool status = SUCCEEDED(HR);

		  //cleaning
          pFwRule->Release();
		  pFwRules->Release();
		  return status;
	}

	bool deleteFirewallEntry(string_unsafe rule){
	     INetFwRules *pFwRules;
		 //trying to retrieve the rules.
		 if (FAILED(pNetFwPolicy2->get_Rules(&pFwRules))) return false;
		 bool status =  SUCCEEDED(pFwRules->Remove(rule.b_str()));
		 pFwRules->Release();
		 return status;
	}

	int Length(){
	   return size;
	}

	firewallData* getFirewallEnum(){
		firewallData* firewalldata = data.ToArray();
		return firewalldata;
	}

};