namespace sessionliang_EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<sessionliang_EF.EntityFramework.sessionliang_EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "sessionliang_EF";
        }

        protected override void Seed(sessionliang_EF.EntityFramework.sessionliang_EFDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
