using System;
using System.Collections.Generic;
using System.Data;

namespace smiBLL
{
   public class clCPNFinal : clTableBase<clCPNFinal>
    {



        public long id;
        public long idmother;
        public string nlivro;
        public Nullable<bool> cons_more4;
        public Nullable<bool> partnerpreence;
        public string weightgainyno;
        public Nullable<bool> dag;
        public Nullable<bool> dam;
        public string supnutr;
        public string resultcured;
        public string resultabandon;
        public string receiveddesparasitante;
        public Nullable<bool> salferr_more3;
        public Nullable<bool> its_diag;
        public string its_treatment;
        public string its_syphilistesting;
        public Nullable<bool> its_wsyphilistreat;
        public string its_psyphilistreat;
        public string womanserostatus;
        public string partnerserostatus;
        public Nullable<bool> ctz_entr;
        public Nullable<bool> ctz_init;
        public string finalresult_arv;
        public string tip;
        public string bednet;
        public string mal_diag_lab;
        public string mal_treatment;
        public string mp;
        public Nullable<bool> vat_1_dose;
        public Nullable<bool> vat_2_5_dose;
        public Nullable<bool> tb_isoniazid;
        public Nullable<bool> tb_treatment;

        public clCPNFinal()
        {
            id = 0;
            idmother = 0;
            nlivro = string.Empty;
            cons_more4 = null;
            partnerpreence = null;
            weightgainyno = string.Empty;
            dag = null;
            dam = null;
            supnutr = string.Empty;
            resultcured = string.Empty;
            resultabandon = string.Empty;
            receiveddesparasitante = string.Empty;
            salferr_more3 = null;
            its_diag = null;
            its_treatment = string.Empty;
            its_syphilistesting = string.Empty;
            its_wsyphilistreat = null;
            its_psyphilistreat = string.Empty;
            womanserostatus = string.Empty;
            partnerserostatus = string.Empty;
            ctz_entr = null;
            ctz_init = null;
            finalresult_arv = string.Empty;
            tip = string.Empty;
            bednet = string.Empty;
            mal_diag_lab = string.Empty;
            mal_treatment = string.Empty;
            mp = string.Empty;
            vat_1_dose = null;
            vat_2_5_dose = null;
            tb_isoniazid = null;
            tb_treatment = null;

        }





        public override void DeleteEntity()
        {
            throw new NotImplementedException();
        }

        public override List<clCPNFinal> GetEntityList()
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

        public override DataTable GetEntityDatatable()
        {
            throw new NotImplementedException();
        }
    }
}
