using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using Microsoft.Web.WebView2.WinForms;






namespace Pantallas_Sistema_facturacion
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Click(object sender, EventArgs e)
        {


        }


        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturas fFacturas = new frmFacturas();
            fFacturas.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Informes_Click(object sender, EventArgs e)
        {

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes fInformes = new frmInformes();
            fInformes.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda Frmayuda = new frmAyuda();
            Frmayuda.ShowDialog();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcerca Frmacerca = new frmAcerca();
            Frmacerca.ShowDialog();
        }
        }
    }
}