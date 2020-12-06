using System;
using InjectingCoreLibrary.SettingsCore.Models;

namespace InjectingCoreLibrary.SettingsCore
{
    public interface ISettingsInject
    {
        [Obsolete("Строка подключения убрана в настройки сервера")]
        string GetConnectionString();
        string GetServiceName();
        SettingsModel ReadConfig();
        bool SetConfig(SettingsModel model);
    }
}
