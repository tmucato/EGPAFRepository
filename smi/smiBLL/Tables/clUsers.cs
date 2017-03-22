using smiBLL.Tables;
using smiDAL;
using System;
using System.Collections.Generic;

namespace smiBLL
{
    public class clUsers : clTableBase
    {
        public int ID;
        public string username;
        public string name;
        public string apelido;
        public string password;
        public string posicao;
        public string systemrole;

        public clUsers()
        {
            ID = 0;
            username = string.Empty;
            name = string.Empty;
            apelido = string.Empty;
            password = string.Empty;
            posicao = string.Empty;
            systemrole = string.Empty;
        }

        public List<clUsers> GetEntity()
        {
            List<clUsers> List_Users = new List<clUsers>();

            try
            {
               
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
