using smiDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL.Tables
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



        public override List<clMother> GetEntityList()
        {
            List<clMother> List_mother = new List<clMother>();
            try
            {
                //using (DbsmiContainer DbContext = new DbsmiContainer())
                //{

                //}


            }
            catch (Exception ex)
            {
                throw;
                Logger.LogError("Error getting list of mothers from database", ex);
            }
            return List_mother;
        }

        public override void InsertEntity(clMother Entity)
        {
            throw new NotImplementedException();
        }

        public override void UpdateEntity(clMother Entity)
        {
            throw new NotImplementedException();
        }
    }
}
