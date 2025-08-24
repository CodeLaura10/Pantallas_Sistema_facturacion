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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 3; i++)
            {
                DGCategoria.Rows.Add(i, $"Categoria {i} ", $"Descripción Categoria {i} ");
            }

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            llenar_grid();

        }

        private void labelproductos_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarCategoria Categoria = new FrmInsertarCategoria();
            Categoria.Id_Categoria = 0;
            Categoria.ShowDialog();
        }

        private void DGCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGCategoria.Columns["BtnEditar"].Index && e.RowIndex >= 0)
            {
                int id_categoria = Convert.ToInt32(DGCategoria.Rows[e.RowIndex].Cells["Id_Categoria"].Value);
                FrmInsertarCategoria Categoria = new FrmInsertarCategoria();
                Categoria.Id_Categoria = id_categoria;
                Categoria.ShowDialog();
            }
            if (e.ColumnIndex == DGCategoria.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                int id_categoria = Convert.ToInt32(DGCategoria.Rows[e.RowIndex].Cells["Id_Categoria"].Value);
                var result = MessageBox.Show($"¿Está seguro de eliminar la categoría con ID {id_categoria}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Aquí iría el código para eliminar la categoría de la base de datos
                    MessageBox.Show($"Categoría con ID {id_categoria} eliminada.");
                    DGCategoria.Rows.RemoveAt(e.RowIndex); // Elimina la fila del DataGridView
                }
            }
        }


    }
}

