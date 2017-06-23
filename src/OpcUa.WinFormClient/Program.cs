using Opc.Ua;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongFang.OpcUa.Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                ApplicationConfiguration appConfig = GetApplicationConfiguration();
                Application.Run(new MainForm(appConfig));
            }
            catch (Exception e)
            {
                ExceptionHelper.ShowExceptionDlg("软件初始化", e);
                return;
            }
        }

        public static ApplicationConfiguration GetApplicationConfiguration()
        {
            ApplicationConfiguration config = new ApplicationConfiguration
            {
                ApplicationName = "Data Access Client",
                ApplicationType = ApplicationType.Client,
                ApplicationUri = "urn:localhost:UASDK:DataAccessClient",
                CertificateValidator = new CertificateValidator
                {
                },
                ClientConfiguration = new ClientConfiguration
                {
                     DefaultSessionTimeout = 60000,
                     DiscoveryServers = new EndpointDescriptionCollection
                     {
                          new EndpointDescription("opc.tcp://127.0.0.1:4840"),
                          new EndpointDescription("http://127.0.0.1:52601/UADiscovery"),
                          new EndpointDescription("http://127.0.0.1/UADiscovery/Default.svc"),
                     },
                     MinSubscriptionLifetime = 10000,
                },
                SecurityConfiguration = new SecurityConfiguration
                {
                    ApplicationCertificate = new CertificateIdentifier
                    {
                        StoreType = "X509Store",
                        StorePath = "CurrentUser\\UA_MachineDefault",
                        SubjectName = "UA Core Sample Client"
                    },
                    TrustedPeerCertificates = new CertificateTrustList
                    {
                        StoreType = "Directory",
                        StorePath = "OPC Foundation/CertificateStores/UA Applications",
                    },
                    TrustedIssuerCertificates = new CertificateTrustList
                    {
                        StoreType = "Directory",
                        StorePath = "OPC Foundation/CertificateStores/UA Certificate Authorities",
                    },
                    RejectedCertificateStore = new CertificateTrustList
                    {
                        StoreType = "Directory",
                        StorePath = "OPC Foundation/CertificateStores/RejectedCertificates",
                    },
                    NonceLength = 32,
                    AutoAcceptUntrustedCertificates = true
                },
                TransportConfigurations = new TransportConfigurationCollection(),
                TransportQuotas = new TransportQuotas
                {
                    OperationTimeout = 600000,
                    MaxStringLength = 1048576,
                    MaxByteStringLength = 1048576,
                    MaxArrayLength = 65535,
                    MaxMessageSize = 4194304,
                    MaxBufferSize = 65535,
                    ChannelLifetime = 300000,
                    SecurityTokenLifetime = 3600000
                }
            };
            return config;
        }
    }
}
