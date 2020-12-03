using System.Data.Entity.Migrations;

namespace EFCore.Migrations
{
    public partial class DeleteKeyGenerated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PositionPermissions", "Permission_ID", "dbo.Permissions");
            DropForeignKey("dbo.PositionPermissions", "Position_ID", "dbo.Positions");
            DropForeignKey("dbo.Users", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.Users", "UserInfoID", "dbo.UserInfos");
            DropPrimaryKey("dbo.Permissions");
            DropPrimaryKey("dbo.PositionPermissions");
            DropPrimaryKey("dbo.Positions");
            DropPrimaryKey("dbo.UserInfos");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Permissions", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.PositionPermissions", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Positions", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.UserInfos", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Users", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Permissions", "ID");
            AddPrimaryKey("dbo.PositionPermissions", "ID");
            AddPrimaryKey("dbo.Positions", "ID");
            AddPrimaryKey("dbo.UserInfos", "ID");
            AddPrimaryKey("dbo.Users", "ID");
            AddForeignKey("dbo.PositionPermissions", "Permission_ID", "dbo.Permissions", "ID");
            AddForeignKey("dbo.PositionPermissions", "Position_ID", "dbo.Positions", "ID");
            AddForeignKey("dbo.Users", "PositionID", "dbo.Positions", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Users", "UserInfoID", "dbo.UserInfos", "ID");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserInfoID", "dbo.UserInfos");
            DropForeignKey("dbo.Users", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.PositionPermissions", "Position_ID", "dbo.Positions");
            DropForeignKey("dbo.PositionPermissions", "Permission_ID", "dbo.Permissions");
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.UserInfos");
            DropPrimaryKey("dbo.Positions");
            DropPrimaryKey("dbo.PositionPermissions");
            DropPrimaryKey("dbo.Permissions");
            AlterColumn("dbo.Users", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.UserInfos", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Positions", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.PositionPermissions", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Permissions", "ID", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "ID");
            AddPrimaryKey("dbo.UserInfos", "ID");
            AddPrimaryKey("dbo.Positions", "ID");
            AddPrimaryKey("dbo.PositionPermissions", "ID");
            AddPrimaryKey("dbo.Permissions", "ID");
            AddForeignKey("dbo.Users", "UserInfoID", "dbo.UserInfos", "ID");
            AddForeignKey("dbo.Users", "PositionID", "dbo.Positions", "ID", cascadeDelete: true);
            AddForeignKey("dbo.PositionPermissions", "Position_ID", "dbo.Positions", "ID");
            AddForeignKey("dbo.PositionPermissions", "Permission_ID", "dbo.Permissions", "ID");
        }
    }
}
