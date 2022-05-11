using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEntidades
{
    public class clsEntidadUsuario
    {
        public string IdUsuario { get; set; }
        public string nombre { get; set; }
        public string celular { get; set; }
        public string fijo { get; set; }
        public string fechnto { get; set; }
        public string email { get; set; }
        public string Usuario { get; set; }
        public string pwd { get; set; }
        public string pwdRecibida { get; set; }
        public string dir { get; set; }
        public int tipouser { get; set; }
        public int perfil { get; set; }
        public int estado { get; set; }
        public string usuAccion { get; set; }
        public string fechAccion { get; set; }
        public string UsuModifica { get; set; }
        public string FechaModifica { get; set; }
        public bool Autorizador { get; set; }
    }
}
