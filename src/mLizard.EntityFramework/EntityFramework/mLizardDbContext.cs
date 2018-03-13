using System.Data.Common;
using Abp.Zero.EntityFramework;
using mLizard.Authorization.Roles;
using mLizard.Authorization.Users;
using mLizard.MultiTenancy;

namespace mLizard.EntityFramework
{
    public class mLizardDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public mLizardDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in mLizardDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of mLizardDbContext since ABP automatically handles it.
         */
        public mLizardDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public mLizardDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public mLizardDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
