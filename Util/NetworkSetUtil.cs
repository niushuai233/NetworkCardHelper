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

        public static bool SetIpAddress(string cardDesc, string ip, string subnet)
        {
            if (!CommonUtil.IsIp(ip))
            {
                MessageBox.Show("IP非法");
                return false;
            }

            if (!CommonUtil.IsIp(subnet))
            {
                MessageBox.Show("子网掩码非法");
                return false;
            }

            ManagementObject cardProxy = GetCardProxy(cardDesc);
            if (null != cardProxy)
            {
                ManagementBaseObject param = cardProxy.GetMethodParameters("EnableStatic");
                //设置IP
                param["IPAddress"] = new string[] { ip.Trim() };
                param["SubnetMask"] = new string[] { subnet.Trim() };
                // 执行
                ManagementBaseObject res = cardProxy.InvokeMethod("EnableStatic", param, null);

                // MessageBox.Show("SetIp: "+ res["returnValue"]);

                if (dealIpRes(res["returnValue"]))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool dealIpRes(object v)
        {
            if (v.ToString() == "0")
            {
                return true;
            }
            if (v.ToString() == "66")
            {
                MessageBox.Show("子网掩码非法");
                return false;
            }

            if(MessageBox.Show("IP设置失败, 错误码: " + v + "\n是否查看错误描述?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://docs.microsoft.com/zh-cn/windows/win32/cimwin32prov/enablestatic-method-in-class-win32-networkadapterconfiguration");
            }
            return false;
        }

        public static bool SetGatewayAddress(string cardDesc, string gateway)
        {
            ManagementObject cardProxy = GetCardProxy(cardDesc);
            if (null != cardProxy)
            {
                ManagementBaseObject param = cardProxy.GetMethodParameters("SetGateways");
                //设置IP
                param["DefaultIPGateway"] = new string[] { gateway.Trim() };
                // 执行
                ManagementBaseObject res = cardProxy.InvokeMethod("SetGateways", param, null);

                // MessageBox.Show("SetGateway: " + res["returnValue"]);

                if (dealIGatewayRes(res["returnValue"]))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool dealIGatewayRes(object v)
        {
            if (v.ToString() == "0")
            {
                return true;
            }

            if (MessageBox.Show("网关设置失败, 错误码: " + v + "\n是否查看错误描述?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://docs.microsoft.com/zh-cn/windows/win32/cimwin32prov/setgateways-method-in-class-win32-networkadapterconfiguration");
            }
            return false;
        }

        public static bool SetDnsAddress(string cardDesc, string dns1, string dns2)
        {
            if (CommonUtil.isEmpty(dns1) && CommonUtil.isEmpty(dns2)) { MessageBox.Show("DNS信息为空, 请检查!"); return false; }

            string[] dnsArr = null;
            if (CommonUtil.isEmpty(dns1))
            {
                dnsArr = new string[] { dns2.Trim() };
            }
            else if (CommonUtil.isEmpty(dns2))
            {
                dnsArr = new string[] { dns1.Trim() };
            }
            else 
            {
                dnsArr = new string[] { dns1.Trim(), dns2.Trim() };
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
                ManagementBaseObject res = cardProxy.InvokeMethod("SetDNSServerSearchOrder", param, null);// 执行

                // MessageBox.Show("SetDNS: " + res["returnValue"]);
                if (dealIDnsRes(res["returnValue"]))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool dealIDnsRes(object v)
        {
            if (v.ToString() == "0")
            {
                return true;
            }

            if (MessageBox.Show("DNS设置失败, 错误码: " + v + "\n是否查看错误描述?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://docs.microsoft.com/zh-cn/windows/win32/cimwin32prov/setdnsserversearchorder-method-in-class-win32-networkadapterconfiguration");
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
