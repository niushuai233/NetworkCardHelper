using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCardHelper
{
    public class NetworkSetUtil
    {

        public static bool SetIpAddress(string cardDesc, string ip)
        {
            if (!CommonUtil.IsIp(ip))
            {
                MessageBox.Show("IP非法");
                return false;
            }

            ManagementObject cardProxy = GetCardProxy(cardDesc);
            if (null != cardProxy)
            {
                ManagementBaseObject param = cardProxy.GetMethodParameters("SetDNSServerSearchOrder");
                //设置IP
                param["IPAddress"] = ip; 
                // 执行
                cardProxy.InvokeMethod("EnableStatic", param, null);
                return true;
            }
            return false;
        }

        public static bool SetGatewayAddress(string cardDesc, string gateway)
        {
            return false;
        }

        public static bool SetSubnetAddress(string cardDesc, string subnet)
        {
            return false;
        }
        public static bool SetDnsAddress(string cardDesc, string dns1, string dns2)
        {
            if (CommonUtil.isEmpty(dns1) && CommonUtil.isEmpty(dns2)) { MessageBox.Show("DNS信息为空, 请检查!"); return false; }

            string[] dnsArr;
            if (CommonUtil.isEmpty(dns1))
            {
                dnsArr = new string[] { dns2 };
            }
            else
            {
                dnsArr = new string[] { dns1, dns2 };
            }

            // 校验dnsarr是否均为ipv4地址
            if (!CommonUtil.AllIsIp(dnsArr))
            {
                MessageBox.Show("DNS地址非法");
                return false;
            }

            ManagementObject cardProxy = GetCardProxy(cardDesc);
            if (null != cardProxy)
            {
                ManagementBaseObject param = cardProxy.GetMethodParameters("SetDNSServerSearchOrder");
                param["DNSServerSearchOrder"] = dnsArr; //设置DNS  1.DNS 2.备用DNS
                cardProxy.InvokeMethod("SetDNSServerSearchOrder", param, null);// 执行
                return true;
            }
            return false;
        }

        public static ManagementObject GetCardProxy(string cardDesc)
        {
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject cardProxy in queryCollection)
            {
                if (cardProxy["Description"].Equals(cardDesc))
                {
                    return cardProxy;
                }
            }
            // 找不到对应的网卡信息
            MessageBox.Show("未找到相应的网卡信息 " + cardDesc);
            return null;
        }

        public static ManagementObjectCollection GetNetworkAdapterConfiguration()
        {
            return new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
        }

    }
}
