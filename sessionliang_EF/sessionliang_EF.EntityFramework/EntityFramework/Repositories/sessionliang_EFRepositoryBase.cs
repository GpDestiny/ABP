using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace sessionliang_EF.EntityFramework.Repositories
{
    public abstract class sessionliang_EFRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<sessionliang_EFDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected sessionliang_EFRepositoryBase(IDbContextProvider<sessionliang_EFDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class sessionliang_EFRepositoryBase<TEntity> : sessionliang_EFRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected sessionliang_EFRepositoryBase(IDbContextProvider<sessionliang_EFDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
