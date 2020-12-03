using CoreClient.InjectingCores.SettingsCore.Models;

namespace CoreClient.InjectingCores.SettingsCore
{
    public interface ISettingsInject
    {
        string GetConnectionString();
        string GetServiceName();
        SettingsModel ReadConfig();
        bool SetConfig(SettingsModel model);
    }
}
