using System;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using AutoMapper;
using WCFCore;
using WCFCore.ServiceContracts;
using WCFMapperService;
using WCFServer.MapperProfiles;

namespace WCFServer
{
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            //создаем маппер
            ServerMapperCore.CreateServerMapper(new Profile[] {
                new UsersServerMapperProfile(),
            });

            //запускаем сервер
            Console.WriteLine("Старт сервера...");
            Uri baseAddress = new Uri("net.tcp://localhost:555//");
            ServiceHost host = new ServiceHost(typeof(WCFDataContext), baseAddress);

            try
            {
                NetTcpBinding binding = new NetTcpBinding();
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
