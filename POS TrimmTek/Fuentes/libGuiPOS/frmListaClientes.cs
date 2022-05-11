using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libEntidades;
using libInterfaz;


namespace libGuiPOS
{
    public partial class frmListaClientes : Form
    {
        clsPosAPI objApi = new clsPosAPI();
        clsUtilidades objUtilidades = new clsUtilidades();
        private clsEntidadUsuario entidadUsuario = new clsEntidadUsuario();

        #region [Mover Formularios]
        //Importación de 2 Dlls de Windows que contienen los metodos para mover los formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public frmListaClientes()
        {
            InitializeComponent();
        }

        public clsEntidadUsuario EntidadUsuario
        {
            get { return entidadUsuario; }
            set { entidadUsuario = value; }
        }

        #region [Métodos Públicos]

        private void ListarClientes()
        {
            try
            {
                EntidadUsuario.IdUsuario = "";
                EntidadUsuario.nombre = "";
                EntidadUsuario.email = "";
                EntidadUsuario.tipouser = 12;

                //Este datatable lista los usuarios de la base de datos que son de tipo cliente
                DataTable dtListarUsuarios = new DataTable();

                dtListarUsuarios = objApi.UsuariosCrud("LISTAUSUARIOS", EntidadUsuario);

                if (dtListarUsuarios.Rows.Count > 0)
                {
                    if (dtListarUsuarios.Rows[0]["SW"].ToString() == "0")
                    {
                        objUtilidades.CargarGrid(dbgClientes, dtListarUsuarios);
                        dbgClientes.Splits[0].DisplayColumns["SW"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["Id"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["Celular"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["Fijo"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["FechaNacimiento"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["Email"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["DirResidencia"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["Estado"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["Perfil"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["TipoUsuario"].Visible = false;
                        dbgClientes.Splits[0].DisplayColumns["Autorizador"].Visible = false;

                        return;
                    }
                    
                }

                MessageBox.Show("No hay registros para mostrar", "Sistema POS", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region [Eventos]
        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void dbgClientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EntidadUsuario.IdUsuario = dbgClientes.Columns["Identificacion"].Text;
                EntidadUsuario.nombre = dbgClientes.Columns["Nombre"].Text;
                this.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelClientes_MouseDown(object sender, MouseEventArgs e)
        {
            //Metodos para mover los formularios
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

     
    }
}
