using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace 网络线路切换客户端
{
    class GET_Internet_IP
    {
        public string GetIP()
        {
            string tempip = "";
            int count =0;
            while (count<3)
            {
                Thread.Sleep(500);
                try
                {
                    Console.WriteLine("get_ip: " + count);
                    ///截取网站数据
                    ///数据范例 ：您的IP是：[122.228.229.21] 来自：浙江省温州市 电信
                    /// 
                    System.Console.WriteLine("-------web----read---start--");
                    WebRequest wr = WebRequest.Create("http://1111.ip138.com/ic.asp");

                    wr.Timeout = 5000;
                    Stream s = wr.GetResponse().GetResponseStream();
                    StreamReader sr = new StreamReader(s, Encoding.Default);
                    string all = sr.ReadToEnd(); //读取网站的数据
                    System.Console.WriteLine("-------web----read-------");
                    int start = all.IndexOf("[") + 1;
                    int end = all.IndexOf("]", start);
                    tempip = all.Substring(start, end - start);


                    start = all.IndexOf("自") + 2;
                    end = all.IndexOf("<", start);
                    tempip = tempip + "  " + all.Substring(start, end - start);


                    sr.Close();
                    s.Close();
                    System.Console.WriteLine("-------web--------OK-----");
                    count = 3;
                    return tempip;
                }
                catch (Exception ex)
                {
                    count++;
                    //Console.WriteLine(count);
                }
                //Console.WriteLine(count);
                //return tempip;
            }
            return tempip="获取失败!";
        }
    }
}

