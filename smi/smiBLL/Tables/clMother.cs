using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smiDAL;
using System.Data;
using MySql.Data.MySqlClient;

namespace smiBLL
{
    public class clMother : clTableBase<clMother>
    {

        public int id;
        public string nid_cpn;
        public string nid_tarv;
        public string name;
        public string phone;
        public string residence;
        public DateTime dob;

        public clMother()
        {
            id = 0;
            nid_cpn = string.Empty;
            nid_tarv = string.Empty;
            name = string.Empty;
            phone = string.Empty;
            residence = string.Empty;
            dob = DateTime.MinValue;
        }


        /// <summary>
        /// Get from the database a list of mother
        /// </summary>
        /// <returns>List of mother class</returns>
        public override List<clMother> GetEntityList()
        {
            List<clMother> List_mother = new List<clMother>();

            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    foreach (mother moth in DbContext.mothers)
                    {
                        clMother clMoth = new clMother();
                        clMoth.id = moth.id;
                        clMoth.nid_cpn = moth.nid_cpn;
                        clMoth.nid_tarv = moth.nid_tarv;
                        clMoth.name = moth.name;
                        clMoth.phone = moth.phone;
                        clMoth.residence = moth.residence;
                        if (moth.dob != null)
                            clMoth.dob = DateTime.Parse(moth.dob.ToString());
                        List_mother.Add(clMoth);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of mothers from database", ex);
                throw;
            }
            return List_mother;
        }


        public DataTable getMotherDataTable()
        {
            DataTable rsdt = new DataTable();

            MySqlConnection cn = Connection.GetSMIDataBaseConnection();
            cn.Open();
            string Query = "select * from mother;";
            MySqlCommand myCmd = new MySqlCommand(Query, cn);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = myCmd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(rsdt);

            return rsdt;
        }

        /// <summary>
        /// Insert mother entity on the database
        /// </summary>
        public override void InsertEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    mother db_mother = new mother();
                    db_mother.id = this.id;
                    db_mother.nid_cpn = this.nid_cpn;
                    db_mother.nid_tarv = this.nid_tarv;
                    db_mother.name = this.name;
                    db_mother.phone = this.phone;
                    db_mother.residence = this.residence;
                    db_mother.dob = this.dob;
                    DbContext.mothers.Add(db_mother);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Logger.LogError("Error inserting Mother on database", ex);
                throw ex;
            }

        }

        /// <summary>
        /// Update entity mother on the database
        /// </summary>
        public override void UpdateEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    mother db_mother;
                    db_mother = DbContext.mothers.Where(m => m.id == this.id).FirstOrDefault();
                    db_mother.nid_cpn = this.nid_cpn;
                    db_mother.nid_tarv = this.nid_tarv;
                    db_mother.name = this.name;
                    db_mother.phone = this.phone;
                    db_mother.residence = this.residence;
                    db_mother.dob = this.dob;
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error updating Mother " + this.id + " on database", ex);
                throw ex;
            }

        }

        /// <summary>
        /// Delete entity mother on the database 
        /// </summary>
        public override void DeleteEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    mother db_mother;
                    db_mother = DbContext.mothers.Where(m => m.id == this.id).FirstOrDefault();
                    DbContext.mothers.Remove(db_mother);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error deliting Mother " + this.id + " on database", ex);
                throw ex;
            }
        }
    }
}


