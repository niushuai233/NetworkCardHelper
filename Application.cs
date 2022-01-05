using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCardHelper
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
            this.LoadNetworkCardInfoList();
        }

        private void LoadNetworkCardInfoList()
        {
            this.listBox_NetworkCard.Items.Clear();
            CommonUtil.ALL_NETWORK_INTERFACE_LIST.Clear();
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface card in allNetworkInterfaces)
            {
                // 只取以太网和WLAN
                if (card.NetworkInterfaceType.Equals(NetworkInterfaceType.Wireless80211) || card.NetworkInterfaceType.Equals(NetworkInterfaceType.Ethernet))
                {
                    string item = card.NetworkInterfaceType + " - " + card.Name;
                    this.listBox_NetworkCard.Items.Add(item);

                    CommonUtil.ALL_NETWORK_INTERFACE_LIST.Put(item, card);
                }
            }
        }

        private void LoadNetworkCardInfoList_Click(object sender, EventArgs e)
        {
            this.LoadNetworkCardInfoList();
        }

        [Obsolete]
        private void NetworkCard_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ClearIpInfo();

            object selectedItem = this.listBox_NetworkCard.SelectedItem;
            if (null == selectedItem)
            {
                return;
            }
            string selectValue = selectedItem.ToString();

            NetworkInterface card = (NetworkInterface)CommonUtil.ALL_NETWORK_INTERFACE_LIST.Get(selectValue);

            this.groupBox_IpInfo.Text = "信息区： " + card.Id;
            this.label_MAC_Value.Text = card.GetPhysicalAddress().ToString();
            this.label_CardSpeed_Value.Text = CommonUtil.SpeedCalc(card.Speed);
            this.label_CardDesc_Value.Text = card.Description;

            IPInterfaceProperties ipInterfaceProperties = card.GetIPProperties();

            List<UnicastIPAddressInformation> unicastIPAddressInformations = ipInterfaceProperties.UnicastAddresses.ToList();
            foreach (var item in unicastIPAddressInformations)
            {
                string ipv4 = "";
                string mask = "";
                if (item.Address.AddressFamily.Equals(AddressFamily.InterNetwork))
                {
                    ipv4 += item.Address.ToString() + "/";
                    mask += item.IPv4Mask.ToString() + "/";
                }
                if (ipv4.EndsWith("/"))
                {
                    ipv4 = ipv4.Substring(0, ipv4.Length - 1);
                    mask = mask.Substring(0, mask.Length - 1);
                }
                // IPV4地址
                this.label_ip_value.Text = ipv4;
                // 子网掩码
                this.label_ip_subnet_value.Text = mask;
            }

            // 网关
            List<GatewayIPAddressInformation> gatewayIpList = ipInterfaceProperties.GatewayAddresses.ToList();
            if (null != gatewayIpList && gatewayIpList.Count > 0)
            {
                this.label_ip_gateway_value.Text = gatewayIpList.Last().Address.ToString();
            }

            try
            {
                List<System.Net.IPAddress> dnsAddress = ipInterfaceProperties.DnsAddresses.ToList();
                if (null != dnsAddress && dnsAddress.Count > 0)
                {
                    List<IPAddress> v4Dns = new List<IPAddress>();
                    foreach (IPAddress item in dnsAddress)
                    {
                        if (!item.AddressFamily.Equals(AddressFamily.InterNetwork))
                        {
                            continue;
                        }
                        v4Dns.Add(item);
                    }

                    // ipv4
                    if (v4Dns.Count > 0)
                    {
                        // DNS1
                        this.label_ip_dns1_value.Text = v4Dns.First().ToString();
                    }

                    if (v4Dns.Count > 1)
                    {
                        // DNS2
                        this.label_ip_dns2_value.Text = v4Dns.Last().ToString();
                    }
                }
            }
            catch (Exception) { }
        }

        private void ClearIpInfo()
        {
            this.label_Id.Text = "信息区: ";
            this.label_MAC_Value.Text = "";
            this.label_CardSpeed_Value.Text = "";
            this.label_CardDesc_Value.Text = "";
            this.label_ip_value.Text = "";
            this.label_ip_subnet_value.Text = "";
            this.label_ip_gateway_value.Text = "";
            this.label_ip_dns1_value.Text = "";
            this.label_ip_dns2_value.Text = "";
        }

        private void button_trans_ip_Click(object sender, EventArgs e)
        {
            this.textBox_ip_ip.Text = this.label_ip_value.Text;
        }

        private void button_trans_gateway_Click(object sender, EventArgs e)
        {
            this.textBox_ip_gateway.Text = this.label_ip_gateway_value.Text;
        }

        private void button_trans_subnet_Click(object sender, EventArgs e)
        {
            this.textBox_ip_subnet.Text = this.label_ip_subnet_value.Text;
        }

        private void button_trans_dns1_Click(object sender, EventArgs e)
        {
            this.textBox_ip_dns1.Text = this.label_ip_dns1_value.Text;
        }

        private void button_trans_dns2_Click(object sender, EventArgs e)
        {
            this.textBox_ip_dns2.Text = this.label_ip_dns2_value.Text;
        }
    }
}
