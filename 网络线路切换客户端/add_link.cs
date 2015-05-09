﻿using System.IO;

namespace 网络线路切换客户端
{
    class add_link
    {
        public static void  Create_link(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            #region 宽带连接内的文本.....
            sw.Write("[CYJH]");
            sw.Write("Encoding=1");
            sw.Write("PBVersion=3");
            sw.Write("Type=5");
            sw.Write("AutoLogon=0");
            sw.Write("UseRasCredentials=0");
            sw.Write("LowDateTime=-818462512");
            sw.Write("HighDateTime=30443896");
            sw.Write("DialParamsUID=20892187");
            sw.Write("Guid=72F5E29CB04A004FA5424259E7490741");
            sw.Write("VpnStrategy=0");
            sw.Write("ExcludedProtocols=0");
            sw.Write("LcpExtensions=1");
            sw.Write("DataEncryption=8");
            sw.Write("SwCompression=0");
            sw.Write("NegotiateMultilinkAlways=0");
            sw.Write("SkipDoubleDialDialog=0");
            sw.Write("DialMode=0");
            sw.Write("OverridePref=15");
            sw.Write("RedialAttempts=3");
            sw.Write("RedialSeconds=60");
            sw.Write("IdleDisconnectSeconds=0");
            sw.Write("RedialOnLinkFailure=1");
            sw.Write("CallbackMode=0");
            sw.Write("CustomDialDll=");
            sw.Write("CustomDialFunc=");
            sw.Write("CustomRasDialDll=");
            sw.Write("ForceSecureCompartment=0");
            sw.Write("DisableIKENameEkuCheck=0");
            sw.Write("AuthenticateServer=0");
            sw.Write("ShareMsFilePrint=0");
            sw.Write("BindMsNetClient=0");
            sw.Write("SharedPhoneNumbers=0");
            sw.Write("GlobalDeviceSettings=0");
            sw.Write("PrerequisiteEntry=");
            sw.Write("PrerequisitePbk=");
            sw.Write("PreferredPort=PPPoE6-0");
            sw.Write("PreferredDevice=WAN 微型端口(PPPOE)");
            sw.Write("PreferredBps=0");
            sw.Write("PreferredHwFlow=0");
            sw.Write("PreferredProtocol=0");
            sw.Write("PreferredCompression=0");
            sw.Write("PreferredSpeaker=0");
            sw.Write("PreferredMdmProtocol=0");
            sw.Write("PreviewUserPw=1");
            sw.Write("PreviewDomain=0");
            sw.Write("PreviewPhoneNumber=0");
            sw.Write("ShowDialingProgress=1");
            sw.Write("ShowMonitorIconInTaskBar=1");
            sw.Write("CustomAuthKey=0");
            sw.Write("AuthRestrictions=552");
            sw.Write("IpPrioritizeRemote=1");
            sw.Write("IpInterfaceMetric=0");
            sw.Write("IpHeaderCompression=0");
            sw.Write("IpAddress=0.0.0.0");
            sw.Write("IpDnsAddress=0.0.0.0");
            sw.Write("IpDns2Address=0.0.0.0");
            sw.Write("IpWinsAddress=0.0.0.0");
            sw.Write("IpWins2Address=0.0.0.0");
            sw.Write("IpAssign=1");
            sw.Write("IpNameAssign=1");
            sw.Write("IpDnsFlags=0");
            sw.Write("IpNBTFlags=0");
            sw.Write("TcpWindowSize=0");
            sw.Write("UseFlags=3");
            sw.Write("IpSecFlags=0");
            sw.Write("IpDnsSuffix=");
            sw.Write("Ipv6Assign=1");
            sw.Write("Ipv6Address=::");
            sw.Write("Ipv6PrefixLength=0");
            sw.Write("Ipv6PrioritizeRemote=1");
            sw.Write("Ipv6InterfaceMetric=0");
            sw.Write("Ipv6NameAssign=1");
            sw.Write("Ipv6DnsAddress=::");
            sw.Write("Ipv6Dns2Address=::");
            sw.Write("Ipv6Prefix=0000000000000000");
            sw.Write("Ipv6InterfaceId=0000000000000000");
            sw.Write("DisableClassBasedDefaultRoute=0");
            sw.Write("DisableMobility=0");
            sw.Write("NetworkOutageTime=0");
            sw.Write("ProvisionType=0");
            sw.Write("PreSharedKey=");
            sw.Write("CacheCredentials=0");
            sw.Write("NumCustomPolicy=0");
            sw.Write("NumEku=0");
            sw.Write("UseMachineRootCert=0");
            sw.Write("NumServers=0");
            sw.Write("NumRoutes=0");
            sw.Write("NumNrptRules=0");
            sw.Write("AutoTiggerCapable=0");
            sw.Write("NumAppIds=0");
            sw.Write("NumClassicAppIds=0");
            sw.Write("DisableDefaultDnsSuffixes=0");
            sw.Write("NumTrustedNetworks=0");
            sw.Write("NumDnsSearchSuffixes=0");
            sw.Write("PowershellCreatedProfile=0");
            sw.Write("ProxyFlags=0");
            sw.Write("ProxySettingsModified=0");
            sw.Write("ProvisioningAuthority=");
            sw.Write("AuthTypeOTP=0");
            sw.Write("");
            sw.Write("NETCOMPONENTS=");
            sw.Write("ms_msclient=0");
            sw.Write("ms_server=0");
            sw.Write("");
            sw.Write("MEDIA=rastapi");
            sw.Write("Port=PPPoE6-0");
            sw.Write("Device=WAN 微型端口(PPPOE)");
            sw.Write("");
            sw.Write("DEVICE=PPPoE");
            sw.Write("LastSelectedPhone=0");
            sw.Write("PromoteAlternates=0");
            sw.Write("TryNextAlternateOnFail=1");
            sw.Write("");
            sw.Write(""); 
            #endregion

            sw.Flush();
            sw.Close();
            fs.Close();

        }
    }
}
