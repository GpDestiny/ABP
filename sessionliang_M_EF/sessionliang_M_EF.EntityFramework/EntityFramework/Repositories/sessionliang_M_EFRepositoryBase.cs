using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace sessionliang_M_EF.EntityFramework.Repositories
{
    public abstract class sessionliang_M_EFRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<sessionliang_M_EFDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected sessionliang_M_EFRepositoryBase(IDbContextProvider<sessionliang_M_EFDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class sessionliang_M_EFRepositoryBase<TEntity> : sessionliang_M_EFRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected sessionliang_M_EFRepositoryBase(IDbContextProvider<sessionliang_M_EFDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
