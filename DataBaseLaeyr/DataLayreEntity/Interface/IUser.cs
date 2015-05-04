using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLaeyr.DataLayreEntity.Interface
{
    interface IUser:IEntity
    {
        string UserName { get; set; }
        string Password { get; set; }
        int RoleId { get; set; }
    }
}
