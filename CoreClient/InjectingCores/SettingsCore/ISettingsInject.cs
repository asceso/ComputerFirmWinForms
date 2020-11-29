using CoreClient.InjectingCores.SettingsCore.Models;

namespace CoreClient.InjectingCores.SettingsCore
{
    public interface ISettingsInject
    {
        string GetConnectionString();
        SettingsModel ReadConfig();
        bool SetConfig(SettingsModel model);
    }
}
