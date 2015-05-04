using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
using DataBaseLaeyr.DataLayreEntity.Interface;
using DataBaseLaeyr.Repository.Repositorys;


namespace DataBaseLaeyr
{
    class Program
    {
        static void Main(string[] args)
        {
            string dp = ConfigurationManager.AppSettings["provider"];
            string conStr = ConfigurationManager.AppSettings["cnStr"];

           DbProviderFactory df = DbProviderFactories.GetFactory(dp);
            
            using(SqlConnection cn = new SqlConnection())
            {
                Console.WriteLine("Object of connection:   "+cn.GetType().Name);
                cn.ConnectionString = conStr;

                try
                {
                    cn.Open();


                    DbCommand cmd = df.CreateCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO dbo.UserRole (RoleName) VALUES ('User')";
                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine("Inserted {0} rows", rows);
                }
                catch(DbException exDb) 
                {
                    Console.WriteLine("DbException.GetType: {0}", exDb.GetType());
                    Console.WriteLine("DbException.Source: {0}", exDb.Source);
                    Console.WriteLine("DbException.ErrorCode: {0}", exDb.ErrorCode);
                    Console.WriteLine("DbException.Message: {0}", exDb.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception.Message: {0}", ex.Message);
                }
          
            }








            UserRepository repository = new UserRepository();

            var users = repository.GetAll();

            foreach (IUser user in users)
            {
                Console.WriteLine("User name:" + user.UserName);
                Console.WriteLine("User email:" + user.Email);
            }


        }
    }
}
