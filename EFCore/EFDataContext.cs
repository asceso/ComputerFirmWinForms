using System.Data.Entity;
using EFCore.Entities;

namespace EFCore
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(string connectionString) : base(connectionString)
        { }
        public EFDataContext() : base("ComputerFirmDataContext")
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PositionPermission> PositionPermissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .HasOptional(u => u.UserInfo)
            //    .WithOptionalDependent(k => k.User)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<User>()
            //    .HasRequired(u => u.Position)
            //    .WithRequiredPrincipal(p => p.User)
            //    .WillCascadeOnDelete(false);

            //base.OnModelCreating(modelBuilder);
        }
    }
}
