using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiDAL
{
    public class Connection
    {
        public static MySqlConnection GetSMIDataBaseConnection()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=sapassword;database=smi;Persist Security Info=True");
            return con;
        }
    }
}
