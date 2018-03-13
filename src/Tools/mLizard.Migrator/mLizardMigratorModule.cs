using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using mLizard.EntityFramework;

namespace mLizard.Migrator
{
    [DependsOn(typeof(mLizardDataModule))]
    public class mLizardMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<mLizardDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}