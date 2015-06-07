namespace sessionliang_M_EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<sessionliang_M_EF.EntityFramework.sessionliang_M_EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "sessionliang_M_EF";
        }

        protected override void Seed(sessionliang_M_EF.EntityFramework.sessionliang_M_EFDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
