using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEntidades.clsEntidadesregvis
{
   public class clsEntidadPersonas
    {        
        public int Cedula { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public int CasaId { get; set; }

        public string TipoVisitante { get; set; }

        public string Nota { get; set; }

        public string RutaFoto { get; set; }
    }
}
