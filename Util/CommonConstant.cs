using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkCardHelper.Util
{
    public class CommonConstant
    {
        /// <summary>
        /// 用户主目录
        /// </summary>
        public static string USER_PROFILE_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        /// <summary>
        /// 项目作者目录
        /// </summary>
        public static string USER_PROFILE_PROJECT_DIRECTORY = "niushuai233";

        /// <summary>
        /// 项目名称
        /// </summary>
        public static string PROJECT_NAME = "NetworkCardHelper";

        /// <summary>
        /// 配置文件名称
        /// </summary>
        public static string CONFIG_FILENAME = "Configs.xml";
    }
}
