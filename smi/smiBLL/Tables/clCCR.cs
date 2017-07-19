using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL.Tables
{
    public class clCCR
    {

        public int id;
        public int idchild;
        public int nyear;
        public string nlivro;
        public Nullable<bool> nr_consulta;
        public Nullable<System.DateTime> dataconsulta;
        public Nullable<int> age;
        public string ageunit;
        public string mot_nid_cpn;
        public string mot_nid_tarv;
        public Nullable<bool> mot_hiv_lact;
        public Nullable<bool> mot_hiv_tarv;
        public Nullable<bool> contactotb;
        public string desnutricao_aguda;
        public Nullable<bool> exposicaoHIV;
        public string outracondicaorisco;
        public Nullable<System.DateTime> pisoniazidainicio;
        public string pisoniazida;
        public string aleitmaternomenor6m;
        public Nullable<bool> aleitmaternonaior6m;
        public Nullable<int> atpu;
        public Nullable<bool> csb_nut_sup;
        public Nullable<bool> recuperada;
        public Nullable<bool> internamento;
        public string ctz;
        public Nullable<bool> profiaxia_arv;
        public string colheitapcr;
        public string resultadopcr;
        public string resultadotesterapido;
        public string resultadofinal;
        public string resulttrapido_nexp;
        public string saidaccr;
        public string chd_nid_tarv;
        public string obs;
        public string providername;
        public bool motart_5m_chd;
        public Nullable<bool> tb;
        public string dam_dag;
        public Nullable<bool> ce;
        public Nullable<bool> tpicomp;
        public Nullable<bool> ame_5m;
        public Nullable<bool> mixed_5m;
        public Nullable<bool> rec;
        public Nullable<bool> trans_int;
        public Nullable<bool> arv_5m;
        public Nullable<bool> pcr_under2m;
        public Nullable<bool> pcr_above2m;
        public Nullable<bool> pcrpos_under2m;
        public Nullable<bool> pcrpos_above2m;
        public Nullable<bool> pnctl;

        public clCCR()
        {
            id = 0;
            idchild = 0;
            nyear = 0;
            nlivro = string.Empty;
            nr_consulta = null;
            dataconsulta = null;
            age = 0;
            ageunit = string.Empty;
            mot_nid_cpn = string.Empty;
            mot_nid_tarv = string.Empty;
            mot_hiv_lact = null;
            mot_hiv_tarv = null;
            contactotb = null;
            desnutricao_aguda = string.Empty;
            exposicaoHIV = null;
            outracondicaorisco = string.Empty;
            pisoniazidainicio = null;
            pisoniazida = string.Empty;
            aleitmaternomenor6m = string.Empty;
            aleitmaternonaior6m = null;
            atpu = 0;
            csb_nut_sup = null;
            recuperada = null;
            internamento = null;
            ctz = string.Empty;
            profiaxia_arv = null;
            colheitapcr = string.Empty;
            resultadopcr = string.Empty;
            resultadotesterapido = string.Empty;
            resultadofinal = string.Empty;
            resulttrapido_nexp = string.Empty;
            saidaccr = string.Empty;
            chd_nid_tarv = string.Empty;
            obs = string.Empty;
            providername = string.Empty;
            motart_5m_chd = false;
            tb = null;
            dam_dag = string.Empty;
            ce = null;
            tpicomp = null;
            ame_5m = null;
            mixed_5m = null;
            rec = null;
            trans_int = null;
            arv_5m = null;
            pcr_under2m = null;
            pcr_above2m = null;
            pcrpos_under2m = null;
            pcrpos_above2m = null;
            pnctl = null;

        }



    }
}
