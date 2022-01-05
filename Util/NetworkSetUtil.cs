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
            foreach (ManagementObject m in queryCollection)
            {
                if (m["Description"].Equals(cardDesc))
                {
                    Console.WriteLine("Index : {0}", m["Index"]);
                    Console.WriteLine("Description : {0}", m["Description"]);
                    Console.WriteLine();
                }
            }

            //ManagementObjectCollection managementObjectCollection = GetNetworkAdapterConfiguration();

            //foreach (ManagementObject item in managementObjectCollection)
            //{
            //    Console.WriteLine(item.GetType().Name);
            //    Console.WriteLine(item.GetType().FullName);
            //    Console.WriteLine(item.GetType().Namespace);
            //    Console.WriteLine();
            //}
        }

        public static ManagementObjectCollection GetNetworkAdapterConfiguration()
        {
            return new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
        }
    }
}
