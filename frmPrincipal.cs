using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using Pantallas_Sistema_facturacion.Seguridad;
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
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private Form _formActualSeg;  // guarda el último form embebido

        private void AbrirEnPanel(Form frm, Panel contenedor)
        {
            // Cierra y libera el anterior (si existía)
            if (_formActualSeg != null)
            {
                try { _formActualSeg.Close(); _formActualSeg.Dispose(); } catch { /* noop */ }
                _formActualSeg = null;
            }

            // Configura el form para usarlo como control embebido
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Limpia y agrega
            contenedor.Controls.Clear();
            contenedor.Controls.Add(frm);
            contenedor.Tag = frm;

            _formActualSeg = frm;
            frm.Show();   // ¡Importante! NO uses ShowDialog aquí.
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

        private void btnSeguridad_Click(object sender, EventArgs e)
        {

        }

        private void seguridad_Click(object sender, EventArgs e)
        {

        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new frmEmpleados(), pnlEmpleados);
        }

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            AbrirEnPanel(new frmRoles(), pnlEmpleados);
        }
    }
}