using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace MSAccessCore
{
    public class AccessConnector : IDisposable
    {
        private readonly OleDbConnection Connection;
        public AccessConnector(string connectionString) => Connection = new OleDbConnection(connectionString);
        public OleDbCommand GetCommand() => Connection.CreateCommand();
        public string GetStoreProcedure(string Folder, string Name)
        {
            using StreamReader reader = new StreamReader($"{Environment.CurrentDirectory}\\StoredProcedures\\{Folder}\\{Name}");
            string buffer = reader.ReadToEnd();
            reader.Close();
            return buffer;
        }
        public void OpenConnect()
        {
            if (!Connection.State.Equals(ConnectionState.Open))
            {
                Connection.Open();
            }
        }
        public void CloseConnect()
        {
            if (!Connection.State.Equals(ConnectionState.Closed))
            {
                Connection.Close();
            }
        }
        public void Dispose()
        {
            CloseConnect();
            GC.Collect();
        }
    }
}
