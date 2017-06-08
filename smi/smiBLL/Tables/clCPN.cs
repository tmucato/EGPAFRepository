using System;
using System.Collections.Generic;

namespace smiBLL
{
    public class clCPN : clTableBase<clCPN>
    {

        public long id;
        public int nr_consulta;
        public long idmother;
        public string nlivro;
        public int nyear;
        public System.DateTime visdate;
        public string agegroup;
        public int gestationalage;
        public Nullable<bool> gageless12;
        public Nullable<bool> partnerpresence;
        public int weight;
        public string weightgainyno;
        public Nullable<bool> dag;
        public Nullable<bool> dam;
        public int supnutr;
        public string resultcured;
        public string resultabandon;
        public string receiveddesparasitante;
        public string salferr_acfolico;
        public string ta;
        public string hgb;
        public string proteinuria;
        public string glicosuria;
        public Nullable<bool> its_ulceragenital;
        public Nullable<bool> its_leucorreia;
        public string its_syndromictreatment;
        public string its_syphilistesting;
        public string its_wsyphilistreat;
        public string its_psyphilistreat;
        public Nullable<bool> serostatusdesc;
        public Nullable<bool> serostatusneg;
        public Nullable<bool> serostatuspos;
        public string cpnhivtest;
        public string partnerhivtest;
        public Nullable<bool> ctz;
        public string ctz_init_cont;
        public Nullable<bool> tarv;
        public Nullable<bool> nvp;
        public Nullable<bool> azt_nvp;
        public Nullable<bool> tarv_init_visit;
        public Nullable<bool> arv_cont;
        public string tip;
        public string bednet;
        public string tdr_htz;
        public string result_tdr_htz;
        public string pos_malaria_treated;
        public string hpp;
        public Nullable<bool> vat_1_dose;
        public Nullable<bool> vat_2_5_dose;
        public string tb_isoniazid;
        public string tb_treatment;
        public string obs;
        public string providername;

        public clCPN()
        {
            id = 0;
            nr_consulta = 0;
            idmother = 0;
            nlivro = string.Empty;
            nyear = 0;
            visdate = DateTime.MinValue;
            agegroup = string.Empty;
            gestationalage = 0;
            gageless12 = null;
            partnerpresence = null;
            weight = 0;
            weightgainyno = string.Empty; ;
            dag = null;
            dam = null;
            supnutr = 0;
            resultcured = string.Empty;
            resultabandon = string.Empty;
            receiveddesparasitante = string.Empty;
            salferr_acfolico = string.Empty;
            ta = string.Empty;
            hgb = string.Empty;
            proteinuria = string.Empty;
            glicosuria = string.Empty;
            its_ulceragenital = null;
            its_leucorreia = null;
            its_syndromictreatment = string.Empty;
            its_syphilistesting = string.Empty;
            its_wsyphilistreat = string.Empty;
            its_psyphilistreat = string.Empty;
            serostatusdesc = null;
            serostatusneg = null;
            serostatuspos = null;
            cpnhivtest = string.Empty;
            partnerhivtest = string.Empty;
            ctz = null; ;
            ctz_init_cont = string.Empty;
            tarv = null;
            nvp = null;
            azt_nvp = null;
            tarv_init_visit = null;
            arv_cont = null;
            tip = string.Empty;
            bednet = string.Empty;
            tdr_htz = null;
            result_tdr_htz = string.Empty;
            pos_malaria_treated = string.Empty;
            hpp = string.Empty;
            vat_1_dose = null;
            vat_2_5_dose = null;
            tb_isoniazid = string.Empty;
            tb_treatment = string.Empty;
            obs = string.Empty;
            providername = string.Empty;
        }



        public override void DeleteEntity()
        {
            throw new NotImplementedException();
        }

        public override List<clCPN> GetEntityList()
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
    }
}
