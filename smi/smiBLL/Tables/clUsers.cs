using System;
using System.Collections.Generic;
using smiDAL;


namespace smiBLL
{
    public class clUsers : clTableBase<clUsers>
    {
        public long ID;
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
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    foreach (usuario user in DbContext.usuarios)
                    {
                        clUsers clUsr = new clUsers();
                        clUsr.ID = user.id;
                        clUsr.username = user.username;
                        clUsr.name = user.name;
                        clUsr.apelido = user.apelido;
                        clUsr.password = user.password;
                        clUsr.posicao = user.posicao;
                        clUsr.systemrole = user.systemrole;
                        List_Users.Add(clUsr);
                    }
                }

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

        public override void DeleteEntity(clUsers Entity)
        {
            throw new NotImplementedException();
        }

    }
}
