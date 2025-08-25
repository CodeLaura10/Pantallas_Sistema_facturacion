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
            "Versión: 12.1.0\n" +
            "Desarrollado por: Grupo 7\n" +
            "Fecha: Agosto 2025\n\n" +

            "ℹ️ Descripción:\n" +
            "Este sistema de facturación ha sido diseñado para apoyar a las pequeñas y medianas empresas " +
            "en la gestión de sus procesos contables y administrativos. \n\n" +

            "🔹 Funcionalidades principales:\n" +
            " - Registro y control de clientes.\n" +
            " - Creación y administración de facturas.\n" +
            " - Generación de reportes e informes financieros.\n" +
            " - Módulo de ayuda en línea para soporte al usuario.\n\n" +

            "👨‍💻 Objetivo:\n" +
            "Facilitar la organización de la información contable y mejorar la eficiencia " +
            "en la toma de decisiones empresariales mediante un sistema ágil, seguro y fácil de usar.\n\n" +

            "© 2025 Grupo7. Todos los derechos reservados";

        }
    }
}
