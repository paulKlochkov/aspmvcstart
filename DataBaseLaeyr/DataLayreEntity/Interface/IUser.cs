using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLaeyr.DataLayreEntity.Interface
{
    public interface IUser:IEntity
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        int RoleId { get; set; }
    }
}
