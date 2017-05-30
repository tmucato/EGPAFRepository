using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiDAL
{
    public class Connection
    {
        public static MySqlConnection GetSMIDataBaseConnection()
        {
            List<string> dbconfig = GetDBConfigFromFile();
            string conStr = "server = " + dbconfig[0] + "; User Id =" + dbconfig[1] + "; password = " + dbconfig[2] + "; database =" + dbconfig[3] + "; Persist Security Info = True";
            MySqlConnection con = new MySqlConnection(conStr);

            return con;
        }

        public static string GetSMIDataBaseConStr()
        {
            List<string> dbconfig = GetDBConfigFromFile();
            string conStr = "server = " + dbconfig[0] + "; User Id =" + dbconfig[1] + "; password = " + dbconfig[2] + "; database =" + dbconfig[3] + "; Persist Security Info = True";
            return conStr;
        }


        private static List<string> GetDBConfigFromFile()
        {
            List<string> configList = new List<string>();

            try
            {
                string configLine;
                using (StreamReader sr = new StreamReader("..\\smiDAL\\DbConnect.config"))
                {
                    while ((configLine = sr.ReadLine()) != null)
                    {
                        configList.Add(configLine.Split('|')[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return configList;

        }

    }
}
