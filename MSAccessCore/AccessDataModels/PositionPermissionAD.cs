using System;

namespace MSAccessCore.AccessDataModels
{
    public class PositionPermissionAD
    {
        public Guid ID { get; set; }
        public PositionAD Position { get; set; }
        public PermissionAD Permission { get; set; }
    }
}
