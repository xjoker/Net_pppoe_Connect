using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 网络线路切换客户端
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        GET_Internet_IP gii = new GET_Internet_IP();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var pathWithEnv = @"%userprofile%\AppData\Roaming\Microsoft\Network\Connections\Pbk\rasphone.pbk";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            if (!System.IO.File.Exists(filePath))
            {
                add_link.Create_link(filePath);
            }
            Label_Waiwang.Content = gii.GetIP();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string ras_log;
            if(link_button.Content.ToString() != "断开")
            {
                link_button.Content = "断开";
                string pppoe_id = "ctcc";//默认电信线路的账号
                string pppoe_pw = "123";
                if ((bool)lt_Radio.IsChecked)
                {
                    pppoe_id = "cucc";
                }
                Process p = new Process();


                p.StartInfo.FileName = "rasdial.exe";

                //几个必要的参数
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.Arguments = " CYJH " + pppoe_id + " " + pppoe_pw;
                p.Start();
                ras_log = p.StandardOutput.ReadToEnd();
                //p.Close();
                Label_Waiwang.Content = gii.GetIP();
            }
            else
            {

                link_button.Content = "连接";

                Process p = new Process();

                p.StartInfo.FileName = "rasdial.exe";

                //几个必要的参数
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.Arguments = " CYJH /DISCONNECT";
                p.Start();
                ras_log = p.StandardOutput.ReadToEnd();
                //p.Close();
                Label_Waiwang.Content = gii.GetIP();
            }
   
           




        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Label_Waiwang.Content = gii.GetIP();
        }
    }
}
