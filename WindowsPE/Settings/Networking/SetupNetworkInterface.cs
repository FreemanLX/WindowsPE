using System;
using System.Management;
using System.Net;

namespace WindowsPE.Settings.Networking
{
    /// <summary>
    /// IPV4 and IPV6 ip setup
    /// </summary>
    public class SetupNetworkInterface
    {
        /// <summary>
        /// For static ip addresses
        /// </summary>
        /// <param name="ipAddress">Ip address</param>
        /// <param name="SubnetMask">Subnet Mask</param>

        string ipAddress;
        string subnetMask;
        string gateway;
        string[] DNS;
        readonly string NIC;
        

        internal bool CheckIP(string IP)
        { 
            IPAddress iPAddress;
            if(IPAddress.TryParse(IP, out iPAddress))
            {
                switch (iPAddress.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork: return true;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6: return true;
                    default: return false;
                }
            }
            return false;
        }

        public void SetStaticIP()
        {
            
            if(CheckIP(ipAddress) && CheckIP(subnetMask))
            {
                ManagementClass manangementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection managementObjectCollection = manangementClass.GetInstances();
                foreach (ManagementObject managementObject in managementObjectCollection)
                {
                    if ((bool)managementObject["IPEnabled"])
                    {

                        string nicobt = managementObject["Caption"].ToString();
                        if (nicobt.Contains(NIC))
                        {
                            using(ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableStatic"))
                            {
                                  newIP["IPAddress"] = new string[]{ipAddress};
                                  newIP["SubnetMask"] = new string[]{subnetMask};
                                  Console.WriteLine(ipAddress);
                                  Console.WriteLine(subnetMask);
                                  managementObject.InvokeMethod("EnableStatic", newIP, null);
                            }
                        
                            if(!string.IsNullOrEmpty(gateway) && CheckIP(gateway))
                            { 
                                using(ManagementBaseObject newGateway = managementObject.GetMethodParameters("SetGateways"))
                                {
                                    newGateway["DefaultIPGateway"] = new[] {gateway};
                                    newGateway["GatewayCostMetric"] = new[] { 1 };
                                    managementObject.InvokeMethod("SetGateways", newGateway, null);
                                }
                            }

                            using(ManagementBaseObject newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                            {
                                newDNS["DNSServerSearchOrder"] = DNS;
                                managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                            }
                        }
                    }
                }
                managementObjectCollection.Dispose();
                manangementClass.Dispose();
            }
        }

        public void SetDHCP()
        {
             ManagementClass manangementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
             ManagementObjectCollection managementObjectCollection = manangementClass.GetInstances();
             foreach (ManagementObject managementObject in managementObjectCollection)
             {
                    if ((bool)managementObject["IPEnabled"])
                    {
                        managementObject.InvokeMethod("EnableDHCP", null);
                    }  
             }
             manangementClass.Dispose();
             managementObjectCollection.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="SubnetMask"></param>
        /// <param name="gateway"></param>
        /// <param name="DNS"></param>
        public SetupNetworkInterface(string ipAddress, string subnetMask, string gateway, string[] DNS, string NIC)
        {
            this.ipAddress = ipAddress;
            this.subnetMask = subnetMask;
            this.gateway = gateway;
            this.DNS = DNS; 
            this.NIC = NIC;
        }

        public SetupNetworkInterface(string ipAddress, string subnetMask, string gateway)
        {
            this.ipAddress = ipAddress;
            this.subnetMask = subnetMask;
            this.gateway = gateway;             
        }

        public SetupNetworkInterface(string ipAddress, string subnetMask)
        {
            this.ipAddress = ipAddress;
            this.subnetMask = subnetMask;
        }

        /// <summary>
        /// For DHCP
        /// </summary>
        public SetupNetworkInterface()
        {

        }

    }
}

