using NetworkCardHelper.Base;
using NetworkCardHelper.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCardHelper.Forms
{
    public partial class ConfigForm : Form
    {
        private IpInfo ip;
        public ConfigForm(IpInfo tmp)
        {
            ip = tmp;
            InitializeComponent();
        }

        private void button_config_save_Click(object sender, EventArgs e)
        {
            // 配置名称必填
            string configName = this.textBox_configName.Text;
            if (CommonUtil.isEmpty(configName))
            {
                MessageBox.Show("请输入配置名称");
                return;
            }
            ip.ConfigName = configName;
            // 加载配置
            Configs configs = Configs.LoadConfig();
            if (CommonUtil.isEmpty(configs.ipInfoList))
            {
                // 防止配置不存在 NPE
                configs.ipInfoList = new List<IpInfo>();
            }
            // 转map便于查找是否存在相同名称的内容
            MapExt map = new MapExt();
            configs.ipInfoList.ForEach(delegate(IpInfo ip)
            {
                map.Put(ip.ConfigName, ip);
            });

            if (map.ContainsKey(configName))
            {
                if (MessageBox.Show("名称已存在, 是否覆盖", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    map.Remove(configName);
                    map.Put(configName, ip);
                }
                else
                {
                    return;
                }
            } 
            else
            {
                map.Put(configName, ip);
            }

            // 未找到相同名称的 新增保存
            configs.ipInfoList.Clear();
            foreach (var key in map.Keys)
            {
                configs.ipInfoList.Add((IpInfo)map.Get(key));
            }
            XmlUtil.Obj2Xml(CommonUtil.GetConfigLocation(), configs);

            MessageBox.Show("保存成功");
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.textBox_configName.Text = "";
            this.Close();
        }
    }
}
