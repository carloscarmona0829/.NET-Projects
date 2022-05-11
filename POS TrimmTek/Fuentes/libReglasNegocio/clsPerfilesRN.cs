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
    public class clsPerfilesRN
    {
        public DataTable PerfilesCrud(string Accion, clsEntidadPerfil entidadPerfil)
        {
            try
            {
                clsPerfilesAD objRN = new clsPerfilesAD();
                return objRN.PerfilesCrud(Accion, entidadPerfil);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
