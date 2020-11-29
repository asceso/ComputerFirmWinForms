using System.Text;
using CoreClient.ControlExtensions;

namespace CoreClient.InjectingCores.SettingsCore.Models
{
    public class ConnectionStringModel
    {
        public string GetConnectionString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"data source={DataSource};");
            sb.Append($"attachdbfilename={AttachDBFileName};");
            sb.Append($"integrated security={IntegratedSecurity.ToPascalString()};");
            sb.Append($"connect timeout={ConnectTimeout};");
            sb.Append($"MultipleActiveResultSets={MultipleActiveResultSets.ToPascalString()};");
            sb.Append($"App={App}");
            return sb.ToString();
        }
        #region props
        public string DataSource { get; set; }
        public string AttachDBFileName { get; set; }
        public bool IntegratedSecurity { get; set; }
        public int ConnectTimeout { get; set; }
        public bool MultipleActiveResultSets { get; set; }
        public string App { get; set; }

        //Не используется
        public string Provider { get; set; }
        #endregion
    }
}
