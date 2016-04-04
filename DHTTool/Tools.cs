using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace DHTTool
{
    public class Tools
    {
        /// <summary>
        /// 取IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetIp()
        {
            string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (result == null || result == "")
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (result == null || result == "")
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }
            return result;
        }

        /// <summary>
        /// 自定义正式验证
        /// </summary>
        /// <param name="str"></param>
        /// <param name="regex"></param>
        /// <returns></returns>
        public static bool CustomRegex(string str, string regex)
        {
            return Regex.IsMatch(str, regex);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="content"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static void SaveFile(string content,string path)
        {
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Flush();
            sw.BaseStream.Seek(0, SeekOrigin.Begin);
            sw.Write(content);
            sw.Close();
        }

        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read,FileShare.None);
            StreamReader sr = new StreamReader(fs);
            //sr.BaseStream.Seek(734, SeekOrigin.Begin);
            string content = sr.ReadToEnd();
            sr.Close();
            return content;
        }
    }
}
