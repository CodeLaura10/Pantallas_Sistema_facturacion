using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCategoria
{
    public partial class FrmInsertarProductos : Form
    {
        public FrmInsertarProductos()
        {
            InitializeComponent();
        }
        public int Id_Producto { get; set; }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Actualizado");
            this.Close();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmInsertarProductos_Load(object sender, EventArgs e)
        {
            if (Id_Producto == 0)
            {
                LblTituloProducto.Text = "Nuevo Producto";
            }
            else
            {
                LblTituloProducto.Text = "Editar Producto";
                TxTId_Producto.Text = Id_Producto.ToString();
            }
        }

        private void LblPrecioCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
