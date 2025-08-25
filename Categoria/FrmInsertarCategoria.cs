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
    public partial class FrmInsertarCategoria : Form
    {
        public FrmInsertarCategoria()
        {
            InitializeComponent();

        }

        public int Id_Categoria { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Id_Categoria == 0)
            {
                LblTituloCategoria.Text = "Nueva Categoria";
            }
            else
            {
                LblTituloCategoria.Text = "Editar Categoria";
                TxTId_Categoria.Text = Id_Categoria.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Categoria Actualizada");
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxTId_Categoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescripciónCategoria_Click(object sender, EventArgs e)
        {

        }

        private void NombreCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
