using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkCardHelper
{
    public class CommonUtil
    {
        public static NetworkCardHelper.Base.MapExt ALL_NETWORK_INTERFACE_LIST = new NetworkCardHelper.Base.MapExt();

        public static string SpeedCalc(long speed)
        {

            if (speed <= 0)
            {
                return speed.ToString();
            }

            if (speed / 1000 > 0)
            {
                if (speed / 1000000 > 0)
                {
                    if (speed / 1000000000 > 0)
                    {
                        return (speed / 1000000000) + " Gbps";
                    }
                    return (speed / 1000000) + " Mbps";
                }
                return (speed / 1000) + " Kbps";
            }
            return speed.ToString();
        }

        public static long IpToLong(string ip)
        {
            char[] separator = new char[] { '.' };
            string[] items = ip.Split(separator);
            return long.Parse(items[0]) << 24
                    | long.Parse(items[1]) << 16
                    | long.Parse(items[2]) << 8
                    | long.Parse(items[3]);
        }

        public static string LongToIp(long ipLong)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((ipLong >> 24) & 0xFF).Append(".");
            sb.Append((ipLong >> 16) & 0xFF).Append(".");
            sb.Append((ipLong >> 8) & 0xFF).Append(".");
            sb.Append(ipLong & 0xFF);
            return sb.ToString();
        }

        public static bool isEmpty(string source)
        {
            return null == source || source.Trim().Length == 0;
        }

        public static bool isNotEmpty(string source)
        {
            return !isEmpty(source);
        }
        public static bool isEmpty(string[] source)
        {
            return null == source || source.Length == 0;
        }

        public static bool isNotEmpty(string[] source)
        {
            return !isEmpty(source);
        }

        public static bool isEmpty<T>(List<T> source)
        {
            return null == source || source.Count == 0;
        }

        public static bool isNotEmpty<T>(List<T> source)
        {
            return !isEmpty<T>(source);
        }

        public static bool IsIp(string ip)
        {
            System.Net.IPAddress address;
            return System.Net.IPAddress.TryParse(ip, out address);
        }

        public static bool AllIsIp(string[] ipArr)
        {
            if (isEmpty(ipArr))
            {
                return false;
            }
            foreach (string ip in ipArr)
            {
                if (!IsIp(ip))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
