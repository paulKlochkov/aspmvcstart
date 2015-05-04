using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.DataLayreEntity.Interface;

namespace DataBaseLaeyr.DataLayreEntity.Entity
{
    class Role:IRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
