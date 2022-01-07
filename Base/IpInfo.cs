using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCardHelper.Base
{
    public class IpInfo
    {
        public string ConfigName { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 子网掩码
        /// </summary>
        public string Subnet { get; set; }

        /// <summary>
        /// 网关
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// 主DNS
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// 备DNS
        /// </summary>
        public string Dns2 { get; set; }


        public bool verify()
        {
            if (!CommonUtil.IsIp(Ip))
            {
                MessageBox.Show("ip地址有误");
                return false;
            }
            if (!CommonUtil.IsIp(Subnet))
            {
                MessageBox.Show("子网掩码有误");
                return false;
            }
            if (!CommonUtil.IsIp(Gateway))
            {
                MessageBox.Show("网关地址有误");
                return false;
            }

            if (!CommonUtil.IsIp(Dns1) && !CommonUtil.IsIp(Dns2))
            {
                MessageBox.Show("DNS地址有误");
                return false;
            }

            return true;
        }
    }
}
