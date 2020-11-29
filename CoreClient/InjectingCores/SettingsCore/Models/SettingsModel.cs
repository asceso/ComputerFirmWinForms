using System;

namespace CoreClient.InjectingCores.SettingsCore.Models
{
    public class SettingsModel : ICloneable
    {
        #region connection
        public ConnectionStringModel ConnectionString { get; set; }
        #endregion connection

        public object Clone() => MemberwiseClone();
    }
}
