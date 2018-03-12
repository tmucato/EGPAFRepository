using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiBLL
{
    public class clCPP : clTableBase<clCPP>

    {
        public int id;
        public int nr_consulta;
        public int idmother;
        public string nlivro;
        public Nullable<DateTime> visdate;
        public int age;
        public string localparto;
        public string diasapoisparto;
        public Nullable<bool> parceiropresente;
        public string estadorecemnascido;
        public Nullable<bool> anemia;
        public string e_clinicogenecologico;
        public string outrapatologia;
        public string dag_dam;
        public string suplementonutricional;
        public Nullable<bool> transferida;
        public string almaternoexclusivo;
        public string testemalaria;
        public string resultado_TDR_HTZ;
        public string puerperamalariatratada;
        public string estadoentradacpp;
        public string resultadocpp;
        public string dosepuerpera;
        public string iniciottosifiliscpp;
        public string parceirottocpp;
        public string seroestadoentradacpp;
        public string testehivconsultacpp;
        public Nullable<bool> emtarv;
        public Nullable<bool> iniciatarv;
        public Nullable<bool> continuatarv;
        public Nullable<bool> rn_tarv;
        public string testehivparceiro;
        public string ttopuerpera;
        public string rntto;
        public string vitAcpp;
        public string salferroso_acfolico;
        public string transfistula;
        public string rnccr;
        public string transcsr_pf;
        public string obs;
        public string providername;

        public clCPP()
        {

            id = 0;
            nr_consulta = 0;
            idmother = 0;
            nlivro = string.Empty;
            visdate = null;
            age = 0;
            localparto = string.Empty;
            diasapoisparto = string.Empty;
            parceiropresente = null;
            estadorecemnascido = string.Empty;
            anemia = null;
            e_clinicogenecologico = string.Empty;
            outrapatologia = string.Empty;
            dag_dam = string.Empty;
            suplementonutricional = string.Empty;
            transferida = null;
            almaternoexclusivo = string.Empty;
            testemalaria = string.Empty;
            resultado_TDR_HTZ = string.Empty;
            puerperamalariatratada = string.Empty;
            estadoentradacpp = string.Empty;
            resultadocpp = string.Empty;
            dosepuerpera = string.Empty;
            iniciottosifiliscpp = string.Empty;
            parceirottocpp = string.Empty;
            seroestadoentradacpp = string.Empty;
            testehivconsultacpp = string.Empty;
            emtarv = null;
            iniciatarv = null;
            continuatarv = null;
            rn_tarv = null;
            testehivparceiro = string.Empty;
            ttopuerpera = string.Empty;
            rntto = string.Empty;
            vitAcpp = string.Empty;
            salferroso_acfolico = string.Empty;
            transfistula = string.Empty;
            rnccr = string.Empty;
            transcsr_pf = string.Empty;
            obs = string.Empty;
            providername = string.Empty;

        }

        public override void DeleteEntity()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public override DataTable GetEntityDatatable()
        {
            throw new NotImplementedException();
        }

        public override List<clCPP> GetEntityList()
        {
            List<clCPP> list_cpp = new List<clCPP>();
            clCPP cpp = new clCPP();

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            return list_cpp;
        }

        public override void InsertEntity()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void UpdateEntity()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
