using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPanelCompra : Form
    {
        private static Usuario usuarioActual;
        Ganado ganado = new Ganado();
        public static string Ganancias = "";

        public FrmPanelCompra(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void FrmPanelCompra_Load(object sender, System.EventArgs e)
        {
            TxNomCliente.Text = usuarioActual.NombreCompleto.ToString();
            TxNombreUsuario.Text = usuarioActual.NombreUsuario.ToString();
            TxDocumentoCliente.Text = usuarioActual.Documento.ToString();
            LLenarDatos();
        }

        private void LLenarDatos()
        {
            N_Ganado ganadoImpl = new N_Ganado();
            List<Ganado> ganados = ganadoImpl.Listar();
            //Llenar tabla
            foreach (var item in ganados)
            {
                if (item.Estado == true)
                {
                    DatosGanados.Rows.Add(new object[] { item.Referencia, item.Sexo, item.Raza, item.Peso, item.PrecioVenta });
                }
                if(item.Estado == false)
                {
                    Ganancias = lblTotalPagar.Text;
                }
            }
        }

        private void CalcularTotal()
        {

            try
            {
                decimal total = 0;

                if (DatosCarrito.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DatosCarrito.Rows)
                    {
                        total += Convert.ToDecimal(row.Cells["PrecioVenta"].Value.ToString());
                    }

                    lblTotalPagar.Text = "$" + total.ToString("0.00");
                }
                else
                {
                    lblTotalPagar.Text = "$0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarGanado()
        {
            DatosCarrito.Rows.Add(new object[]
            {
                    txtReferencia.Text,
                    txtSexo.Text,
                    txtRaza.Text,
                    txtPeso.Text,
                    txtPrecioVenta.Text
            });

            referencia.Text = txtReferencia.Text;

            CalcularTotal();
        }

        private void DatosGanados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = e.RowIndex;
            int index_colum = e.ColumnIndex;

            if (index_row >= 0 && index_colum >= 0)
            {
                ganado = new Ganado()
                {
                    IdGanado = Convert.ToInt32(DatosGanados.Rows[index_row].Cells["_id"].Value.ToString()),
                    Raza = DatosGanados.Rows[index_row].Cells["_Raza"].Value.ToString(),
                    Sexo = DatosGanados.Rows[index_row].Cells["_Sexo"].Value.ToString(),
                    PesoVenta = Convert.ToDecimal(DatosGanados.Rows[index_row].Cells["_Peso"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(DatosGanados.Rows[index_row].Cells["_PrecioVenta"].Value.ToString()),
                };

                txtReferencia.Text = ganado.IdGanado.ToString();
                txtRaza.Text = ganado.Raza.ToString();
                txtSexo.Text = ganado.Sexo.ToString();
                txtPeso.Text = ganado.PesoVenta.ToString();
                txtPrecioVenta.Text = ganado.PrecioVenta.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarGanado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            N_Ganado ganadoImpl = new N_Ganado();
            List<Ganado> ganados = ganadoImpl.Listar();

            //Llenar tabla
            foreach (var item in ganados)
            {
                if (item.Estado == true)
                {
                    if (referencia.Text == item.Referencia)
                    {
                        item.Estado = false;
                        ganadoImpl.Editar(item, out string mensaje);
                        MessageBox.Show("Ganado comprado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatosCarrito.Controls.Clear();
                        break;
                    }
                }
            }

            DatosGanados.Rows.Clear();
            LLenarDatos();
        }

        private void FrmPanelCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
                "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { e.Cancel = true; }
            else
            {
                e.Cancel = false; Environment.Exit(1);
            }
        }
    }
}
