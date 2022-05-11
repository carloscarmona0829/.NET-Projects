using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1List;
using C1.Win.C1TrueDBGrid;
using System.Net.Mime;
using System.Collections;
using System.Net;   

namespace libGuiPOS
{
    public class clsUtilidades
    {
        #region [Atributos]

        private int Width;

        #endregion

        #region [Métodos Públicos]
        public void LlenarComboUnicoValor(C1.Win.C1List.C1Combo combobox, DataTable datatable, string Display, string Value)
        {
            try
            {
                combobox.DataSource = datatable;
                combobox.DisplayMember = Display;
                combobox.ValueMember = Value;
                combobox.Splits[0].DisplayColumns[Display].Width = combobox.Width;
                combobox.Splits[0].DisplayColumns[Value].Visible = false;
                combobox.MaxDropDownItems = 10;
                combobox.AutoCompletion = true;
                combobox.AutoDropDown = true;
                combobox.AutoSelect = true;
                combobox.LimitToList = true;

            }
            catch (Exception Error)
            {

                throw Error;
            }

        }

        public void LlenarComboOrganizadoOcultarId(C1.Win.C1List.C1Combo combobox, DataTable datatable, string Display, string Value)
        {
            Width = 0;
            combobox.DataSource = datatable;
            combobox.DisplayMember = Display;
            combobox.ValueMember = Value;
            foreach (DataColumn col in datatable.Columns)
            {
                combobox.Splits[0].DisplayColumns[col.ColumnName].AutoSize();

                if (col.ColumnName != Display)
                {
                    Width = Width + combobox.Splits[0].DisplayColumns[col.ColumnName].Width;
                }
            }
            combobox.Splits[0].DisplayColumns[Value].Visible = false;
            combobox.DropDownWidth = Width;
            combobox.MaxDropDownItems = 20;
            combobox.AutoCompletion = true;
            combobox.AutoDropDown = true;
            combobox.AutoSelect = true;
            combobox.LimitToList = true;
        }

