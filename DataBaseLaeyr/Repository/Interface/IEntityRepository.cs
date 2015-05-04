using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.DataLayreEntity.Interface;

namespace DataBaseLaeyr.Repository.Interfeic
{
    interface IEntityRepository
    {
        IEntity Create(IEntity enytity);
        void Delete(IEntity entity);
        IEntity Update(int id, IEntity entity);
        IEntity Update(IEntity entity);
        IEntity Get(int id);
        IEnumerable<IEntity> GetAll();
    }
}
