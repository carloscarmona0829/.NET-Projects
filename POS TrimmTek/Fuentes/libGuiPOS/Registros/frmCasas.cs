using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libEntidades.clsEntidadesregvis;
using libInterfaz;
using System.Runtime.InteropServices;

namespace libGuiPOS.Registros
{
    public partial class frmCasas : Form
    {
        clsPosAPI objApi = new clsPosAPI();

        public frmCasas()
        {
            InitializeComponent();
        }

        #region [Métodos]

        public void CargarDatosCasas()
        {
            dtcasas.DataSource = objApi.ConsultarTodosCasa();
            dtcasas.Columns["CasaId"].Visible = false;
            dtcasas.Refresh();
        }

        public void LimpiarDatos()
        {
            lblcasaid.Text = "";
            txtcedula.Text = "";
            txtnumerocasa.Text = "";
            txtnombrepropietario.Text = "";
            txtnombrebusqueda.Text = "";
            txtnumerocasabusqueda.Text = "";
            tsbNuevo.Visible = true;
            tsbGuardar.Visible = true;
            tsbActualizar.Visible = true;
            tsbEliminar.Visible = true;
            tsbConsultar.Visible = true;
            txtcedula.Focus();
        }

        public void GuardarDatos()
        {
            try
            {
                libEntidades.Entidadesregvis.clsEntidadCasas casas = new libEntidades.Entidadesregvis.clsEntidadCasas();
                string result = string.Empty;

                if (string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtnumerocasa.Text) || string.IsNullOrEmpty(txtnombrepropietario.Text))
                {
                    MessageBox.Show("Faltan campos por llenar, por favor verifique que todos los campos", "Sistema REG", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
                else
                {
                    //Guarda Casas
                    casas.Cedula = Convert.ToInt32(txtcedula.Text.Trim()); ;
                    casas.NumeroCasa = Convert.ToString(txtnumerocasa.Text.Trim());
                    casas.NombrePropietario = Convert.ToString(txtnombrepropietario.Text);
                    result = objApi.GuardarCasasregvis(casas);
                    MessageBox.Show(result, "Sistema REG", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    LimpiarDatos();
                    CargarDatosCasas();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void ActualizarDatos()
        {
            try
            {
                libEntidades.Entidadesregvis.clsEntidadCasas casas = new libEntidades.Entidadesregvis.clsEntidadCasas();
                string result = string.Empty;

                if (string.IsNullOrEmpty(lblcasaid.Text))
                {
                    MessageBox.Show("Debe consultar primero para actualizar", "Sistema REG", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtnombrepropietario.Text) || string.IsNullOrEmpty(txtnumerocasa.Text))
                    {
                        MessageBox.Show("Faltan campos por llenar, por favor verifique que todos los campos", "Sistema REG", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Actualiza Casas
                        casas.Cedula = Convert.ToInt32(txtcedula.Text.Trim());
                        casas.NumeroCasa = Convert.ToString(txtnumerocasa.Text.Trim());
                        casas.NombrePropietario = Convert.ToString(txtnombrepropietario.Text.Trim());
                        result = objApi.ActualizarCasasregvis(casas, Convert.ToInt32(lblcasaid.Text));
                        MessageBox.Show(result, "Sistema REG", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        LimpiarDatos();
                        CargarDatosCasas();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void EliminarDatos()
        {
            try
            {
                string result = string.Empty;

                if (string.IsNullOrEmpty(lblcasaid.Text))
                {
                    MessageBox.Show("Debe consultar primero para eliminar", "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    //Elimina Casas
                    result = objApi.EliminarCasaregvis(lblcasaid.Text);
                    CargarDatosCasas();
                    MessageBox.Show(result, "Sistema REG", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void BusquedaPropietario()
        {
            DataTable dt = new DataTable();

            if (txtnombrebusqueda.Text != "")
            {
                dt = objApi.ConsultarCasaNombre(txtnombrebusqueda.Text);

                if (dt.Rows.Count > 0)
                {
                    dtcasas.DataSource = dt;
                    dtcasas.Refresh();
                }
                else
                {
                    MessageBox.Show("No existe casa para " + txtnombrebusqueda.Text + " registrada en la base de datos", "Sistema REG", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
            }
        }

        public void BusquedaCasa()
        {
            DataTable dt = new DataTable();

            if (txtnumerocasabusqueda.Text != "")
            {
                dt = objApi.ConsultarCasaNumero(txtnumerocasabusqueda.Text);

                if (dt.Rows.Count > 0)
                {
                    dtcasas.DataSource = dt;
                    dtcasas.Refresh();
                }
                else
                {
                    MessageBox.Show("No existe casa para " + txtnumerocasabusqueda.Text + " registrada en la base de datos", "Sistema REG", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        #region [Eventos]

        private void frmCasas_Load(object sender, EventArgs e)
        {
            CargarDatosCasas();
            LimpiarDatos();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            CargarDatosCasas();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
   if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            CargarDatosCasas();
        }

        private void dtcasas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                //if (dtcasas.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                //{
                if (dtcasas.CurrentCell != null && dtcasas.CurrentCell.Value != null)
                {

                    var casaid = dtcasas.Rows[e.RowIndex].Cells[0].Value;
                    lblcasaid.Text = casaid.ToString();
                    dt = objApi.ConsultarCasaModificar(lblcasaid.Text);

                    if (dt.Rows.Count > 0)
                    {
                        lblcasaid.Text = dt.Rows[0]["CasaId"].ToString();
                        txtcedula.Text = dt.Rows[0]["Cedula"].ToString();
                        txtnumerocasa.Text = dt.Rows[0]["NumeroCasa"].ToString();
                        txtnombrepropietario.Text = dt.Rows[0]["NombrePropietario"].ToString();
                        tsbGuardar.Visible = false;
                        tsbNuevo.Visible = true;
                        tsbActualizar.Visible = true;
                        tsbConsultar.Visible = false;
                        tsbEliminar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No existe cedula registrada en la base de datos", "Sistema REG", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //Consulta casas
                if (txtnumerocasabusqueda.Text == "" && txtnombrebusqueda.Text == "")
                {
                    txtnumerocasabusqueda.Focus();
                    MessageBox.Show("Debe digitar un parámetro de búsqueda ", "Sistema REG", MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                }
                if (txtnumerocasabusqueda.Text != "" && txtnombrebusqueda.Text != "")
                {
                    MessageBox.Show("Debe seleccionar solo un parámetro de busqueda", "Sistema REG", MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);

                }
                else if (txtnumerocasabusqueda.Text != "")
                {
                    BusquedaCasa();
                }
                else
                {
                    BusquedaPropietario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema REG", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
            }

        }      

        private void txtnumerocasabusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BusquedaCasa();
            }
        }

        private void txtnumerocasabusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            //Permitir teclas de control como retroceso
           if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                //El resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtnombrebusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BusquedaPropietario();
            }
        }

        #endregion        
    }
}
