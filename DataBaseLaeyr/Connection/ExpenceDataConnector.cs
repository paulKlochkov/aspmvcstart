using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;

namespace DataBaseLaeyr.Connection
{
    class ExpenceSqlDataConnector:IDisposable
    {

      public ExpenceSqlDataConnector() : this("") { }

      public ExpenceSqlDataConnector(string dataConectionStr)
        {
            if (!String.IsNullOrEmpty(dataConectionStr)) 
            {
                _dataConectionStr = dataConectionStr;
            }
        }

        public SqlConnection OpenNewConnection()
        {
            if (!string.IsNullOrEmpty(_dataConectionStr))
            {
                try
                {
                    var conection = new SqlConnection(_dataConectionStr);
                    conection.Open();
                    return conection;
                }
                catch (Exception ex)
                {
                    throw ;
                }

            }
            return null;
        }

        private readonly string _dataConectionStr = ConfigurationManager.AppSettings["cnStr"];
    }
}
