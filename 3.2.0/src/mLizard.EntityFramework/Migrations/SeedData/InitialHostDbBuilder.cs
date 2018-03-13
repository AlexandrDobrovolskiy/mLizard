using mLizard.EntityFramework;
using EntityFramework.DynamicFilters;

namespace mLizard.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly mLizardDbContext _context;

        public InitialHostDbBuilder(mLizardDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
