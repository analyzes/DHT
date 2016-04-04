using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace DHTTool
{
    /// <summary>
    /// Http提交数据
    /// </summary>
    public class HttpRequest
    {
        /// <summary>
        /// Post方式
        /// </summary>
        /// <param name="url">请求链接</param>
        /// <param name="data">post提交的数据</param>
        /// <param name="encoding">编码</param>
        /// <returns></returns>
        public static string HttpPost(string url, string data, string encoding)
        {
            string backstr = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                byte[] requestBytes = System.Text.Encoding.GetEncoding(encoding).GetBytes(data);
                req.Method = "POST";
                req.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.1.4322)";
                req.ContentType = "application/x-www-form-urlencoded;charset=" + encoding;
                req.ContentLength = requestBytes.Length;
                Stream requestStream = req.GetRequestStream();
                requestStream.Write(requestBytes, 0, requestBytes.Length);
                requestStream.Close();

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Encoding encode = Encoding.GetEncoding(encoding);
                StreamReader sr = new StreamReader(res.GetResponseStream(), encode);
                backstr = sr.ReadToEnd();
                sr.Close();
                res.Close();
            }
            catch { }
            return backstr;
        }

        /// <summary>
        /// Get方式
        /// </summary>
        /// <param name="url">请求链接</param>
        /// <param name="encoding">编码</param>
        /// <returns></returns>
        public static string HttpGet(string url, string encoding)
        {
            string strResult = "";
            try
            {
                System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                Encoding encode = Encoding.GetEncoding(encoding);
                StreamReader streamReader = new StreamReader(streamReceive, encode);
                strResult = streamReader.ReadToEnd();
            }
            catch { }
            return strResult;
        }
    }
}
