using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.Connection;
using DataBaseLaeyr.Repository.Interfeic;
using DataBaseLaeyr.DataLayreEntity.Entity;
using DataBaseLaeyr.DataLayreEntity.Interface;
using System.Data.SqlClient;
using System.Data.Common;


namespace DataBaseLaeyr.Repository.Repositorys
{
    class UserRepository:IUserRepository
    {

        #region SQL COMMANDS
        private const string SelectAllQuery = @"select * from Users";
        private const string SelectByIdQuery = @"select * from Users where UserId = @UserId";
        private const string InsertQuery = @"insert into Users (UserName,Email,Password,RoleId) values(@eserName,@email,@password,@roleId)";
        private const string DeleteQuery = @"delete from Users where Users.UserId = @UserId";
        private const string FindQuery = @"SELECT TOP 1 * FROM Users
                                                    where [UserId] = @UserId";
        private const string UpdateQuery = @"UPDATE [dbo].[Users]
                                            SET [FirstName] = @firstName
                                            ,[SecondName] = @secondName
                                            ,[LastName] = @lastName
                                             WHERE [PersonId] = @personId";
        #endregion


        private SqlConnection _connection = new ExpenceSqlDataConnectorFactory().OpenNewConnection();

        public IEnumerable<IRole> GetUserRole(IUser user)
        {
            throw new NotImplementedException();
        }

        public IUser Create(IUser enytity)
        {
            IUser user = new User();
            using (_connection = new ExpenceSqlDataConnectorFactory().OpenNewConnection())
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = SelectAllQuery;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                  
                }
            }
            return user;
        }

        public void Delete(IUser enytity)
        {
            throw new NotImplementedException();
        }

        public IUser Update(int id, IUser enytity)
        {
            throw new NotImplementedException();
        }

        public IUser Update(IUser enytity)
        {
            throw new NotImplementedException();
        }

        public IUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetAll()
        {
            List<IUser> users = new List<IUser>();
            using (_connection = new ExpenceSqlDataConnectorFactory().OpenNewConnection())
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = SelectAllQuery;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IUser user = reader.UserAdapting();
                        users.Add(user);
                    }
                }
            }
            return users;
        }
    }
}
