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

//<<<<<<< prueba-categoria
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmclientes = new FrmClientes();
            frmclientes.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmproductos = new FrmProductos();
            frmproductos.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frmproductos = new FrmCategorias();
            frmproductos.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabOpcionesMenu_Click(object sender, EventArgs e)
        {
        }
//=======
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            // Limpia lo que haya en el panel
            panelContenedor.Controls.Clear();

            // Instancia el formulario hijo
            frmAyuda frm = new frmAyuda();
            frm.TopLevel = false;                       // <- Importante para que sea "control"
            frm.FormBorderStyle = FormBorderStyle.None; // <- Sin borde
            frm.Dock = DockStyle.Fill;                  // <- Que ocupe todo el panel

            // Agrega el formulario al panel
            panelContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            // Limpia lo que haya en el panel
            panelContenedor.Controls.Clear();

            // Instancia el formulario hijo
            frmAcerca frm = new frmAcerca();
            frm.TopLevel = false;                       // <- Importante para que sea "control"
            frm.FormBorderStyle = FormBorderStyle.None; // <- Sin borde
            frm.Dock = DockStyle.Fill;                  // <- Que ocupe todo el panel

            // Agrega el formulario al panel
            panelContenedor.Controls.Add(frm);
            frm.Show();
//>>>>>>> main

        }
    }
}