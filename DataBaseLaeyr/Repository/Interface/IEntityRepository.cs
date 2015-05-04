using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.DataLayreEntity.Interface;

namespace DataBaseLaeyr.Repository.Interfeic
{
    interface IEntityRepository<TEntity> where TEntity:IEntity
    {
        TEntity Create(TEntity enytity);
        void Delete(TEntity entity);
        TEntity Update(int id, TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
    }
}
