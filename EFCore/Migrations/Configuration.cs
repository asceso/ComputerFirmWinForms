using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EFCore.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFCore.EFDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCore.EFDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
