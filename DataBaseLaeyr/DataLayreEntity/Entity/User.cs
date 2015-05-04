using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.DataLayreEntity.Interface;

namespace DataBaseLaeyr.DataLayreEntity.Entity
{
    class User:IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
    }
}
