using WCFCore;
using WCFCore.DataContracts;

namespace MainClient.Services
{
    internal static class UsersService
    {
        internal static UserDataContract GetUserByLogin(string Login)
            => TunellProxy.UseTunellProxy(client => client.GetUserDataByLogin(Login));
    }
}
