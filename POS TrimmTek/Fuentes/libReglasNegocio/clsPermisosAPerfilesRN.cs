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
    public class clsPermisosAPerfilesRN
    {
        public DataSet CargarCombosPermisosAPerfiles()
        {
            try
            {
                clsPermisosAPerfilesAD objRN = new clsPermisosAPerfilesAD();
                return objRN.CargarCombosPermisosAPerfiles();
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }
        public DataTable PermisosAPerfilCRUD(string Accion, clsEntidadPermisosAPerfil entidadPermisosPorPerfil)
        {
            try
            {
                clsPermisosAPerfilesAD objRN = new clsPermisosAPerfilesAD();
                return objRN.PermisosAPerfilCRUD(Accion, entidadPermisosPorPerfil);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
