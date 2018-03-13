using System.Linq;
using mLizard.EntityFramework;
using mLizard.MultiTenancy;

namespace mLizard.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly mLizardDbContext _context;

        public DefaultTenantCreator(mLizardDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
