using System;

namespace CoreClient.InjectingCores.SettingsCore.Models
{
    public class SettingsModel : ICloneable
    {
        #region connection
        public ConnectionStringModel ConnectionString { get; set; }
        #endregion connection
        #region server conf
        public string ServiceAddress { get; set; }
        public string AccessAddress { get; set; }
        #endregion
        public object Clone() => MemberwiseClone();
    }
}
