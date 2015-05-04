using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLaeyr.DataLayreEntity.Interface;
using DataBaseLaeyr.DataLayreEntity.Entity;
using System.Data.SqlClient;
using System.Data.Common;

namespace DataBaseLaeyr.Repository
{
     public static class  SqlDataReaderExtention
    {
         public static IUser UserAdapting(this SqlDataReader reader)
         {
             return new User{
             

             };
         }
    }
}
