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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGClientes.Columns["BtnEditar"].Index && e.RowIndex >= 0)
            {
                int id_cliente = Convert.ToInt32(DGClientes.Rows[e.RowIndex].Cells["Id_Cliente"].Value);
                FrmInsertarClientes Cliente = new FrmInsertarClientes();
                Cliente.Id_Cliente = id_cliente;
                Cliente.ShowDialog();
            }
            if (e.ColumnIndex == DGClientes.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                int id_cliente = Convert.ToInt32(DGClientes.Rows[e.RowIndex].Cells["Id_Cliente"].Value);
                var result = MessageBox.Show($"¿Está seguro de eliminar al cliente con ID {id_cliente}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Aquí iría el código para eliminar al cliente de la base de datos
                    MessageBox.Show($"Cliente con ID {id_cliente} eliminada.");
                    DGClientes.Rows.RemoveAt(e.RowIndex); // Elimina la fila del DataGridView
                }
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FrmInsertarClientes Cliente = new FrmInsertarClientes();
            Cliente.Id_Cliente = 0;
            Cliente.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click_3(object sender, EventArgs e)
        {

        }

        public void llenar_grid()
        {
            for (int i = 1; i < 3; i++)
            {
                DGClientes.Rows.Add(i, $"Nombre {i} Apellido1 Apellido 2 ", $"{i * 12345}", $"{i * 12345}");
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void labelcliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
