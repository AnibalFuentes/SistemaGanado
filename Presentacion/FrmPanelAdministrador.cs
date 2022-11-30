using Entidad;
using Negocio;
using Presentacion.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPanelAdministrador : Form
    {
        public FrmPanelAdministrador()
        {
            InitializeComponent();
        }

        Ganado ganado = new Ganado();

        private void Calcular()
        {
            try
            {
                decimal total = 0;

                foreach (DataGridViewRow row in GrillaGanados.Rows)
                {                   
                    if (Convert.ToBoolean(row.Cells["EstadoValor"].Value) == false)
                    {
                        total += Convert.ToDecimal(row.Cells["PrecioVenta"].Value.ToString());
                        lblGanancias.Text = "$" + total;
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LLenarDatos()
        {      

            txtIdGanado.Text = "0";
            txtIndice.Text = "-1";

            boxRaza.Items.Add(new OpcionComboBox() { valor = 1, texto = "Brahaman Rojo" });
            boxRaza.Items.Add(new OpcionComboBox() { valor = 2, texto = "Brahaman Blanco" });
            boxRaza.Items.Add(new OpcionComboBox() { valor = 3, texto = "Gyr" });
            boxRaza.Items.Add(new OpcionComboBox() { valor = 4, texto = "Guzera" });
            boxRaza.DisplayMember = "Texto";
            boxRaza.ValueMember = "valor";
            boxRaza.SelectedIndex = 0;

            boxSexo.Items.Add(new OpcionComboBox() { valor = 1, texto = "Macho" });
            boxSexo.Items.Add(new OpcionComboBox() { valor = 2, texto = "Hembra" });
            boxSexo.DisplayMember = "Texto";
            boxSexo.ValueMember = "valor";
            boxSexo.SelectedIndex = 0;

            N_Ganado negocioGanado = new N_Ganado();
            List<Ganado> ganados = negocioGanado.Listar();

            //Llenar tabla
            foreach (var g in ganados)
            {
                this.GrillaGanados.Rows.Add(new object[] {"", g.IdGanado, g.Referencia, g.Raza,
                g.Sexo, g.Peso, g.MesesRecuperacion, g.PrecioVenta, g.PrecioCompra, g.PesoVenta,
                    g.FechaRegistro, g.Estado == true ? "Disponible" : "Vendido", g.Estado == true ? 1 : 0 });
            }
            Calcular();
        }

        private void RegistrarGanado()
        {
            string mensaje = string.Empty;

            ganado = new Ganado()
            {
                IdGanado = Convert.ToInt32(txtIdGanado.Text),
                Referencia = txtReferencia.Text,
                Raza = boxRaza.Text,
                Sexo = boxSexo.Text,
                MesesRecuperacion = Convert.ToInt32(txtMesesRecup.Text),
                Peso = Convert.ToDecimal(txtPeso.Text),
                Estado = true
            };

            ganado.CalcularPesoVenta();
            ganado.CalcularPrecioCompra();
            ganado.CalcularPrecioVenta();

            if (ganado.IdGanado == 0)
            {

                DialogResult dialogo = MessageBox.Show("¿Desea agregar este nuevo Ganado?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Registrar
                    N_Ganado n_Ganado = new N_Ganado();
                    int IdGanadoGenerado = n_Ganado.Registrar(ganado, out mensaje);

                    if (IdGanadoGenerado != 0)
                    {
                        string estado = "";
                        if (ganado.Estado) { estado = "Disponible"; } else { estado = "Vendido"; }

                        GrillaGanados.Rows.Add(new object[]
                        {
                            "",
                            IdGanadoGenerado,
                            txtReferencia.Text,
                            ganado.Raza,
                            ganado.Sexo,
                            ganado.Peso,
                            ganado.MesesRecuperacion,
                            ganado.PesoVenta,
                            ganado.PrecioCompra,
                            ganado.PrecioVenta,
                            Estado,
                            estado,
                        });

                        Limpiar();
                        MessageBox.Show("Ganado agregado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Limpiar()
        {
            txtReferencia.Text = "";
            boxRaza.Text = "";
            boxSexo.Text = "";
            txtPeso.Text = "";
            txtPrecioCompra.Text = "";
            txtMesesRecup.Text = "";
            txtPesoVenta.Text = "";
            txtPrecioVenta.Text = "";
        }

        private void FrmPanelAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { e.Cancel = true; }
            else
            {
                e.Cancel = false; Environment.Exit(1);
            }
        }

        private void FrmPanelAdministrador_Load(object sender, EventArgs e)
        {
            LLenarDatos();
        }

        private void GrillaGanados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var w = Resources.borrar.Width;
                    var h = Resources.borrar.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                    e.Graphics.DrawImage(Resources.borrar, new Rectangle(x, y, w, h));
                    e.Handled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrillaGanados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GrillaGanados.Columns[e.ColumnIndex].Name == "Borrar")
                {

                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {
                        if (e.RowIndex < 0)
                            return;
                        if (e.ColumnIndex == 0)
                        {
                            txtIndice.Text = indice.ToString();
                            txtIdGanado.Text = GrillaGanados.Rows[indice].Cells["IdGanado"].Value.ToString();

                            if (Convert.ToInt32(txtIdGanado.Text) != 0)
                            {
                                string mensaje = string.Empty;

                                DialogResult dialogo = MessageBox.Show("¿Desea eliminar este ganado?",
                                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogo == DialogResult.No) { }
                                else
                                {
                                    Ganado gn = new Ganado()
                                    {
                                        IdGanado = Convert.ToInt32(txtIdGanado.Text)
                                    };

                                    bool respuesta = new N_Ganado().Eliminar(gn, out mensaje);

                                    if (respuesta)
                                    {
                                        GrillaGanados.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                                        txtIdGanado.Text = "0";
                                        txtIndice.Text = "-1";

                                        MessageBox.Show("Ganado eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            RegistrarGanado();
        }

        private void txtMesesRecup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ganado.IdGanado = Convert.ToInt32(txtIdGanado.Text);
                ganado.Referencia = txtReferencia.Text;
                ganado.Raza = boxRaza.Text;
                ganado.Sexo = boxSexo.Text;
                ganado.MesesRecuperacion = Convert.ToInt32(txtMesesRecup.Text);
                ganado.Peso = Convert.ToDecimal(txtPeso.Text);
                ganado.Estado = true;

                txtPrecioCompra.Text = ganado.CalcularPrecioCompra().ToString();
                txtPrecioVenta.Text = ganado.CalcularPrecioVenta().ToString();
                txtPesoVenta.Text = ganado.CalcularPesoVenta().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtConsultar.Text != "")
            {
                //Tabla
                GrillaGanados.CurrentCell = null;

                foreach (DataGridViewRow row in GrillaGanados.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in GrillaGanados.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value.ToString().ToUpperInvariant().IndexOf(txtConsultar.Text.ToUpperInvariant()) == 0))
                        {
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in GrillaGanados.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

