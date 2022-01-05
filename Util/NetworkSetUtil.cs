using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace NetworkCardHelper
{
    public class NetworkSetUtil
    {

        public static void SetIpAddres(string cardDesc, string ip)
        {

        }

        public static void SetGatewayAddres(string cardDesc, string gateway)
        {

        }

        public static void SetSubnetAddres(string cardDesc, string subnet)
        {

        }
        public static void SetDnsAddress(string cardDesc, string dns1, string dns2)
        {
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject cardProxy in queryCollection)
            {
                if (cardProxy["Description"].Equals(cardDesc))
                {
                    ManagementBaseObject inPar = cardProxy.GetMethodParameters("SetDNSServerSearchOrder");
                    inPar["DNSServerSearchOrder"] = new string[] { dns1, dns2 }; //设置DNS  1.DNS 2.备用DNS
                    cardProxy.InvokeMethod("SetDNSServerSearchOrder", inPar, null);// 执行
                    break;
                }
            }
        }

        public static ManagementObjectCollection GetNetworkAdapterConfiguration()
        {
            return new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
        }
    }
}
