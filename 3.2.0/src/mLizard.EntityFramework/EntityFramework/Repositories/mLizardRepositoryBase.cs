using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace mLizard.EntityFramework.Repositories
{
    public abstract class mLizardRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<mLizardDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected mLizardRepositoryBase(IDbContextProvider<mLizardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class mLizardRepositoryBase<TEntity> : mLizardRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected mLizardRepositoryBase(IDbContextProvider<mLizardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
