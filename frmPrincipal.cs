using FrmCategoria;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using Microsoft.Web.WebView2.WinForms;
using Pantallas_Sistema_facturacion;






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

        private void btnClientes_Click(object sender, EventArgs e)
        {

            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmproductos = new FrmProductos();
            frmproductos.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabOpcionesMenu_Click(object sender, EventArgs e)
        {
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda FrmAyuda = new frmAyuda();
            FrmAyuda.ShowDialog();

        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcerca FrmAcerca= new frmAcerca();
            FrmAcerca.ShowDialog();

        }
    }
}