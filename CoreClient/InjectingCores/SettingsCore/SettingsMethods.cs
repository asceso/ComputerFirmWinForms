using System;
using System.IO;
using CoreClient.InjectingCores.SettingsCore.Models;
using Newtonsoft.Json;

namespace CoreClient.InjectingCores.SettingsCore
{
    public class SettingsMethods : ISettingsInject
    {
        private readonly string JsonPath = Environment.CurrentDirectory + "\\AppSettings.json";
        private readonly SettingsModel settings;

        //ctor
        public SettingsMethods() => settings = ReadConfig();

        //short methods
        public string GetConnectionString() => settings.ConnectionString.GetConnectionString();
        public string GetServiceName() => settings.ServiceAddress;

        //get set conf
        public SettingsModel ReadConfig()
        {
            string buffer = string.Empty;
            using (StreamReader reader = new StreamReader(JsonPath))
            {
                buffer = reader.ReadToEnd();
            }
            if (buffer.Equals(string.Empty))
            {
                return new SettingsModel();
            }

            SettingsModel settings = JsonConvert.DeserializeObject<SettingsModel>(buffer);
            return settings;
        }
        public bool SetConfig(SettingsModel settings)
        {
            try
            {
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                using StreamWriter writer = new StreamWriter(JsonPath);
                writer.Write(json);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
