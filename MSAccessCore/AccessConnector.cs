using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace MSAccessCore
{
    /// <summary>
    /// Класс доступа к БД MS Access
    /// </summary>
    public class AccessConnector : IDisposable
    {
        #region fields
        private readonly OleDbConnection Connection;
        #endregion
        #region ctor

        /// <summary>
        /// Создает подключение к БД
        /// </summary>
        /// <param name="connectionString">Строка подключения</param>
        /// <param name="doOpen">Если установлен в true открывает подключение</param>
        public AccessConnector(string connectionString, bool doOpen = true)
        {
            Connection = new OleDbConnection(connectionString);
            if (doOpen)
            {
                OpenConnect();
            }
        }

        #endregion
        #region additional methods

        /// <summary>
        /// Создать пустую команду на основании подключения
        /// </summary>
        /// <returns>OleDbCommand пустая</returns>
        public OleDbCommand GetCommand() => Connection.CreateCommand();

        /// <summary>
        /// Получить файл процедуры из SQL файла
        /// </summary>
        /// <param name="Folder">Папка с процедурой</param>
        /// <param name="Name">Имя процедуры</param>
        /// <returns></returns>
        public string GetStoreProcedure(string Folder, string Name)
        {
            using StreamReader reader = new StreamReader($"{Environment.CurrentDirectory}\\StoredProcedures\\{Folder}\\{Name}.sql");
            string buffer = reader.ReadToEnd();
            reader.Close();
            return buffer;
        }

        #endregion
        #region connect manage

        /// <summary>
        /// Открывает соединение с БД
        /// </summary>
        public void OpenConnect()
        {
            if (!Connection.State.Equals(ConnectionState.Open))
            {
                Connection.Open();
            }
        }

        /// <summary>
        /// Закрывает соединение с БД
        /// </summary>
        public void CloseConnect()
        {
            if (!Connection.State.Equals(ConnectionState.Closed))
            {
                Connection.Close();
            }
        }

        #endregion
        #region IDisposable

        /// <summary>
        /// Реализовано для using Собирает мусор при удалении
        /// </summary>
        public void Dispose()
        {
            CloseConnect();
            GC.Collect();
        }

        #endregion
    }
}
