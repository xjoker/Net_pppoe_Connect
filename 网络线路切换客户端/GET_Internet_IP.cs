using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 网络线路切换客户端
{
    class GET_Internet_IP
    {
        public string GetIP()
        {
            string tempip = "";
            try
            {
                WebRequest wr = WebRequest.Create("http://1111.ip138.com/ic.asp");
                Stream s = wr.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(s, Encoding.Default);
                string all = sr.ReadToEnd(); //读取网站的数据

                int start = all.IndexOf("[") + 1;
                int end = all.IndexOf("]", start);
                tempip = all.Substring(start, end - start);


                start = all.IndexOf("自") + 2;
                end = all.IndexOf("<", start);
                tempip = tempip+"  "+all.Substring(start, end - start);
                

                sr.Close();
                s.Close();
            }
            catch
            {
            }
            return tempip;
        }
    }
}

