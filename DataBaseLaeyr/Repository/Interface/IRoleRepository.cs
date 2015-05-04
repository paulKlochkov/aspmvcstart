using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.DataLayreEntity.Interface;

namespace DataBaseLaeyr.Repository.Interfeic
{
    interface IRoleRepository:IEntityRepository
    {
        IEnumerable<IRole> GetUserRole(IRole role);  
    }
}
