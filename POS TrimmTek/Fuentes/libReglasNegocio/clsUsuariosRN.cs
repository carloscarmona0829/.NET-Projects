using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libEntidades;
using libAccesoDatos;

namespace libReglasNegocio
{
    public class clsUsuariosRN
    {
        public DataSet CargarCombosUsuarios()
        {
            try
            {
                clsUsuariosAD objRN = new clsUsuariosAD();
                return objRN.CargarCombosUsuarios();

            }
            catch (Exception Error)
            {
                throw Error;
            }
        }
        
        public DataTable UsuariosCrud(string Accion, clsEntidadUsuario entidadUsuario)
        {
            try
            {
                clsUsuariosAD objRN = new clsUsuariosAD();
                return objRN.UsuariosCrud(Accion, entidadUsuario);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable LoginUsuarios(clsEntidadUsuario entidadUsuario)
        {
            try
            {
                clsUsuariosAD objRN = new clsUsuariosAD();
                return objRN.LoginUsuarios(entidadUsuario);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable RecuperarContraseña(clsEntidadUsuario entidadUsuario)
        {
            try
            {
                clsUsuariosAD objRN = new clsUsuariosAD();
                return objRN.RecuperarContraseña(entidadUsuario);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        
    }
}
