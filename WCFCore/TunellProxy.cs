using System;
using System.ServiceModel;

namespace WCFCore
{
    public static class TunellProxy
    {
        private static readonly string serviceAdress = "net.tcp://192.168.0.10:555//";
        private static readonly string serviceName = "ComFirmClient";

        public static TypeReturn UseTunellProxy<TypeReturn>(Func<ComFirmClient, TypeReturn> func)
        {
            NetTcpBinding binding = new NetTcpBinding();
            ComFirmClient client = null;
            try
            {
                client = new ComFirmClient(binding, new EndpointAddress($"{serviceAdress}{serviceName}"));
                return func.Invoke(client);
            }
            catch
            {
                client?.Abort();
                throw;
            }
            finally
            {
                client?.Close();
            }
        }
    }
}