        public void CargarGrid(C1.Win.C1TrueDBGrid.C1TrueDBGrid Grid, DataTable dtTable)
        {
            try
            {
                Grid.EditActive = false;
                Grid.DataSource = dtTable;
                Grid.Refresh();
                Grid.AlternatingRows = false;
                Grid.FilterBar = true;
                Grid.RowHeight = 25;
                Grid.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Custom;
                Grid.SelectedStyle.BackColor = Color.Gray;
                Grid.CaptionStyle.BackColor = Color.LightSlateGray;
                Grid.GroupStyle.BackColor = Color.LightSlateGray;
                Grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
                Grid.HighLightRowStyle.BackColor = Color.LightSteelBlue;
                Grid.HighLightRowStyle.ForeColor = Color.Black;
                Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
                Grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
                Grid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
                Grid.BorderStyle = BorderStyle.None;
                

                for (int i = 0;i < dtTable.Columns.Count;i++)
                {
                    Grid.Splits[0].DisplayColumns[dtTable.Columns[i].ColumnName].AutoSize();
                    if (Grid.Splits[0].DisplayColumns[dtTable.Columns[i].ColumnName].Width > 300)
                    {
                        Grid.Splits[0].DisplayColumns[dtTable.Columns[i].ColumnName].Width = 300;
                    }

                    Grid.Columns[dtTable.Columns[i].ColumnName].FilterDropdown = true;

                    if (Grid.Columns[dtTable.Columns[i].ColumnName].DataType.ToString() == "System.String")
                    {
                        Grid.Columns[dtTable.Columns[i].ColumnName].FilterOperator = "LIKE";
                        Grid.Columns[dtTable.Columns[i].ColumnName].FilterText = "%%";
                    }
                    Grid.Splits[0].DisplayColumns[dtTable.Columns[i].ColumnName].Locked = true;
                }
                Grid.EditActive = true;
                Grid.Visible = true;
                Grid.RowHeight = 25;
                Grid.DirectionAfterEnter = DirectionAfterEnterEnum.MoveDown;
                    
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarGridDesbloq(C1.Win.C1TrueDBGrid.C1TrueDBGrid Grid, DataTable dtTable)
        {
            try
            {
                Grid.EditActive = false;
                Grid.DataSource = dtTable;
                Grid.AlternatingRows = false;
                Grid.FilterBar = true;
                Grid.RowHeight = 25;
                Grid.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Custom;
                Grid.SelectedStyle.BackColor = Color.Gray;
                Grid.CaptionStyle.BackColor = Color.LightSlateGray;
                Grid.GroupStyle.BackColor = Color.LightSlateGray;
                Grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
                Grid.HighLightRowStyle.BackColor = Color.LightSteelBlue;
                Grid.HighLightRowStyle.ForeColor = Color.Black;
                Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
                Grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
                Grid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
                Grid.BorderStyle = BorderStyle.None;
                Grid.DirectionAfterEnter = DirectionAfterEnterEnum.MoveDown;
                

                foreach (DataColumn col in dtTable.Columns)
                {

                    Grid.Splits[0].DisplayColumns[col.ColumnName].AutoSize();
                    if (Grid.Splits[0].DisplayColumns[col.ColumnName].Width > 200)
                    {
                        Grid.Splits[0].DisplayColumns[col.ColumnName].Width = 200;
                    }

                    Grid.Columns[col.ColumnName].FilterDropdown = true;

                    if (Grid.Columns[col.ColumnName].DataType.ToString() == "System.String")
                    {
                        Grid.Columns[col.ColumnName].FilterOperator = "LIKE";
                        Grid.Columns[col.ColumnName].FilterText = "%%";
                    }
                }
                Grid.EditActive = true;
                Grid.Visible = true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarGridOcultaResultado(C1.Win.C1TrueDBGrid.C1TrueDBGrid Grid, DataTable dtTable)
        {
            try
            {
                Grid.EditActive = false;
                Grid.DataSource = dtTable;
                Grid.AlternatingRows = false;
                Grid.FilterBar = true;
                Grid.RowHeight = 25;
                Grid.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Custom;
                Grid.SelectedStyle.BackColor = Color.Gray;
                Grid.CaptionStyle.BackColor = Color.LightSlateGray;
                Grid.GroupStyle.BackColor = Color.LightSlateGray;
                Grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
                Grid.HighLightRowStyle.BackColor = Color.LightSteelBlue;
                Grid.HighLightRowStyle.ForeColor = Color.Black;
                Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
                Grid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
                Grid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
                Grid.DirectionAfterEnter = DirectionAfterEnterEnum.MoveDown;
                
                

                foreach (DataColumn col in dtTable.Columns)
                {
                    Grid.Splits[0].DisplayColumns[col.ColumnName].AutoSize();

                    if (Grid.Splits[0].DisplayColumns[col.ColumnName].Width > 300)
                    {
                        Grid.Splits[0].DisplayColumns[col.ColumnName].Width = 300;
                    }

                    Grid.Columns[col.ColumnName].FilterDropdown = true;

                    if (Grid.Columns[col.ColumnName].DataType.ToString() == "System.String")
                    {
                        Grid.Columns[col.ColumnName].FilterOperator = "LIKE";
                        Grid.Columns[col.ColumnName].FilterText = "%%";
                    }
                }

                Grid.Splits[0].DisplayColumns[0].Locked = true;
                Grid.Splits[0].DisplayColumns["SW"].Visible = false;
                Grid.EditActive = true;
                Grid.Visible = true;
                
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool EnviarEmailSinOutlook(string EmailEnvia, string EmialRecibe, string Subject, string Body, string Attach, string Dominio, string Contraseña)
        {
            //El correo y contraseña de (EmailEnvia, Contraseña) vienen desde la tabla tblParametros de la base de datos
            try
            {
                string[] correos;
                char[] JobSplit = new char[1];
                MailMessage messasge = new MailMessage();
                messasge.From = new MailAddress(EmailEnvia);
                JobSplit[0] = Convert.ToChar(";");
                correos = EmialRecibe.Split(JobSplit, 1000);
                foreach (string email in correos)
                {
                    messasge.To.Add(email);
                }
                messasge.Subject = Subject;
                messasge.Body = Body;
                if (!String.IsNullOrEmpty(Attach))
                {
                    Attachment Attachments = new Attachment(Attach);
                    messasge.Attachments.Add(Attachments);
                }
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(EmailEnvia, Contraseña);
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                //SMTP para hotmail
                //client.Host = "smtp.live.com";
                client.EnableSsl = true;
                client.Send(messasge);
                return true;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public void OcultarColumnasCombos(C1Combo Combo, DataTable dtFuenteCombo, string[] ColumnaVisible)
        {
            try
            {

                foreach (DataColumn Col in dtFuenteCombo.Columns)
                {
                    Combo.Splits[0].DisplayColumns[Col.ColumnName].Visible = false;
                }

                for (int i = 0; i < ColumnaVisible.Count(); i++)
                {
                    Combo.Splits[0].DisplayColumns[ColumnaVisible[i]].Visible = true;
                }

            }
            catch (Exception Error)
            {
                    
                throw Error;
            }
        }

        public bool PermitirSoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter) 
                {
                    return false;
                }
                return true;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public bool PermitirSoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                {
                    return false;
                }
                return true;
            }
            catch (Exception Error)
            {
                throw Error;
            }
        }

        public void CargarMenuPrincipal(ToolStripMenuItem ts, DataTable dtModulosMenu)
        {
            try
            {
                foreach (DataRow rows in dtModulosMenu.Rows)
                {
                    if (String.Equals(rows["Modulo"].ToString(), ts.Name))
                        ts.Visible = true;
                }

                foreach (ToolStripDropDownItem tsmi in ts.DropDown.Items)
                {
                    foreach (DataRow rows in dtModulosMenu.Rows)
                    {
                        if (String.Equals(rows["Modulo"].ToString(), tsmi.Name))
                            tsmi.Visible = true;
                    }
                }
               
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }

        public void FormatearNumeros(TextBox txtMonto)
        {
            try
            {
                double montoout = -1;

                if (!string.IsNullOrEmpty(txtMonto.Text))
                {
                    //if (txtMonto.Text.Contains(",") || txtMonto.Text.Contains(".") || txtMonto.Text.Contains("$"))
                    //{
                    //    txtMonto.Text = txtMonto.Text.Replace(",", "").Replace(".", "").Replace("$", "");
                    //}
                    
                    if (double.TryParse(txtMonto.Text, out montoout))
                    {
                        txtMonto.Text = montoout.ToString("#,##");
                        txtMonto.SelectionStart = txtMonto.Text.Length;
                    }
                    else
                    {
                        txtMonto.Text = txtMonto.Text.Substring(0, txtMonto.Text.Length - 1);
                        txtMonto.SelectionStart = txtMonto.Text.Length;
                    }
                }

            }
            catch (Exception Error)
            {

                throw Error;
            }
        }

        #endregion
    }
}
