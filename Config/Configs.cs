using NetworkCardHelper.Base;
using NetworkCardHelper.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NetworkCardHelper
{
    [XmlRootAttribute("Configs", IsNullable = false)]
    public class Configs
    {

        /// <summary>
        /// 多个ip信息配置
        /// </summary>
        public List<IpInfo> ipInfoList;

        public static Configs LoadConfig()
        {
            string path = CommonUtil.GetConfigLocation();
            Configs configs = new Configs();
            if (!File.Exists(path))
            {
                Console.WriteLine("配置文件不存在, 新建. | " + path);
                CommonUtil.CreateProjectFolder();
                XmlUtil.Obj2Xml<Configs>(path, configs);
                return configs;
            }

            configs = XmlUtil.Xml2Obj<Configs>(path);
            return configs;
        }

        public static IpInfo GetIpInfo(string configName)
        {

            List<IpInfo> list = LoadConfig().ipInfoList;
            foreach (var item in list)
            {
                if (item.ConfigName.Equals(configName))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
