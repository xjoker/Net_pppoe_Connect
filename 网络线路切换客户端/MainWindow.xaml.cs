using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows;


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
            //拨号图标的写入
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

            
            if(link_button.Content.ToString() != "断开")
            {
                try
                {
                    link_button.IsEnabled = false;
                    
                    string pppoe_id = "ctcc";//默认电信线路的账号
                    string pppoe_pw = "123";
                    if (lt_Radio.IsChecked==true)
                    {
                        pppoe_id = "cucc";
                    }
                    //使用匿名委托传递多个参数
                    Thread th = new Thread(delegate () { pppoe.pppoe_on(pppoe_id, pppoe_pw); });
                    th.IsBackground = true;
                    Console.WriteLine("--------Link-------start----------");
                    th.Start();

                    Thread.Sleep(500);
                    NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();//获取本机所有网卡对象
                    
                    foreach (NetworkInterface adapter in adapters)
                    {
                        Console.WriteLine("获取本地IP："+adapter.NetworkInterfaceType+" "+adapter.Description.ToString());
                        if (adapter.Description.Contains("CYJH"))//枚举条件：描述中包含"CYJH""
                        {
                            
                            IPInterfaceProperties ipProperties = adapter.GetIPProperties();//获取IP配置
                            UnicastIPAddressInformationCollection ipCollection = ipProperties.UnicastAddresses;//获取单播地址集
                            foreach (UnicastIPAddressInformation ip in ipCollection)
                            {
                                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)//只要ipv4的
                                    Label_Bendi.Content = ip.Address;//获取ip
                            }
                            if (adapter.OperationalStatus == OperationalStatus.Up)
                            {
                                Label_Zhuangtai.Content = "已连接";
                                link_button.Content = "断开";
                            }
                        }
                    }
                    link_button.IsEnabled = true;
                    dx_Radio.IsEnabled = false;
                    lt_Radio.IsEnabled = false;
                    GetIP();
                    
                    Console.WriteLine("--------Link-------OK");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                    //throw;
                }
                
            }
            else
            {
                link_button.IsEnabled = false;
                link_button.Content = "连接";
                pppoe.pppoe_off();
                Thread.Sleep(1000);
                GetIP();
                Label_Zhuangtai.Content = "未连接";
                link_button.IsEnabled = true;
                dx_Radio.IsEnabled = true;
                lt_Radio.IsEnabled = true;
            }
   

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GetIP();
        }

        //外网IP更新
        private void GetIP()
        {
            
            Label_Waiwang.Content = gii.GetIP();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pppoe.pppoe_off();
        }
    }
}
