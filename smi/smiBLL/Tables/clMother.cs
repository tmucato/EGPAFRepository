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
            dob = new DateTime(1800, 1, 1);
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
                using (DBsmiEntities DbContext = new DBsmiEntities(DBConnection.GetEFSMIDataBaseConStr()))
                {
                    foreach (mother db_moth in DbContext.mothers)
                    {
                        clMother clMoth = new clMother();
                        clMoth.id = db_moth.id;
                        clMoth.nid_cpn = db_moth.nid_cpn;
                        clMoth.nid_tarv = db_moth.nid_tarv;
                        clMoth.name = db_moth.name;
                        clMoth.phone = db_moth.phone;
                        clMoth.residence = db_moth.residence;
                        if (db_moth.dob != null)
                            clMoth.dob = DateTime.Parse(db_moth.dob.ToString());
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


             /// <summary>
        /// Insert mother entity on the database
        /// </summary>
        public override void InsertEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(DBConnection.GetEFSMIDataBaseConStr()))
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
                using (DBsmiEntities DbContext = new DBsmiEntities(DBConnection.GetEFSMIDataBaseConStr()))
                {
                    mother db_mother = DbContext.mothers.Where(m => m.id == this.id).FirstOrDefault();
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
                using (DBsmiEntities DbContext = new DBsmiEntities(DBConnection.GetEFSMIDataBaseConStr()))
                {
                    mother db_mother = DbContext.mothers.Where(m => m.id == this.id).FirstOrDefault();
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

        public override DataTable GetEntityDatatable()
        {
            DataTable rsdt = new DataTable();
            try
            {
                using (MySqlConnection cn = smiDAL.DBConnection.GetSMIDataBaseConnection())
                {
                    cn.Open();
                    string Query = "select * from mother;";
                    MySqlCommand myCmd = new MySqlCommand(Query, cn);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = myCmd;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(rsdt);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting mother datatable from database", ex);
                throw ex;
            }
            return rsdt;
        }
    }
}


