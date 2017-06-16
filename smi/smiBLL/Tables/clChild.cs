using MySql.Data.MySqlClient;
using smiDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL
{
    public class clChild : clTableBase<clChild>
    {

        public int id;
        public string nid_ccr;
        public string name;
        public string residence;
        public string gender;
        public string phone;
        public string mot_nid_cpn;
        public DateTime dob;


        public clChild()
        {
            id = 0;
            nid_ccr = string.Empty;
            name = string.Empty;
            residence = string.Empty;
            gender = string.Empty;
            phone = string.Empty;
            mot_nid_cpn = string.Empty;
            dob = new DateTime(1800, 1, 1);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override List<clChild> GetEntityList()
        {
            List<clChild> List_child = new List<clChild>();

            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    foreach (child chil in DbContext.children)
                    {
                        clChild obj_child = new clChild();
                        obj_child.id = chil.id;
                        obj_child.nid_ccr = chil.nid_ccr;
                        obj_child.name = chil.name;
                        obj_child.residence = chil.residence;
                        obj_child.gender = chil.gender;
                        obj_child.phone = chil.phone;
                        obj_child.mot_nid_cpn = chil.mot_nid_cpn;
                        if (chil.dob != null)
                            obj_child.dob = DateTime.Parse(chil.dob.ToString());
                        List_child.Add(obj_child);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of childrens from database", ex);
                throw;
            }
            return List_child;
        }





        public override void InsertEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    child db_child = new child();
                    db_child.id = this.id;
                    db_child.mot_nid_cpn = this.mot_nid_cpn;
                    db_child.name = this.name;
                    db_child.nid_ccr = this.nid_ccr;
                    db_child.phone = this.phone;
                    db_child.residence = this.residence;
                    db_child.gender = this.gender;
                    db_child.dob = this.dob;
                    DbContext.children.Add(db_child);
                    DbContext.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                Logger.LogError("Error inserting child on database", ex);
                throw ex;
            }

        }
        public override void UpdateEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    child db_child = DbContext.children.Where(c => c.id == this.id).FirstOrDefault();
                    db_child.mot_nid_cpn = this.mot_nid_cpn;
                    db_child.name = this.name;
                    db_child.nid_ccr = this.nid_ccr;
                    db_child.phone = this.phone;
                    db_child.residence = this.residence;
                    db_child.gender = this.gender;
                    db_child.dob = this.dob;
                    DbContext.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error updating child " + this.id + " on database", ex);
                throw ex;
            }

        }

        public override void DeleteEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    child db_child = DbContext.children.Where(m => m.id == this.id).FirstOrDefault();
                    DbContext.children.Remove(db_child);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error deliting child " + this.id + " on database", ex);
                throw ex;
            }
        }

        public override DataTable GetEntityDatatable()
        {
            DataTable rsdt = new DataTable();
            try
            {
                using (MySqlConnection cn = Connection.GetSMIDataBaseConnection())
                {
                    cn.Open();
                    string Query = "select * from child;";
                    MySqlCommand myCmd = new MySqlCommand(Query, cn);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = myCmd;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(rsdt);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting child datatable from database", ex);
                throw ex;
            }

            return rsdt;
        }
    }
}
