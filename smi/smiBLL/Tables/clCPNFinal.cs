using smiDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    cpn_final db_cpn_final = DbContext.cpn_final.Where(cf => cf.id == this.id).FirstOrDefault();
                    DbContext.cpn_final.Remove(db_cpn_final);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error deliting cpn_final " + this.id + " on database", ex);
                throw ex;
            }
        }

        public override List<clCPNFinal> GetEntityList()
        {
            List<clCPNFinal> List_cpn_final = new List<clCPNFinal>();

            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    foreach (cpn_final db_cpn_final in DbContext.cpn_final)
                    {
                        clCPNFinal obj_cpn_final = new clCPNFinal();

                        obj_cpn_final.id = db_cpn_final.id;
                        obj_cpn_final.idmother = db_cpn_final.idmother;
                        obj_cpn_final.nlivro = db_cpn_final.nlivro;
                        obj_cpn_final.cons_more4 = db_cpn_final.cons_more4;
                        obj_cpn_final.partnerpreence = db_cpn_final.partnerpreence;
                        obj_cpn_final.weightgainyno = db_cpn_final.weightgainyno;
                        obj_cpn_final.dag = db_cpn_final.dag;
                        obj_cpn_final.dam = db_cpn_final.dam;
                        obj_cpn_final.supnutr = db_cpn_final.supnutr;
                        obj_cpn_final.resultcured = db_cpn_final.resultcured;
                        obj_cpn_final.resultabandon = db_cpn_final.resultabandon;
                        obj_cpn_final.receiveddesparasitante = db_cpn_final.receiveddesparasitante;
                        obj_cpn_final.salferr_more3 = db_cpn_final.salferr_more3;
                        obj_cpn_final.its_diag = db_cpn_final.its_diag;
                        obj_cpn_final.its_treatment = db_cpn_final.its_treatment;
                        obj_cpn_final.its_syphilistesting = db_cpn_final.its_syphilistesting;
                        obj_cpn_final.its_wsyphilistreat = db_cpn_final.its_wsyphilistreat;
                        obj_cpn_final.its_psyphilistreat = db_cpn_final.its_syphilistesting;
                        obj_cpn_final.womanserostatus = db_cpn_final.womanserostatus;
                        obj_cpn_final.partnerserostatus = db_cpn_final.partnerserostatus;
                        obj_cpn_final.ctz_entr = db_cpn_final.ctz_entr;
                        obj_cpn_final.ctz_init = db_cpn_final.ctz_init;
                        obj_cpn_final.finalresult_arv = db_cpn_final.finalresult_arv;
                        obj_cpn_final.tip = db_cpn_final.tip;
                        obj_cpn_final.bednet = db_cpn_final.bednet;
                        obj_cpn_final.mal_diag_lab = db_cpn_final.mal_diag_lab;
                        obj_cpn_final.mal_treatment = db_cpn_final.mal_treatment;
                        obj_cpn_final.mp = db_cpn_final.mp;
                        obj_cpn_final.vat_1_dose = db_cpn_final.vat_1_dose;
                        obj_cpn_final.vat_2_5_dose = db_cpn_final.vat_2_5_dose;
                        obj_cpn_final.tb_isoniazid = db_cpn_final.tb_isoniazid;
                        obj_cpn_final.tb_treatment = db_cpn_final.tb_treatment;
                        List_cpn_final.Add(obj_cpn_final);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of cpn final status from database", ex);
                throw;
            }

            return List_cpn_final;
        }

        public override void InsertEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    cpn_final db_cpn_final = new cpn_final();
                    db_cpn_final.idmother = this.idmother;
                    db_cpn_final.nlivro = this.nlivro;
                    db_cpn_final.cons_more4 = this.cons_more4;
                    db_cpn_final.partnerpreence = this.partnerpreence;
                    db_cpn_final.weightgainyno = this.weightgainyno;
                    db_cpn_final.dag = this.dag;
                    db_cpn_final.dam = this.dam;
                    db_cpn_final.supnutr = this.supnutr;
                    db_cpn_final.resultcured = this.resultcured;
                    db_cpn_final.resultabandon = this.resultabandon;
                    db_cpn_final.receiveddesparasitante = this.receiveddesparasitante;
                    db_cpn_final.salferr_more3 = this.salferr_more3;
                    db_cpn_final.its_diag = this.its_diag;
                    db_cpn_final.its_treatment = this.its_treatment;
                    db_cpn_final.its_syphilistesting = this.its_syphilistesting;
                    db_cpn_final.its_wsyphilistreat = this.its_wsyphilistreat;
                    db_cpn_final.its_psyphilistreat = this.its_syphilistesting;
                    db_cpn_final.womanserostatus = this.womanserostatus;
                    db_cpn_final.partnerserostatus = this.partnerserostatus;
                    db_cpn_final.ctz_entr = this.ctz_entr;
                    db_cpn_final.ctz_init = this.ctz_init;
                    db_cpn_final.finalresult_arv = this.finalresult_arv;
                    db_cpn_final.tip = this.tip;
                    db_cpn_final.bednet = this.bednet;
                    db_cpn_final.mal_diag_lab = this.mal_diag_lab;
                    db_cpn_final.mal_treatment = this.mal_treatment;
                    db_cpn_final.mp = this.mp;
                    db_cpn_final.vat_1_dose = this.vat_1_dose;
                    db_cpn_final.vat_2_5_dose = this.vat_2_5_dose;
                    db_cpn_final.tb_isoniazid = this.tb_isoniazid;
                    db_cpn_final.tb_treatment = this.tb_treatment;
                    DbContext.cpn_final.Add(db_cpn_final);
                    DbContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Logger.LogError("Error updating cpn_final on database", ex);
                throw ex;
            }
        }

        public override void UpdateEntity()
        {
            try
            {
                using (DBsmiEntities DbContext = new DBsmiEntities(Connection.GetEFSMIDataBaseConStr()))
                {
                    cpn_final db_cpn_final = DbContext.cpn_final.Where(cf => cf.id == this.id).FirstOrDefault();
                    db_cpn_final.idmother = this.idmother;
                    db_cpn_final.nlivro = this.nlivro;
                    db_cpn_final.cons_more4 = this.cons_more4;
                    db_cpn_final.partnerpreence = this.partnerpreence;
                    db_cpn_final.weightgainyno = this.weightgainyno;
                    db_cpn_final.dag = this.dag;
                    db_cpn_final.dam = this.dam;
                    db_cpn_final.supnutr = this.supnutr;
                    db_cpn_final.resultcured = this.resultcured;
                    db_cpn_final.resultabandon = this.resultabandon;
                    db_cpn_final.receiveddesparasitante = this.receiveddesparasitante;
                    db_cpn_final.salferr_more3 = this.salferr_more3;
                    db_cpn_final.its_diag = this.its_diag;
                    db_cpn_final.its_treatment = this.its_treatment;
                    db_cpn_final.its_syphilistesting = this.its_syphilistesting;
                    db_cpn_final.its_wsyphilistreat = this.its_wsyphilistreat;
                    db_cpn_final.its_psyphilistreat = this.its_syphilistesting;
                    db_cpn_final.womanserostatus = this.womanserostatus;
                    db_cpn_final.partnerserostatus = this.partnerserostatus;
                    db_cpn_final.ctz_entr = this.ctz_entr;
                    db_cpn_final.ctz_init = this.ctz_init;
                    db_cpn_final.finalresult_arv = this.finalresult_arv;
                    db_cpn_final.tip = this.tip;
                    db_cpn_final.bednet = this.bednet;
                    db_cpn_final.mal_diag_lab = this.mal_diag_lab;
                    db_cpn_final.mal_treatment = this.mal_treatment;
                    db_cpn_final.mp = this.mp;
                    db_cpn_final.vat_1_dose = this.vat_1_dose;
                    db_cpn_final.vat_2_5_dose = this.vat_2_5_dose;
                    db_cpn_final.tb_isoniazid = this.tb_isoniazid;
                    db_cpn_final.tb_treatment = this.tb_treatment;
                    DbContext.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                Logger.LogError("Error updating cpn_final on database", ex);
                throw ex;
            }
        }

        public override DataTable GetEntityDatatable()
        {
            throw new NotImplementedException();
        }
    }
}
