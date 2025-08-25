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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        public void llenar_grid()
        {
            for (int i = 1; i < 6; i++)
            {
                DGProductos.Rows.Add(i, $"Producto {i} ", $"Categoria {i} ", $"{i * 10000}", $"{i * 5}");
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGProductos.Columns["BtnEditar"].Index && e.RowIndex >= 0)
            {
                int id_producto = Convert.ToInt32(DGProductos.Rows[e.RowIndex].Cells["Id_Producto"].Value);
                FrmInsertarProductos Producto = new FrmInsertarProductos();
                Producto.Id_Producto = id_producto;
                Producto.ShowDialog();
            }
            if (e.ColumnIndex == DGProductos.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                int id_producto = Convert.ToInt32(DGProductos.Rows[e.RowIndex].Cells["Id_Producto"].Value);
                var result = MessageBox.Show($"¿Está seguro de eliminar el producto con ID {id_producto}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Aquí iría el código para eliminar al cliente de la base de datos
                    MessageBox.Show($"Producto con ID {id_producto} eliminado.");
                    DGProductos.Rows.RemoveAt(e.RowIndex); // Elimina la fila del DataGridView
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarProductos Producto = new FrmInsertarProductos();
            Producto.Id_Producto = 0;
            Producto.ShowDialog();
        }
    }
}
