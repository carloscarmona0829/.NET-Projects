using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEntidades
{
    public class clsEntidadPermisosAPerfil
    {
        public int Id_Modulo { get; set; }
        public int Id_Perfil { get; set; }
        public string Usu_CreaUsuario { get; set; }
        public string Fecha_CreaUsuario { get; set; }
        public string Usu_ModUsuario { get; set; }
        public string Fecha_ModUsuario { get; set; }
        public int Id_PermiPerfil { get; set; }
    }
}
