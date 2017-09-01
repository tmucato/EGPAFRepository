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
        public string mothTarv5moth;
        public Nullable<bool> ame5m;
        public Nullable<bool> am5m;
        public Nullable<bool> recuperada;
        public Nullable<bool> transinter;
        public Nullable<bool> arv5m;
        public Nullable<bool> pcrmen2m;
        public Nullable<bool> pcrmai2m;
        public Nullable<bool> pcrposmen2m;
        public Nullable<bool> pcrposmai2m;
        public Nullable<bool> tb;
        public Nullable<bool> dam;
        public Nullable<bool> dag;
        public Nullable<bool> ce9m;
        public Nullable<bool> pnctl;
        public Nullable<bool> tpi;
        public Nullable<bool> abandono9;
        public Nullable<bool> obito9;
        public Nullable<bool> ce18m;
        public Nullable<bool> resultado18;
        public Nullable<bool> transferidaCCS;
        public Nullable<bool> transferidaCI;
        public Nullable<bool> transferidaUS;
        public Nullable<bool> abandono18;
        public Nullable<bool> obito18;

        public clCCRSeg()
        {
            id = 0;
            idchild = 0;
            mothTarv5moth = string.Empty;
            ame5m = null;
            am5m = null;
            recuperada = null;
            transinter = null;
            arv5m = null;
            pcrmen2m = null;
            pcrmai2m = null;
            pcrposmen2m = null;
            pcrposmai2m = null;
            tb = null;
            dam = null;
            dag = null;
            ce9m = null;
            pnctl = null;
            tpi = null;
            abandono9 = null;
            obito9 = null;
            ce18m = null;
            resultado18 = null;
            transferidaCCS = null;
            transferidaCI = null;
            transferidaUS = null;
            abandono18 = null;
            obito18 = null;



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
