namespace EFCore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permissions",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.PositionPermissions",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true),
                    Permission_ID = c.Guid(),
                    Position_ID = c.Guid(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Permissions", t => t.Permission_ID)
                .ForeignKey("dbo.Positions", t => t.Position_ID)
                .Index(t => t.Permission_ID)
                .Index(t => t.Position_ID);

            CreateTable(
                "dbo.Positions",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.UserInfos",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true),
                    FirstName = c.String(),
                    SecondName = c.String(),
                    LastName = c.String(),
                    ContactNumber = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true),
                    Login = c.String(nullable: false),
                    Password = c.String(nullable: false),
                    UserInfoID = c.Guid(),
                    PositionID = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Positions", t => t.PositionID, cascadeDelete: true)
                .ForeignKey("dbo.UserInfos", t => t.UserInfoID)
                .Index(t => t.UserInfoID)
                .Index(t => t.PositionID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserInfoID", "dbo.UserInfos");
            DropForeignKey("dbo.Users", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.PositionPermissions", "Position_ID", "dbo.Positions");
            DropForeignKey("dbo.PositionPermissions", "Permission_ID", "dbo.Permissions");
            DropIndex("dbo.Users", new[] { "PositionID" });
            DropIndex("dbo.Users", new[] { "UserInfoID" });
            DropIndex("dbo.PositionPermissions", new[] { "Position_ID" });
            DropIndex("dbo.PositionPermissions", new[] { "Permission_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.UserInfos");
            DropTable("dbo.Positions");
            DropTable("dbo.PositionPermissions");
            DropTable("dbo.Permissions");
        }
    }
}
