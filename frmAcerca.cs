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
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void frmAcerca_Load(object sender, EventArgs e)
        {

            // Desactivar edición en el RichTextBox
            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.None;

            // Texto de información
            richTextBox1.Text =
                "📌 Sistema de Facturación\n\n" +
                "Versión: 1.0.0\n" +
                "Desarrollado por: [Nombre de tu empresa]\n" +
                "Fecha: Agosto 2025\n" +
                "Descripción: Este sistema permite gestionar facturación, informes y reportes de manera eficiente.";


        }
    }
}
