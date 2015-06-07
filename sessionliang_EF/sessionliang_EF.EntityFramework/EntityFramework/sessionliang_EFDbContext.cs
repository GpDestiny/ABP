using Abp.EntityFramework;

namespace sessionliang_EF.EntityFramework
{
    public class sessionliang_EFDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public sessionliang_EFDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in sessionliang_EFDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of sessionliang_EFDbContext since ABP automatically handles it.
         */
        public sessionliang_EFDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
