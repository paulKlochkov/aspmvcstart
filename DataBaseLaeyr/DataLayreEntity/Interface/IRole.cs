using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLaeyr.DataLayreEntity.Interface
{
    interface IRole:IEntity
    {
        string RoleName { get; set; }
    }
}
