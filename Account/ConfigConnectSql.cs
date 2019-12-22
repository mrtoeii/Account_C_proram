using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Account
{
    public class ConfigConnectSql
    {

        
        public static string ConnectString()
        {
            string connectString = "datasource=127.0.0.1;port=3306;username=root;password=;database=account;";
            return connectString;
        }
        
    }
}
