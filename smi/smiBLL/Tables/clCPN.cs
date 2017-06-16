using smiDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
        public Nullable<int> gestationalage;
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
        public string its_syphilistratmentmulhr;
        public string its_syphilistratmentparceir;
        public string serostatusentcpn;
        public string cpnhivtest;
        public string partnerhivtest;
        public Nullable<bool> ctz;
        public string ctz_init_cont;
        public Nullable<bool> tarv;
        public Nullable<bool> nvp;
        public Nullable<bool> azt_nvp;
        public Nullable<bool> em_tarv_entrada;
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
            visdate = new DateTime(1800,1,1);
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
            its_syphilistratmentmulhr = string.Empty;
            its_syphilistratmentparceir = string.Empty;
            serostatusentcpn = string.Empty;
            cpnhivtest = string.Empty;
            partnerhivtest = string.Empty;
            ctz = null; ;
            ctz_init_cont = string.Empty;
            tarv = null;
            nvp = null;
            azt_nvp = null;
            tarv_init_visit = null;
            em_tarv_entrada = null;
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



        public override List<clCPN> GetEntityList()
        {
            List<clCPN> List_cpn = new List<clCPN>();
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    foreach (cpn db_cpn in DbContext.cpns)
                    {
                        clCPN obj_cpn = new clCPN();
                        obj_cpn.id = db_cpn.id;
                        obj_cpn.nr_consulta = Convert.ToInt32(db_cpn.nr_consulta);
                        obj_cpn.idmother = db_cpn.idmother;
                        obj_cpn.nlivro = db_cpn.nlivro;
                        obj_cpn.nyear = db_cpn.nyear;
                        obj_cpn.visdate = db_cpn.visdate;
                        obj_cpn.agegroup = db_cpn.agegroup;
                        obj_cpn.gestationalage = db_cpn.gestationalage;
                        obj_cpn.gageless12 = db_cpn.gageless12;
                        obj_cpn.partnerpresence = db_cpn.partnerpresence;
                        obj_cpn.weight = Convert.ToInt32(db_cpn.weight);
                        obj_cpn.weightgainyno = db_cpn.weightgainyno;
                        obj_cpn.dag = db_cpn.dag;
                        obj_cpn.dam = db_cpn.dam;
                        obj_cpn.supnutr = Convert.ToInt32(db_cpn.supnutr);
                        obj_cpn.resultcured = db_cpn.resultcured;
                        obj_cpn.resultabandon = db_cpn.resultabandon;
                        obj_cpn.receiveddesparasitante = db_cpn.receiveddesparasitante;
                        obj_cpn.salferr_acfolico = db_cpn.salferr_acfolico;
                        obj_cpn.ta = db_cpn.ta;
                        obj_cpn.hgb = db_cpn.hgb;
                        obj_cpn.proteinuria = db_cpn.proteinuria;
                        obj_cpn.glicosuria = db_cpn.glicosuria;
                        obj_cpn.its_ulceragenital = db_cpn.its_ulceragenital;
                        obj_cpn.its_leucorreia = db_cpn.its_leucorreia;
                        obj_cpn.its_syndromictreatment = db_cpn.its_syndromictreatment;
                        obj_cpn.its_syphilistesting = db_cpn.its_syphilistesting;
                        obj_cpn.its_wsyphilistreat = db_cpn.its_wsyphilistreat;
                        obj_cpn.its_psyphilistreat = db_cpn.its_psyphilistreat;
                        obj_cpn.its_wsyphilistreat = db_cpn.its_wsyphilistreat;
                        obj_cpn.its_psyphilistreat = db_cpn.its_psyphilistreat;
                        obj_cpn.serostatusentcpn = db_cpn.serostatusentcpn;
                        obj_cpn.cpnhivtest = db_cpn.cpnhivtest;
                        obj_cpn.partnerhivtest = db_cpn.partnerhivtest;
                        obj_cpn.ctz = db_cpn.ctz;
                        obj_cpn.ctz_init_cont = db_cpn.ctz_init_cont;
                        obj_cpn.tarv = db_cpn.tarv;
                        obj_cpn.nvp = db_cpn.nvp;
                        obj_cpn.azt_nvp = db_cpn.azt_nvp;
                        obj_cpn.tarv_init_visit = db_cpn.tarv_init_visit;
                        obj_cpn.em_tarv_entrada = db_cpn.em_tarv_entrada;
                        obj_cpn.arv_cont = db_cpn.arv_cont;
                        obj_cpn.tip = db_cpn.tip;
                        obj_cpn.bednet = db_cpn.bednet;
                        obj_cpn.tdr_htz = db_cpn.tdr_htz;
                        obj_cpn.result_tdr_htz = db_cpn.result_tdr_htz;
                        obj_cpn.pos_malaria_treated = db_cpn.pos_malaria_treated;
                        obj_cpn.hpp = db_cpn.hpp;
                        obj_cpn.vat_1_dose = db_cpn.vat_1_dose;
                        obj_cpn.vat_2_5_dose = db_cpn.vat_2_5_dose;
                        obj_cpn.tb_isoniazid = db_cpn.tb_isoniazid;
                        obj_cpn.tb_treatment = db_cpn.tb_treatment;
                        obj_cpn.obs = db_cpn.obs;
                        obj_cpn.providername = db_cpn.providername;
                        List_cpn.Add(obj_cpn);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of cpns from database", ex);
                throw;
            }
            return List_cpn;
        }

        public override void InsertEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    cpn db_cpn = new cpn();
                    db_cpn.nr_consulta = Convert.ToInt32(this.nr_consulta);
                    db_cpn.idmother = this.idmother;
                    db_cpn.nlivro = this.nlivro;
                    db_cpn.nyear = this.nyear;
                    db_cpn.visdate = this.visdate;
                    db_cpn.agegroup = this.agegroup;
                    db_cpn.gestationalage = this.gestationalage;
                    db_cpn.gageless12 = this.gageless12;
                    db_cpn.partnerpresence = this.partnerpresence;
                    db_cpn.weight = Convert.ToInt32(this.weight);
                    db_cpn.weightgainyno = this.weightgainyno;
                    db_cpn.dag = this.dag;
                    db_cpn.dam = this.dam;
                    db_cpn.supnutr = Convert.ToInt32(this.supnutr);
                    db_cpn.resultcured = this.resultcured;
                    db_cpn.resultabandon = this.resultabandon;
                    db_cpn.receiveddesparasitante = this.receiveddesparasitante;
                    db_cpn.salferr_acfolico = this.salferr_acfolico;
                    db_cpn.ta = this.ta;
                    db_cpn.hgb = this.hgb;
                    db_cpn.proteinuria = this.proteinuria;
                    db_cpn.glicosuria = this.glicosuria;
                    db_cpn.its_ulceragenital = this.its_ulceragenital;
                    db_cpn.its_leucorreia = this.its_leucorreia;
                    db_cpn.its_syndromictreatment = this.its_syndromictreatment;
                    db_cpn.its_syphilistesting = this.its_syphilistesting;
                    db_cpn.its_wsyphilistreat = this.its_wsyphilistreat;
                    db_cpn.its_psyphilistreat = this.its_psyphilistreat;
                    db_cpn.its_wsyphilistreat = this.its_wsyphilistreat;
                    db_cpn.its_psyphilistreat = this.its_psyphilistreat;
                    db_cpn.serostatusentcpn = this.serostatusentcpn;
                    db_cpn.cpnhivtest = this.cpnhivtest;
                    db_cpn.partnerhivtest = this.partnerhivtest;
                    db_cpn.ctz = this.ctz;
                    db_cpn.ctz_init_cont = this.ctz_init_cont;
                    db_cpn.tarv = this.tarv;
                    db_cpn.nvp = this.nvp;
                    db_cpn.azt_nvp = this.azt_nvp;
                    db_cpn.em_tarv_entrada = this.em_tarv_entrada;
                    db_cpn.tarv_init_visit = this.tarv_init_visit;
                    db_cpn.arv_cont = this.arv_cont;
                    db_cpn.tip = this.tip;
                    db_cpn.bednet = this.bednet;
                    db_cpn.tdr_htz = this.tdr_htz;
                    db_cpn.result_tdr_htz = this.result_tdr_htz;
                    db_cpn.pos_malaria_treated = this.pos_malaria_treated;
                    db_cpn.hpp = this.hpp;
                    db_cpn.vat_1_dose = this.vat_1_dose;
                    db_cpn.vat_2_5_dose = this.vat_2_5_dose;
                    db_cpn.tb_isoniazid = this.tb_isoniazid;
                    db_cpn.tb_treatment = this.tb_treatment;
                    db_cpn.obs = this.obs;
                    db_cpn.providername = this.providername;
                    DbContext.cpns.Add(db_cpn);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error inserting cpn record on database", ex);
                throw ex;
            }
        }

        public override void UpdateEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    cpn db_cpn = DbContext.cpns.Where(c => c.id == this.id).FirstOrDefault();
                    db_cpn.id = this.id;
                    db_cpn.nr_consulta = Convert.ToInt32(this.nr_consulta);
                    db_cpn.idmother = this.idmother;
                    db_cpn.nlivro = this.nlivro;
                    db_cpn.nyear = this.nyear;
                    db_cpn.visdate = this.visdate;
                    db_cpn.agegroup = this.agegroup;
                    db_cpn.gestationalage = this.gestationalage;
                    db_cpn.gageless12 = this.gageless12;
                    db_cpn.partnerpresence = this.partnerpresence;
                    db_cpn.weight = Convert.ToInt32(this.weight);
                    db_cpn.weightgainyno = this.weightgainyno;
                    db_cpn.dag = this.dag;
                    db_cpn.dam = this.dam;
                    db_cpn.supnutr = Convert.ToInt32(this.supnutr);
                    db_cpn.resultcured = this.resultcured;
                    db_cpn.resultabandon = this.resultabandon;
                    db_cpn.receiveddesparasitante = this.receiveddesparasitante;
                    db_cpn.salferr_acfolico = this.salferr_acfolico;
                    db_cpn.ta = this.ta;
                    db_cpn.hgb = this.hgb;
                    db_cpn.proteinuria = this.proteinuria;
                    db_cpn.glicosuria = this.glicosuria;
                    db_cpn.its_ulceragenital = this.its_ulceragenital;
                    db_cpn.its_leucorreia = this.its_leucorreia;
                    db_cpn.its_syndromictreatment = this.its_syndromictreatment;
                    db_cpn.its_syphilistesting = this.its_syphilistesting;
                    db_cpn.its_wsyphilistreat = this.its_wsyphilistreat;
                    db_cpn.its_psyphilistreat = this.its_psyphilistreat;
                    db_cpn.its_wsyphilistreat = this.its_wsyphilistreat;
                    db_cpn.its_psyphilistreat = this.its_psyphilistreat;
                    db_cpn.serostatusentcpn = this.serostatusentcpn;
                    db_cpn.cpnhivtest = this.cpnhivtest;
                    db_cpn.partnerhivtest = this.partnerhivtest;
                    db_cpn.ctz = this.ctz;
                    db_cpn.ctz_init_cont = this.ctz_init_cont;
                    db_cpn.tarv = this.tarv;
                    db_cpn.nvp = this.nvp;
                    db_cpn.azt_nvp = this.azt_nvp;
                    db_cpn.em_tarv_entrada = this.em_tarv_entrada;
                    db_cpn.tarv_init_visit = this.tarv_init_visit;
                    db_cpn.arv_cont = this.arv_cont;
                    db_cpn.tip = this.tip;
                    db_cpn.bednet = this.bednet;
                    db_cpn.tdr_htz = this.tdr_htz;
                    db_cpn.result_tdr_htz = this.result_tdr_htz;
                    db_cpn.pos_malaria_treated = this.pos_malaria_treated;
                    db_cpn.hpp = this.hpp;
                    db_cpn.vat_1_dose = this.vat_1_dose;
                    db_cpn.vat_2_5_dose = this.vat_2_5_dose;
                    db_cpn.tb_isoniazid = this.tb_isoniazid;
                    db_cpn.tb_treatment = this.tb_treatment;
                    db_cpn.obs = this.obs;
                    db_cpn.providername = this.providername;
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error updating cpn record on database", ex);
                throw ex;
            }
        }

        public override void DeleteEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    cpn db_cpn = DbContext.cpns.Where(c => c.id == this.id).FirstOrDefault();
                    DbContext.cpns.Remove(db_cpn);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Logger.LogError("Error deliting cpn " + this.id + " on database", ex);
                throw ex;
            }

        }

        public override DataTable GetEntityDatatable()
        {
            throw new NotImplementedException();
        }
    }
}
