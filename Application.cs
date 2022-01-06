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
        [Obsolete]
        public Application()
        {
            System.Net.IPAddress ip;
            Console.WriteLine(System.Net.IPAddress.TryParse("4.4.4", out ip));
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
                //Console.WriteLine(card.Description + "|" + card.Description.Contains("Direct Virtual Adapter"));

                // 只取以太网和WLAN
                if (card.NetworkInterfaceType.Equals(NetworkInterfaceType.Ethernet) || (card.NetworkInterfaceType.Equals(NetworkInterfaceType.Wireless80211) && !card.Description.Contains("Direct Virtual Adapter")))
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
            this.ReloadAfterSelectValueChanged();
        }

        private void ReloadAfterSelectValueChanged()
        {
            this.ClearIpInfo();

            object selectedItem = this.listBox_NetworkCard.SelectedItem;
            if (null == selectedItem)
            {
                return;
            }
            string selectValue = selectedItem.ToString();
            this.label_current_card_key_hidden.Text = selectValue;

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

        private void ReloadAfterSet(string key)
        {
            // 刷新网卡信息
            this.LoadNetworkCardInfoList();
            // 取当前应该存在的位置信息
            System.Collections.IEnumerator enumerator = this.listBox_NetworkCard.Items.GetEnumerator();
            int i = 0, index = -1;
            while (enumerator.MoveNext())
            {
                if (enumerator.Current.ToString().Equals(key))
                {
                    index = i;
                }
                i++;
            }

            if (index == -1)
            {
                Console.WriteLine("key: " + key + " 找不到匹配数据");
                return;
            }
            // 手动选中
            this.listBox_NetworkCard.SetSelected(index, true);
            // 重新加载选中数据
            this.ReloadAfterSelectValueChanged();
        }

        private void ClearIpInfo()
        {
            this.label_Id.Text = "网卡地址: ";
            this.label_MAC_Value.Text = "";
            this.label_CardSpeed_Value.Text = "";
            this.label_CardDesc_Value.Text = "";
            this.label_ip_value.Text = "";
            this.label_ip_subnet_value.Text = "";
            this.label_ip_gateway_value.Text = "";
            this.label_ip_dns1_value.Text = "";
            this.label_ip_dns2_value.Text = "";
        }

        private string getCardDesc()
        {
            return this.label_CardDesc_Value.Text;
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

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_ip_apply_Click(object sender, EventArgs e)
        {
            string key = this.label_current_card_key_hidden.Text;
            if (this.IpSet(true))
            {
                this.ReloadAfterSet(key);
            }
        }
        private bool IpSet(bool showBox)
        {
            if (!CheckBeforeIpSet())
            {
                return false;
            }
            // 数据校验
            bool ip = NetworkSetUtil.SetIpAddress(this.getCardDesc(), this.textBox_ip_ip.Text, this.textBox_ip_subnet.Text);
            if (ip)
            {
                bool gateway = NetworkSetUtil.SetGatewayAddress(this.getCardDesc(), this.textBox_ip_gateway.Text);
                if (gateway && showBox)
                {
                    if (this.DnsSet(false))
                    {
                        MessageBox.Show("IP设置成功");
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckBeforeIpSet()
        {

            // ip地址
            if (CommonUtil.isEmpty(this.textBox_ip_ip.Text))
            {
                MessageBox.Show("IP为空, 请检查!"); return false;
            }
            if (!CommonUtil.IsIp(this.textBox_ip_ip.Text))
            {
                MessageBox.Show("IP地址非法, 请检查!"); return false;
            }
            // 子网掩码
            if (CommonUtil.isEmpty(this.textBox_ip_subnet.Text))
            {
                MessageBox.Show("子网掩码为空, 请检查!"); return false;
            }
            if (!CommonUtil.IsIp(this.textBox_ip_subnet.Text))
            {
                MessageBox.Show("子网掩码地址非法, 请检查!"); return false;
            }
            // 网关
            if (CommonUtil.isEmpty(this.textBox_ip_gateway.Text))
            {
                MessageBox.Show("网关为空, 请检查!"); return false;
            }
            if (!CommonUtil.IsIp(this.textBox_ip_gateway.Text))
            {
                MessageBox.Show("网关地址非法, 请检查!"); return false;
            }
            // dns
            if (CommonUtil.isEmpty(this.textBox_ip_dns1.Text) && CommonUtil.isEmpty(this.textBox_ip_dns1.Text))
            {
                MessageBox.Show("DNS信息为空, 请检查!"); return false;
            }
            // 非空的时候 保证是ip 跳过空的时候
            if (CommonUtil.isNotEmpty(this.textBox_ip_dns1.Text) && !CommonUtil.IsIp(this.textBox_ip_dns1.Text))
            {
                MessageBox.Show("DNS地址非法, 请检查!"); return false;
            }
            if (CommonUtil.isNotEmpty(this.textBox_ip_dns2.Text) && !CommonUtil.IsIp(this.textBox_ip_dns2.Text))
            {
                MessageBox.Show("DNS地址非法, 请检查!"); return false;
            }

            return true;
        }

        private void button_dns_apply_Click(object sender, EventArgs e)
        {
            string key = this.label_current_card_key_hidden.Text;
            if (this.DnsSet(true))
            {
                this.ReloadAfterSet(key);
            }
        }

        private bool DnsSet(bool showBox)
        {
            bool result = NetworkSetUtil.SetDnsAddress(this.getCardDesc(), this.textBox_ip_dns1.Text, this.textBox_ip_dns2.Text);
            if (result && showBox)
            {
                MessageBox.Show("DNS设置成功");
            }

            return result;
        }

        private void button_ip_enable_dhcp_Click(object sender, EventArgs e)
        {
            if (NetworkSetUtil.EnableDHCP(this.label_CardDesc_Value.Text))
            {
                MessageBox.Show("DHCP已启用");
                this.ReloadAfterSet(this.label_current_card_key_hidden.Text);
            }
        }

        private void button_ip_enable_dns_Click(object sender, EventArgs e)
        {
            if (NetworkSetUtil.EnableDNS(this.label_CardDesc_Value.Text))
            {
                MessageBox.Show("DNS已启用");
                this.ReloadAfterSet(this.label_current_card_key_hidden.Text);
            }
        }
    }
}