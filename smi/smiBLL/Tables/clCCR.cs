﻿using smiDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL.Tables
{
    public class clCCR : clTableBase<clCCR>
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

        public override List<clCCR> GetEntityList()
        {
            List<clCCR> List_ccr = new List<clCCR>();

            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    foreach (ccr db_ccr in DbContext.ccrs)
                    {
                        clCCR obj_ccr = new clCCR();
                        obj_ccr.id = Convert.ToInt32( db_ccr.id);
                        obj_ccr.idchild = Convert.ToInt32( db_ccr.idchild);
                        obj_ccr.nyear = Convert.ToInt32( db_ccr.nyear);
                        obj_ccr.nlivro = db_ccr.nlivro;
                        obj_ccr.nr_consulta = db_ccr.nr_consulta;
                        obj_ccr.dataconsulta = db_ccr.dataconsulta;
                        obj_ccr.age = db_ccr.age;
                        obj_ccr.ageunit = db_ccr.ageunit;
                        obj_ccr.mot_nid_cpn = db_ccr.mot_nid_cpn;
                        obj_ccr.mot_nid_tarv = db_ccr.mot_nid_tarv;
                        obj_ccr.mot_hiv_lact = db_ccr.mot_hiv_lact;
                        obj_ccr.mot_hiv_tarv = db_ccr.mot_hiv_tarv;
                        obj_ccr.contactotb = db_ccr.contactotb;
                        obj_ccr.desnutricao_aguda = db_ccr.desnutricao_aguda;
                        obj_ccr.exposicaoHIV = db_ccr.exposicaoHIV;
                        obj_ccr.outracondicaorisco = db_ccr.outracondicaorisco;
                        obj_ccr.pisoniazidainicio = db_ccr.pisoniazidainicio;
                        obj_ccr.pisoniazida = db_ccr.pisoniazida;
                        obj_ccr.aleitmaternomenor6m = db_ccr.aleitmaternomenor6m;
                        obj_ccr.aleitmaternonaior6m = db_ccr.aleitmaternonaior6m;
                        obj_ccr.atpu = db_ccr.atpu;
                        obj_ccr.csb_nut_sup = db_ccr.csb_nut_sup;
                        obj_ccr.recuperada = db_ccr.recuperada;
                        obj_ccr.internamento = db_ccr.internamento;
                        obj_ccr.ctz = db_ccr.ctz;
                        obj_ccr.profiaxia_arv = db_ccr.profiaxia_arv;
                        obj_ccr.colheitapcr = db_ccr.colheitapcr;
                        obj_ccr.resultadopcr = db_ccr.resultadopcr;
                        obj_ccr.resultadotesterapido = db_ccr.resultadotesterapido;
                        obj_ccr.resultadofinal = db_ccr.resultadofinal;
                        obj_ccr.resulttrapido_nexp = db_ccr.resulttrapido_nexp;
                        obj_ccr.saidaccr = db_ccr.saidaccr;
                        obj_ccr.chd_nid_tarv = db_ccr.chd_nid_tarv;
                        obj_ccr.obs = db_ccr.obs;
                        obj_ccr.providername = db_ccr.providername;
                        obj_ccr.motart_5m_chd = db_ccr.motart_5m_chd;
                        obj_ccr.tb = db_ccr.tb;
                        obj_ccr.dam_dag = db_ccr.dam_dag;
                        obj_ccr.ce = db_ccr.ce;
                        obj_ccr.tpicomp = db_ccr.tpicomp;
                        obj_ccr.ame_5m = db_ccr.ame_5m;
                        obj_ccr.mixed_5m = db_ccr.mixed_5m;
                        obj_ccr.rec = db_ccr.rec;
                        obj_ccr.trans_int = db_ccr.trans_int;
                        obj_ccr.arv_5m = db_ccr.arv_5m;
                        obj_ccr.pcr_under2m = db_ccr.pcrpos_under2m;
                        obj_ccr.pcr_above2m = db_ccr.pcrpos_above2m;
                        obj_ccr.pcrpos_under2m = db_ccr.pcrpos_under2m;
                        obj_ccr.pcrpos_above2m = db_ccr.pcrpos_above2m;
                        obj_ccr.pnctl = db_ccr.pnctl;
                        List_ccr.Add(obj_ccr);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of ccrs from database", ex);
                throw ex;
            }
            return List_ccr;
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