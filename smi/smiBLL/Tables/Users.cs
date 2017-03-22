using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
          

            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of users ", ex);
                throw;
            }

            return List_Users;

        }



    }
}
