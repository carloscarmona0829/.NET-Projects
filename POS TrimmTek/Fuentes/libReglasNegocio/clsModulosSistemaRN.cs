using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libAccesoDatos;
using libEntidades;

namespace libReglasNegocio
{
    public class clsModulosSistemaRN
    {
        public DataTable ModulosSistemaCRUD(string Accion, clsEntidadModulosDelSistema entidadModulosDelSistema)
        {
            try
            {
                clsModulosSistemaAD objRN = new clsModulosSistemaAD();
                return objRN.ModulosSistemaCRUD(Accion, entidadModulosDelSistema);
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }
    }
}
