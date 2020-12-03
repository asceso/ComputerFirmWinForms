using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    public static class UsersService
    {
        /// <summary>
        /// Получить сотрудника по логину
        /// </summary>
        /// <param name="Login">логин</param>
        /// <returns>модель сотрудника</returns>
        public static async Task<UserDataContract> GetUserByLogin(string Login)
            => await TunellProxy.UseTunellProxy(client => client.GetUserDataByLogin(Login));

        /// <summary>
        /// Получить коллекцию сотрудников
        /// </summary>
        /// <returns>IEnumerable сотрудников</returns>
        public static async Task<IEnumerable<UserDataContract>> GetUsersCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetUsersCollection());

        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        /// <param name="user">Модель сотрудника</param>
        /// <returns>Измененная модель сотрудника</returns>
        public static async Task<UserDataContract> InsertUser(UserDataContract user)
            => await TunellProxy.UseTunellProxy(client => client.InsertUser(user));

        /// <summary>
        /// Изменить сотрудника
        /// </summary>
        /// <param name="user">Модель сотрудника</param>
        /// <returns>Измененная модель сотрудника</returns>
        public static async Task<UserDataContract> UpdateUser(UserDataContract user)
            => await TunellProxy.UseTunellProxy(client => client.UpdateUser(user));

        /// <summary>
        /// Удалить сотрудника
        /// </summary>
        /// <param name="user">Сотрудник</param>
        /// <returns>количество удаленных записей</returns>
        public static async Task<int> DeleteUser(UserDataContract user)
            => await TunellProxy.UseTunellProxy(client => client.DeleteUser(user));
    }
}
