using System;
using System.Collections.Generic;

namespace InjectingCoreLibrary.SettingsCore.Models
{
    public class SettingsModel : ICloneable
    {
        #region connection
        [Obsolete("Строка подключения убрана в настройки сервера")]
        public ConnectionStringModel ConnectionString { get; set; }
        #endregion connection
        #region server conf
        public string ServiceAddress { get; set; }
        #endregion
        #region app config
        public Dictionary<Guid, List<Guid>> PositionToRequestTypeListDictionary { get; set; }
        #endregion
        public object Clone() => MemberwiseClone();
    }
}
