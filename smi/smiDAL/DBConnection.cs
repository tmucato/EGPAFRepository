﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiDAL
{
    public class DBConnection
    {
        public static SqlConnection GetSMIDataBaseConnection()
        {
            List<string> dbconfig = GetDBConfigFromFile();
            string conStr = "server = " + dbconfig[0] + "; User Id =" + dbconfig[1] + "; password = " + dbconfig[2] + "; database =" + dbconfig[3] + "; Persist Security Info = True";
            SqlConnection con = new SqlConnection(conStr);

            return con;
        }

        public static string GetSMIDataBaseConStr()
        {
            List<string> dbconfig = GetDBConfigFromFile();
            string conStr = "server = " + dbconfig[0] + "; User Id =" + dbconfig[1] + "; password = " + dbconfig[2] + "; database =" + dbconfig[3] + "; Persist Security Info = True";
            return conStr;
        }

        public static string GetEFSMIDataBaseConStr()
        {
            List<string> dbconfig = GetDBConfigFromFile();
           // string conStr = "metadata=res://*/DBsmi.csdl|res://*/DBsmi.ssdl|res://*/DBsmi.msl;provider=MySql.Data.MySqlClient;provider connection string=';server=" + dbconfig[0] + ";user id=" + dbconfig[1] + ";password=" + dbconfig[2] + ";database=" + dbconfig[3] + "';";
            string conStr = "metadata=res://*/DBsmi.csdl|res://*/DBsmi.ssdl|res://*/DBsmi.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + dbconfig[0] + ";initial catalog=" + dbconfig[3] + ";persist security info=True;user id=" + dbconfig[1] + ";password=" + dbconfig[2] + ";MultipleActiveResultSets=True;App=EntityFramework';";
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
                throw ex;
            }

            return configList;

        }

    }
}
