using System;
using System.ServiceModel;
using System.Threading.Tasks;
using WCFClient.Client;

namespace WCFProxy.Proxy
{
    public static class TunellProxy
    {
        public static string ServiceAddress = string.Empty;

        public static async Task<TypeReturn> UseTunellProxy<TypeReturn>(Func<ComFirmClient, TypeReturn> func)
        {
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            ComFirmClient client = null;
            try
            {
                client = new ComFirmClient(binding, new EndpointAddress(ServiceAddress));
                return await Task.FromResult(func.Invoke(client));
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
