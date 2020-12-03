using InjectingCoreLibrary.SettingsCore.Models;

namespace InjectingCoreLibrary.SettingsCore
{
    public interface ISettingsInject
    {
        string GetConnectionString();
        string GetServiceName();
        SettingsModel ReadConfig();
        bool SetConfig(SettingsModel model);
    }
}
