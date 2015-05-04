using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.DataLayreEntity.Interface;

namespace DataBaseLaeyr.Repository.Interfeic
{
    interface IUserRepository : IEntityRepository<IUser>
    {
        IEnumerable<IRole> GetUserRole(IUser user);

    }
}
