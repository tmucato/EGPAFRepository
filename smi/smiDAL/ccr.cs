//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smiDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ccr
    {
        public int id { get; set; }
        public int idchild { get; set; }
        public int nyear { get; set; }
        public string nlivro { get; set; }
        public Nullable<int> nr_consulta { get; set; }
        public Nullable<System.DateTime> dataconsulta { get; set; }
        public Nullable<int> age { get; set; }
        public string ageunit { get; set; }
        public string mot_nid_cpn { get; set; }
        public string mot_nid_tarv { get; set; }
        public Nullable<bool> mot_hiv_lact { get; set; }
        public Nullable<bool> mot_hiv_tarv { get; set; }
        public Nullable<bool> contactotb { get; set; }
        public string desnutricao_aguda { get; set; }
        public Nullable<bool> exposicaoHIV { get; set; }
        public string outracondicaorisco { get; set; }
        public Nullable<System.DateTime> pisoniazidainicio { get; set; }
        public string pisoniazida { get; set; }
        public string aleitmaternomenor6m { get; set; }
        public Nullable<bool> aleitmaternonaior6m { get; set; }
        public Nullable<int> atpu { get; set; }
        public Nullable<bool> csb_nut_sup { get; set; }
        public Nullable<bool> recuperada { get; set; }
        public Nullable<bool> internamento { get; set; }
        public string ctz { get; set; }
        public Nullable<bool> profiaxia_arv { get; set; }
        public string colheitapcr { get; set; }
        public string resultadopcr { get; set; }
        public string resultadotesterapido { get; set; }
        public string resultadofinal { get; set; }
        public string resulttrapido_nexp { get; set; }
        public string saidaccr { get; set; }
        public string chd_nid_tarv { get; set; }
        public string obs { get; set; }
        public string providername { get; set; }
        public bool motart_5m_chd { get; set; }
        public Nullable<bool> tb { get; set; }
        public string dam_dag { get; set; }
        public Nullable<bool> ce { get; set; }
        public Nullable<bool> tpicomp { get; set; }
        public Nullable<bool> ame_5m { get; set; }
        public Nullable<bool> mixed_5m { get; set; }
        public Nullable<bool> rec { get; set; }
        public Nullable<bool> trans_int { get; set; }
        public Nullable<bool> arv_5m { get; set; }
        public Nullable<bool> pcr_under2m { get; set; }
        public Nullable<bool> pcr_above2m { get; set; }
        public Nullable<bool> pcrpos_under2m { get; set; }
        public Nullable<bool> pcrpos_above2m { get; set; }
        public Nullable<bool> pnctl { get; set; }
    
        public virtual child child { get; set; }
    }
}
