using smiBLL;
using smiBLL.Tables;
using smiDAL;
using System;
using System.Collections.Generic;

namespace smiBLL
{
    public class clUsers : clTableBase<clUsers>
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

        public override List<clUsers> GetEntityList()
        {
            List<clUsers> List_Users = new List<clUsers>();

            try
            {
                DBsmiEntities DbContext = new DBsmiEntities();
                List<usuario> List_usuario = 

            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of users ", ex);
                throw;
            }

            return List_Users;
        }

        public override void InsertEntity(clUsers Entity)
        {
            throw new NotImplementedException();
        }

        public override void UpdateEntity(clUsers Entity)
        {
            throw new NotImplementedException();
        }
    }
}
