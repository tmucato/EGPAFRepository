using smiDAL;
using System;
using System.Collections.Generic;

namespace smiBLL
{
    public class Users
    {
        public int ID;
        public string username;
        public string name;
        public string apelido;
        public string password;
        public string posicao;
        public string systemrole;

        public Users()
        {
            ID = 0;
            username = string.Empty;
            name = string.Empty;
            apelido = string.Empty;
            password = string.Empty;
            posicao = string.Empty;
            systemrole = string.Empty;
        }

        public List<Users> GetEntity()
        {
            List<Users> List_Users = new List<Users>();

            try
            {
                //DBsmiContainer DBContext = new DBsmiContainer(Connection.GetMIDataBaseConStr());

                //foreach (usuario usr in DBContext.usuario)
                //{

                //}
                //{

                //}


            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of users ", ex);
                throw;

            }
            finally
            {
               
            }

            return List_Users;

        }



    }
}
