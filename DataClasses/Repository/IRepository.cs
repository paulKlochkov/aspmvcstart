using System.Collections.Generic;

namespace Data.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity CreateNew();
        void Save(TEntity entity);
        void Remove(TEntity entity);
        ICollection<TEntity> GetAll();
        void Update(TEntity entity);
    }
}
