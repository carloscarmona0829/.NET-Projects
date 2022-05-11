using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libEntidades;


namespace libGuiPOS
{
    public partial class MdiPrincipal : Form
    {
        clsUtilidades objUtilidades = new clsUtilidades();

        public MdiPrincipal()
        {
            InitializeComponent();
        }

        #region [Eventos]

        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
            //Cargar Imágenes a los Picture Box desde una ruta específica definida como key en el appSettings de la aplicación
            pbLogo.ImageLocation = System.Configuration.ConfigurationManager.AppSettings["imgLogo"].ToString();
            pbBanner.ImageLocation = System.Configuration.ConfigurationManager.AppSettings["imgBanner"].ToString();

            //Valida los pemisos del usuario para mostrar el menú
            DataTable dtCargarMenu = new DataTable();

            dtCargarMenu = clsEntidadAutenticacion.dtCargarMenuPrincipal;

            if (dtCargarMenu == null || dtCargarMenu.Rows.Count == 0)
            {
                MessageBox.Show("El usuario no tiene permisos para ingresar esta aplicación.", "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblUsuarioLogueado.Text = (dtCargarMenu.Rows[0]["NombreUsuario"].ToString());

            foreach (ToolStripMenuItem tsmi in mnuPrincipal.Items)
                objUtilidades.CargarMenuPrincipal(tsmi, dtCargarMenu);
        }

        private void tsmUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios FormUsuarios = new frmUsuarios();
            FormUsuarios.MdiParent = this;
            FormUsuarios.Show();
        }

        private void tsmPerfiles_Click(object sender, EventArgs e)
        {
            frmPerfiles FormPerfiles = new frmPerfiles();
            FormPerfiles.MdiParent = this;
            FormPerfiles.Show();
        }

        private void tsmPermisos_Click(object sender, EventArgs e)
        {
            frmPermisosAPerfil FormPermisosAPerfil = new frmPermisosAPerfil();
            FormPermisosAPerfil.MdiParent = this;
            FormPermisosAPerfil.Show();
        }

        private void tsmModulos_Click(object sender, EventArgs e)
        {
            frmModulos ForModulos = new frmModulos();
            ForModulos.MdiParent = this;
            ForModulos.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmProductos_Click(object sender, EventArgs e)
        {
            frmProductos FormProductos = new frmProductos();
            FormProductos.MdiParent = this;
            FormProductos.Show();
        }

        private void tsCierre_Click(object sender, EventArgs e)
        {
            frmCierre FormCierre = new frmCierre();
            FormCierre.MdiParent = this;
            FormCierre.Show();
        }

        private void tsmTurnos_Click(object sender, EventArgs e)
        {
            frmTurnos FormTurnos = new frmTurnos();
            FormTurnos.MdiParent = this;
            FormTurnos.Show();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }

        private void tsNomina_Click(object sender, EventArgs e)
        {
            frmNomina formNomina = new frmNomina();
            formNomina.MdiParent = this;
            formNomina.Show();
        }

        private void tsbFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion formFacturacion = new frmFacturacion();
            formFacturacion.MdiParent = this;
            formFacturacion.Show();
        }

        private void lblCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void tsmventasProductos_Click(object sender, EventArgs e)
        {
            frmVentasProductos formVentasProductos = new frmVentasProductos();
            formVentasProductos.MdiParent = this;
            formVentasProductos.Show();
        }

        private void tsmProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores formProveedores = new frmProveedores();
            formProveedores.MdiParent = this;
            formProveedores.Show();
        }

        private void tsbInventario_Click(object sender, EventArgs e)
        {
            frmInventario FormInventario = new frmInventario();
            FormInventario.MdiParent = this;
            FormInventario.Show();
        }

        private void tsmPersonas_Click(object sender, EventArgs e)
        {
            libGuiPOS.Registros.frmPersonasIngreso frmPersonas = new libGuiPOS.Registros.frmPersonasIngreso();
            frmPersonas.MdiParent = this;
            frmPersonas.Show();
        }

        private void tsmCasas_Click(object sender, EventArgs e)
        {
            Registros.frmCasas FormCasas = new Registros.frmCasas();
            FormCasas.MdiParent = this;
            FormCasas.Show();
        }

        private void tsmRegistro_Click(object sender, EventArgs e)
        {
            Registros.frmRegistro FormRegistro = new Registros.frmRegistro();
            FormRegistro.MdiParent = this;
            FormRegistro.Show();
        }


        #endregion

       
    }
}
