using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    public static class UsersService
    {
        public static async Task<UserDataContract> GetUserByLogin(string Login)
            => await TunellProxy.UseTunellProxy(client => client.GetUserDataByLogin(Login));
        public static async Task<IEnumerable<UserDataContract>> GetUsersCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetUsersCollection());
        public static async Task<UserDataContract> InsertUser(UserDataContract user)
            => await TunellProxy.UseTunellProxy(client => client.InsertUser(user));
        public static async Task<UserDataContract> UpdateUser(UserDataContract user)
            => await TunellProxy.UseTunellProxy(client => client.UpdateUser(user));
        public static async Task<int> DeleteUser(UserDataContract user)
            => await TunellProxy.UseTunellProxy(client => client.DeleteUser(user));
    }
}
