using System;
using System.Windows.Forms;
using Capa_Negocio;

namespace Pantallas_Sistema_facturacion
{
    public partial class FrmLogin : Form
    {
        BLLLogin login = new BLLLogin();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbnValidar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (login.Login(usuario, contraseña))
            {
                MessageBox.Show("✅ Login exitoso. Bienvenido " + usuario);
                new frmPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
