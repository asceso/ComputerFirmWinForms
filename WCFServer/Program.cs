using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using InjectingCoreLibrary.MapperCore.ServerImplementation;
using WCFClient.Client;
using WCFCore.ServiceContracts;

namespace WCFServer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string UseMSAccess = ConfigurationManager.AppSettings["UseMSAccess"];

            //создаем маппер
            ServerMapperCore.CreateServerMapper();

            //запускаем сервер
            Console.WriteLine("Старт сервера...");

            if (UseMSAccess.ToBool())
            {
                Console.WriteLine("Используется MS Access в качестве БД");
            }
            else
            {
                Console.WriteLine("Используется SQL EF Client в качестве БД");
            }

            Uri baseAddress = new Uri("net.tcp://localhost:555//");

            ServiceHost host;
            if (UseMSAccess.ToBool())
            {
                host = new ServiceHost(typeof(WCFAccessContext), baseAddress);
            }
            else
            {
                host = new ServiceHost(typeof(WCFDataContext), baseAddress);
            }

            try
            {
                NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
                ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IDataTransfer), binding, "ComFirmClient");

                host.Description.Behaviors.Remove(typeof(ServiceDebugBehavior));
                host.Description.Behaviors.Add(new ServiceDebugBehavior { IncludeExceptionDetailInFaults = true });

                host.Open();

                IPAddress currentIP = Dns.GetHostEntry(Dns.GetHostName())
                    .AddressList
                    .FirstOrDefault(x => x.IsIPv6LinkLocal.Equals(false));

                Console.WriteLine($"Текущий IP адрес: {currentIP}");
                Console.WriteLine("Сервер готов к работе. Для завершения работы введите <Exit>");

                while (!Console.ReadLine().Equals("Exit"))
                { }
                host.Close();
                Environment.Exit(0);
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine($"Произошла ошибка коммуникации: {ce.Message}");
                host.Abort();
            }
        }
    }
}
