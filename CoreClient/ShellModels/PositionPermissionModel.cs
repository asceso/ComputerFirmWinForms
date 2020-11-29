using System;

namespace CoreClient.ShellModels
{
    public class PositionPermissionModel
    {
        public Guid ID { get; set; }
        public PositionModel Position { get; set; }
        public PermissionModel Permission { get; set; }
    }
}
