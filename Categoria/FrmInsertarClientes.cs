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
    public partial class FrmInsertarClientes : Form
    {
        public FrmInsertarClientes()
        {
            InitializeComponent();
        }
        public int IdCliente { get; set; }

        private void FrmInsertarClientes_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                LblTituloCliente.Text = "Nuevo Cliente";
            }
            else
            {
                LblTituloCliente.Text = "Editar Cliente";
                TxTId_Cliente.Text = IdCliente.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Actualizado");
            this.Close();
        }
    }
}
