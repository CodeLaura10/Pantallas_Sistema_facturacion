using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class FrmLogin : Form
    {
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
            string Respuesta = string.Empty; //variable para saber si encontro el usuario en la BD 
            if (txtUsuario.Text != "" && txtContraseña.Text != string.Empty) // verifico que Usuario y Contraseña sean ingresados
            {
                if (txtUsuario.Text == "admin" && txtContraseña.Text == "123") // verifico si el usuario y contraseña son correctos
                {
                    Respuesta = "OK"; // si es correcto, asigno OK a la variable Respuesta
                    MessageBox.Show("Bienvenido al sistema de facturación"); // muestro un mensaje de bienvenida al usuario
                    frmPrincipal frmppal = new frmPrincipal();
                    this.Hide(); // oculto el formulario de login
                    frmppal.ShowDialog(); // muestro el formulario principal
                }
                else
                {
                    Respuesta = "Usuario o Contraseña incorrectos"; // si no es correcto, asigno un mensaje de error a la variable Respuesta
                }
                if (Respuesta == "OK") // si la respuesta es OK, cierro el formulario de login y muestro el formulario principal
                {
                    this.DialogResult = DialogResult.OK; // Indica que el login fue exitoso
                    this.Close(); // Cierra el formulario de login
                }
                else
                {
                    MessageBox.Show(Respuesta); // Si no es OK, muestro el mensaje de error
                }


            }
        }
    }
}
