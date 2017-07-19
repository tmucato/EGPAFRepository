using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL.Tables
{
    public class clCCRSeg : clTableBase<clCCRSeg>
    {
        public int id;
        public int idccr;
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
            idccr = 0;
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
            throw new NotImplementedException();
        }

        public override DataTable GetEntityDatatable()
        {
            throw new NotImplementedException();
        }

        public override void InsertEntity()
        {
            throw new NotImplementedException();
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
