using Entidad;
using Negocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void ValidarCredenciales()
        {
            try
            {
                Usuario usuario = new N_Usuario().Validar().Where(u => u.NombreUsuario == txtUsuario.Text
                && u.Contraseña == txtContraseña.Text).FirstOrDefault();

                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("El campo del nombre de usuario está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("El campo de contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                }
                else
                {
                    if (usuario != null)
                    {
                        if (usuario.Estado == false)
                        {
                            MessageBox.Show("Este usuario se encuentra Inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (usuario.TipoUsuario == "Administrador")
                            {
                                this.Hide();
                                FrmPanelAdministrador panelAdministrador = new FrmPanelAdministrador();
                                panelAdministrador.Show();

                            }
                            if (usuario.TipoUsuario == "Cliente")
                            {
                                this.Hide();
                                FrmPanelCompra panelCliente = new FrmPanelCompra(usuario);
                                panelCliente.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas, verifique e intentelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            ValidarCredenciales();
        }

        private void FromLogin_FormClosing(object sender, FormClosingEventArgs e)
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
