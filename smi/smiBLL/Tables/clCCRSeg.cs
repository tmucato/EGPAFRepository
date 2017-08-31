using smiDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL
{
    public class clCCRSeg : clTableBase<clCCRSeg>
    {
        public int id;
        public int idchild;
        public Nullable<bool> lostfollowup;
        public Nullable<bool> death;
        public Nullable<bool> ce2;
        public string defresult;
        public Nullable<bool> ccs;
        public Nullable<bool> ci;
        public string ot_us;
        public Nullable<bool> lostfollowup2;
        public Nullable<bool> death_2;
        public Nullable<bool> ce3;
        public string resultadofinal;
        public string saidaccr;
        public Nullable<bool> death_3;


        public clCCRSeg()
        {
            id = 0;
            idchild = 0;
            lostfollowup = null;
            death = null;
            ce2 = null;
            defresult = string.Empty;
            ccs = null;
            ci = null;
            ot_us = string.Empty;
            lostfollowup2 = null;
            death_2 = null;
            ce3 = null;
            resultadofinal = string.Empty;
            saidaccr = string.Empty;
            death_3 = null;
        }

        public override List<clCCRSeg> GetEntityList()
        {
            List<clCCRSeg> List_ccrseg = new List<clCCRSeg>();

            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    foreach (ccrseg db_ccrseg in DbContext.ccrsegs)
                    {
                        clCCRSeg obj_ccrseg = new clCCRSeg();
                        obj_ccrseg.id = db_ccrseg.id;
                        obj_ccrseg.idchild = db_ccrseg.idchild;
                        obj_ccrseg.lostfollowup = db_ccrseg.lostfollowup;
                        obj_ccrseg.death = db_ccrseg.death;
                        obj_ccrseg.ce2 = db_ccrseg.ce2;
                        obj_ccrseg.defresult = db_ccrseg.defresult;
                        obj_ccrseg.ccs = db_ccrseg.ccs;
                        obj_ccrseg.ci = db_ccrseg.ci;
                        obj_ccrseg.ot_us = db_ccrseg.ot_us;
                        obj_ccrseg.lostfollowup2 = db_ccrseg.lostfollowup2;
                        obj_ccrseg.death_2 = db_ccrseg.death_2;
                        obj_ccrseg.ce3 = db_ccrseg.ce3;
                        obj_ccrseg.resultadofinal = db_ccrseg.resultadofinal;
                        obj_ccrseg.saidaccr = db_ccrseg.saidaccr;
                        obj_ccrseg.death_3 = db_ccrseg.death_3;
                        List_ccrseg.Add(obj_ccrseg);
                    }

                }



            }
            catch (Exception ex)
            {
                throw ex;
            }

            return List_ccrseg;


        }

        public override DataTable GetEntityDatatable()
        {
            throw new NotImplementedException();
        }



        public override void InsertEntity()
        {

            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    ccrseg db_ccrseg = new ccrseg();

                    db_ccrseg.id = this.id;
                    db_ccrseg.idchild = this.idchild;
                    db_ccrseg.lostfollowup = this.lostfollowup;
                    db_ccrseg.death = this.death;
                    db_ccrseg.ce2 = this.ce2;
                    db_ccrseg.defresult = this.defresult;
                    db_ccrseg.ccs = this.ccs;
                    db_ccrseg.ci = this.ci;
                    db_ccrseg.ot_us = this.ot_us;
                    db_ccrseg.lostfollowup2 = this.lostfollowup2;
                    db_ccrseg.death_2 = this.death_2;
                    db_ccrseg.ce3 = this.ce3;
                    db_ccrseg.resultadofinal = this.resultadofinal;
                    db_ccrseg.saidaccr = this.saidaccr;
                    db_ccrseg.death_3 = this.death_3;
                    DbContext.ccrsegs.Add(db_ccrseg);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public override void UpdateEntity()
        {
            throw new NotImplementedException();
        }

        public override void DeleteEntity()
        {
            throw new NotImplementedException();
        }
    }
}
