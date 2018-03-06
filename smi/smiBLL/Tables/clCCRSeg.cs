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
        public int idccr;
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
            idccr = 0;
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
                using (DBsmiEntities DbContext = new DBsmiEntities(DBConnection.GetEFSMIDataBaseConStr()))
                {
                    foreach (ccrseg db_ccrseg in DbContext.ccrsegs)
                    {
                        clCCRSeg obj_ccrseg = new clCCRSeg();
                        obj_ccrseg.id = db_ccrseg.id;
                        obj_ccrseg.idchild = Convert.ToInt32(db_ccrseg.idchild);
                        obj_ccrseg.idccr = db_ccrseg.idccr;
                        obj_ccrseg.mothTarv5moth = db_ccrseg.mothTarv5moth;
                        obj_ccrseg.ame5m = db_ccrseg.ame5m;
                        obj_ccrseg.am5m = db_ccrseg.am5m;
                        obj_ccrseg.recuperada = db_ccrseg.recuperada;
                        obj_ccrseg.transinter = db_ccrseg.transinter;
                        obj_ccrseg.arv5m = db_ccrseg.arv5m;
                        obj_ccrseg.pcrmen2m = db_ccrseg.pcrmen2m;
                        obj_ccrseg.pcrmai2m = db_ccrseg.pcrmai2m;
                        obj_ccrseg.pcrposmen2m = db_ccrseg.pcrposmen2m;
                        obj_ccrseg.pcrposmai2m = db_ccrseg.pcrposmai2m;
                        obj_ccrseg.tb = db_ccrseg.tb;
                        obj_ccrseg.dam = db_ccrseg.dam;
                        obj_ccrseg.dag = db_ccrseg.dag;
                        obj_ccrseg.ce9m = db_ccrseg.ce9m;
                        obj_ccrseg.pnctl = db_ccrseg.pnctl;
                        obj_ccrseg.tpi = db_ccrseg.tpi;
                        obj_ccrseg.abandono9 = db_ccrseg.abandono9;
                        obj_ccrseg.obito9 = db_ccrseg.obito9;
                        obj_ccrseg.ce18m = ce18m;
                        obj_ccrseg.resultado18 = db_ccrseg.resultado18;
                        obj_ccrseg.transferidaCCS = db_ccrseg.transferidaCCS;
                        obj_ccrseg.transferidaCI = db_ccrseg.transferidaCI;
                        obj_ccrseg.transferidaUS = db_ccrseg.transferidaUS;
                        obj_ccrseg.abandono18 = db_ccrseg.abandono18;
                        obj_ccrseg.obito18 = db_ccrseg.obito9;
                        List_ccrseg.Add(obj_ccrseg);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of ccr segments from database", ex);
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
                using (DBsmiEntities DbContext = new DBsmiEntities(DBConnection.GetEFSMIDataBaseConStr()))
                {
                    ccrseg db_ccrseg = new ccrseg();
                    db_ccrseg.idchild = this.idchild;
                    db_ccrseg.idccr = this.idccr;
                    db_ccrseg.mothTarv5moth = this.mothTarv5moth;
                    db_ccrseg.ame5m = this.ame5m;
                    db_ccrseg.am5m = this.am5m;
                    db_ccrseg.recuperada = this.recuperada;
                    db_ccrseg.transinter = this.transinter;
                    db_ccrseg.arv5m = this.arv5m;
                    db_ccrseg.pcrmen2m = this.pcrmen2m;
                    db_ccrseg.pcrmai2m = this.pcrmai2m;
                    db_ccrseg.pcrposmen2m = this.pcrposmen2m;
                    db_ccrseg.pcrposmai2m = this.pcrposmai2m;
                    db_ccrseg.tb = this.tb;
                    db_ccrseg.dam = this.dam;
                    db_ccrseg.dag = this.dag;
                    db_ccrseg.ce9m = this.ce9m;
                    db_ccrseg.pnctl = this.pnctl;
                    db_ccrseg.tpi = this.tpi;
                    db_ccrseg.abandono9 = this.abandono9;
                    db_ccrseg.obito9 = this.obito9;
                    db_ccrseg.ce18m = ce18m;
                    db_ccrseg.resultado18 = this.resultado18;
                    db_ccrseg.transferidaCCS = this.transferidaCCS;
                    db_ccrseg.transferidaCI = this.transferidaCI;
                    db_ccrseg.transferidaUS = this.transferidaUS;
                    db_ccrseg.abandono18 = this.abandono18;
                    db_ccrseg.obito18 = this.obito9;
                    DbContext.ccrsegs.Add(db_ccrseg);
                    DbContext.SaveChanges();
                    this.id = db_ccrseg.id;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error inserting ccr segment on database", ex);
                throw ex;
            }


        }

        public override void UpdateEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(DBConnection.GetEFSMIDataBaseConStr()))
                {

                    ccrseg db_ccrseg = DbContext.ccrsegs.Where(cs => cs.id == this.id).FirstOrDefault();
                    db_ccrseg.idchild = this.idchild;
                    db_ccrseg.idccr = this.idccr;
                    db_ccrseg.mothTarv5moth = this.mothTarv5moth;
                    db_ccrseg.ame5m = this.ame5m;
                    db_ccrseg.am5m = this.am5m;
                    db_ccrseg.recuperada = this.recuperada;
                    db_ccrseg.transinter = this.transinter;
                    db_ccrseg.arv5m = this.arv5m;
                    db_ccrseg.pcrmen2m = this.pcrmen2m;
                    db_ccrseg.pcrmai2m = this.pcrmai2m;
                    db_ccrseg.pcrposmen2m = this.pcrposmen2m;
                    db_ccrseg.pcrposmai2m = this.pcrposmai2m;
                    db_ccrseg.tb = this.tb;
                    db_ccrseg.dam = this.dam;
                    db_ccrseg.dag = this.dag;
                    db_ccrseg.ce9m = this.ce9m;
                    db_ccrseg.pnctl = this.pnctl;
                    db_ccrseg.tpi = this.tpi;
                    db_ccrseg.abandono9 = this.abandono9;
                    db_ccrseg.obito9 = this.obito9;
                    db_ccrseg.ce18m = ce18m;
                    db_ccrseg.resultado18 = this.resultado18;
                    db_ccrseg.transferidaCCS = this.transferidaCCS;
                    db_ccrseg.transferidaCI = this.transferidaCI;
                    db_ccrseg.transferidaUS = this.transferidaUS;
                    db_ccrseg.abandono18 = this.abandono18;
                    db_ccrseg.obito18 = this.obito9;
                    DbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                Logger.LogError("Error updating ccr segment on database", ex);
                throw ex;
            }
        }

        public override void DeleteEntity()
        {
            throw new NotImplementedException();
        }
    }
}
