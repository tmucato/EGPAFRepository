//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smiDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class maternidade
    {
        public int id { get; set; }
        public System.DateTime admissiondate { get; set; }
        public Nullable<System.TimeSpan> admissionhr { get; set; }
        public string nid_cpn { get; set; }
        public string nid_tarv { get; set; }
        public string name { get; set; }
        public string transfer { get; set; }
        public Nullable<int> age { get; set; }
        public string gestbirth { get; set; }
        public Nullable<int> gestage { get; set; }
        public Nullable<bool> serostatus_unk { get; set; }
        public Nullable<bool> serostatus_neg3m { get; set; }
        public Nullable<bool> serostatus_pos { get; set; }
        public Nullable<bool> cpn_arv_init { get; set; }
        public string mat_hiv_testing { get; set; }
        public Nullable<bool> triprofilafia { get; set; }
        public Nullable<bool> tarv_init_entr { get; set; }
        public Nullable<bool> tarv_init_matern { get; set; }
        public Nullable<System.DateTime> delivdate { get; set; }
        public Nullable<System.TimeSpan> delivhr { get; set; }
        public Nullable<bool> freq_fpos { get; set; }
        public Nullable<bool> fneg { get; set; }
        public Nullable<bool> eutocic { get; set; }
        public Nullable<bool> ventosa { get; set; }
        public Nullable<bool> caesarean { get; set; }
        public Nullable<bool> oth_dystocia { get; set; }
        public Nullable<bool> activeman3stag { get; set; }
        public Nullable<bool> manual_plac_remove { get; set; }
        public Nullable<bool> ceasarean_plac_remove { get; set; }
        public Nullable<bool> delivcomp { get; set; }
        public Nullable<bool> vertical_deliv { get; set; }
        public Nullable<bool> partogr_filled { get; set; }
        public Nullable<bool> plac_previa { get; set; }
        public Nullable<bool> detach_plac { get; set; }
        public Nullable<bool> uterineatony { get; set; }
        public Nullable<bool> placreten { get; set; }
        public Nullable<bool> laceration { get; set; }
        public Nullable<bool> out_rupt_uter { get; set; }
        public Nullable<bool> maternity_rupt_uter { get; set; }
        public Nullable<bool> tp_matern_local { get; set; }
        public Nullable<bool> tp_arrastado { get; set; }
        public Nullable<bool> pre_enclapsiasevera { get; set; }
        public Nullable<bool> C_eclampsia { get; set; }
        public Nullable<bool> sepsis { get; set; }
        public Nullable<bool> ot_complications { get; set; }
        public Nullable<bool> malaria { get; set; }
        public string anemia { get; set; }
        public Nullable<bool> hiv_sida { get; set; }
        public Nullable<bool> tb { get; set; }
        public Nullable<bool> poisontrademed { get; set; }
        public Nullable<bool> ot_complications2 { get; set; }
        public Nullable<bool> maternaldeath { get; set; }
        public string maternaldeathcause { get; set; }
        public Nullable<bool> pi_antibiotics { get; set; }
        public Nullable<bool> ev_im_pphemor { get; set; }
        public Nullable<bool> antihypertensive { get; set; }
        public Nullable<bool> magn_sulphate { get; set; }
        public Nullable<bool> intrauterine_asp { get; set; }
        public Nullable<bool> bloodtransf { get; set; }
        public Nullable<bool> hyster_obstetric { get; set; }
        public Nullable<bool> tip_malaria_4dose { get; set; }
        public Nullable<bool> diu_ppimediate { get; set; }
        public Nullable<bool> ot_pp { get; set; }
        public Nullable<bool> nadovivo { get; set; }
        public Nullable<bool> nadomorto { get; set; }
        public Nullable<bool> nadomorto_focoentrada { get; set; }
        public Nullable<bool> nadomorto_macerado { get; set; }
        public Nullable<bool> mot_skintoskin { get; set; }
        public Nullable<bool> breastfeeding_1hr { get; set; }
        public Nullable<bool> premature { get; set; }
        public Nullable<bool> neonatalsepsis { get; set; }
        public Nullable<bool> neonatalasphyxia { get; set; }
        public Nullable<bool> malformation { get; set; }
        public Nullable<bool> success_reanimation { get; set; }
        public Nullable<bool> unsuccess_reanimation { get; set; }
        public Nullable<bool> complicat_spec { get; set; }
        public Nullable<bool> twin { get; set; }
        public string gender { get; set; }
        public Nullable<int> weight { get; set; }
        public Nullable<bool> weight_under2500gr { get; set; }
        public Nullable<bool> newborn_arv { get; set; }
        public string nb_syphilistreat { get; set; }
        public string mot_vitamin_a { get; set; }
        public string mot_saltferrous { get; set; }
        public string mot_home_arv { get; set; }
        public string chd_home_arv { get; set; }
        public Nullable<System.DateTime> discharge_date { get; set; }
        public string transfer_out_us { get; set; }
        public Nullable<int> hospitaldays { get; set; }
        public string obs { get; set; }
        public string providername { get; set; }
    }
}