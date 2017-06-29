using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Opc.Ua;
using Opc.Ua.Server;

namespace OpcUaServerDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Task<ApplicationConfiguration> t = LoadApplicationConfiguration();
                t.Wait();
                ApplicationConfiguration config = t.Result;
                if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
                }
                DemoServer1 server = new DemoServer1();
                server.Start(config);
                Console.WriteLine("{0}Server has Started! Uri:", config.ApplicationName);
                var uris = server.ServerUris;
                foreach (var uri in uris)
                {
                    Console.WriteLine(uri.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public static async Task<ApplicationConfiguration> LoadApplicationConfiguration()
        {
            string filePath = ApplicationConfiguration.GetFilePathFromAppConfig("Demo1Server");
            ApplicationConfiguration configuration = await ApplicationConfiguration.Load("Demo1Server", ApplicationType.Server);

            if (configuration == null)
            {
                throw ServiceResultException.Create(StatusCodes.BadConfigurationError, "Could not load configuration file.");
            }
            FixupAppConfig(configuration);
            return configuration;
        }

        public static ApplicationConfiguration FixupAppConfig(
            ApplicationConfiguration configuration)
        {
            configuration.ApplicationUri = Utils.ReplaceLocalhost(configuration.ApplicationUri);
            if (configuration.ServerConfiguration != null)
            {
                for (int i = 0; i < configuration.ServerConfiguration.BaseAddresses.Count; i++)
                {
                    configuration.ServerConfiguration.BaseAddresses[i] =
                        Utils.ReplaceLocalhost(configuration.ServerConfiguration.BaseAddresses[i]);
                }
            }
            return configuration;
        }

        private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            Debug.WriteLine("Accepted Certificate: {0}", e.Certificate.Subject);
            e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted);
        }
    }
}