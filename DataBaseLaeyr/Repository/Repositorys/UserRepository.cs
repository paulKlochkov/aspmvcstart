using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.Connection;
using DataBaseLaeyr.Repository.Interfeic;

namespace DataBaseLaeyr.Repository.Repositorys
{
    class UserRepository:IUserRepository
    {




        private ExpenceSqlDataConnector _connection = new ExpenceSqlDataConnector();

        public IEnumerable<DataLayreEntity.Interface.IRole> GetUserRole(DataLayreEntity.Interface.IUser user)
        {
            throw new NotImplementedException();
        }

        public DataLayreEntity.Interface.IEntity Create(DataLayreEntity.Interface.IEntity enytity)
        {
            throw new NotImplementedException();
        }

        public void Delete(DataLayreEntity.Interface.IEntity entity)
        {
            throw new NotImplementedException();
        }

        public DataLayreEntity.Interface.IEntity Update(int id, DataLayreEntity.Interface.IEntity entity)
        {
            throw new NotImplementedException();
        }

        public DataLayreEntity.Interface.IEntity Update(DataLayreEntity.Interface.IEntity entity)
        {
            throw new NotImplementedException();
        }

        public DataLayreEntity.Interface.IEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DataLayreEntity.Interface.IEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
