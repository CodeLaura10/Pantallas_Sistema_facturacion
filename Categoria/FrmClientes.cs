using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

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
                int idcliente = Convert.ToInt32(DGClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
                FrmInsertarClientes Cliente = new FrmInsertarClientes();
                Cliente.IdCliente = idcliente;
                Cliente.ShowDialog();
            }
            if (e.ColumnIndex == DGClientes.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                int idcliente = Convert.ToInt32(DGClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
                var result = MessageBox.Show($"¿Está seguro de eliminar al cliente con ID {idcliente}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Elimina el cliente de la base de datos
                    string connectionString = AppConfig.ConnString;
                    string query = "DELETE FROM TBLCLIENTES WHERE IdCliente = @IdCliente";
                    try
                    {
                        using (var conn = new SqlConnection(connectionString))
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdCliente", idcliente);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Cliente con ID {idcliente} eliminado.");
                        DGClientes.Rows.RemoveAt(e.RowIndex); // Elimina la fila del DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            Cliente.IdCliente = 0;
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
            // Usa la cadena de conexión desde AppConfig
            string connectionString = AppConfig.ConnString;
            string query = @"
                SELECT 
                    IdCliente,
                    StrNombre,
                    NumDocumento,
                    StrDireccion,
                    StrTelefono,
                    StrEmail,
                    DtmFechaModifica,
                    StrUsuarioModifica
                FROM TBLCLIENTES;";

            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.Fill(dt);
                }

                // Evita que el DataGridView genere columnas automáticamente:
                DGClientes.AutoGenerateColumns = false;

                // Asigna el origen de datos (las columnas vinculadas en el diseñador se llenarán)
                DGClientes.DataSource = dt;

                // Medida defensiva: oculta cualquier columna no deseada (si existiera)
                foreach (DataGridViewColumn col in DGClientes.Columns)
                {
                    if (col.Name != "IdCliente" &&
                        col.Name != "StrNombre" &&
                        col.Name != "NumDocumento" &&
                        col.Name != "StrTelefono" &&
                        col.Name != "BtnEditar" &&
                        col.Name != "BtnEliminar")
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxcliente_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxcliente.Text.Trim();

            // Si el filtro está vacío, muestra todos los clientes
            if (string.IsNullOrEmpty(filtro))
            {
                llenar_grid();
                return;
            }

            string connectionString = AppConfig.ConnString;
            string query = @"
                SELECT 
                    IdCliente,
                    StrNombre,
                    NumDocumento,
                    StrDireccion,
                    StrTelefono,
                    StrEmail,
                    DtmFechaModifica,
                    StrUsuarioModifica
                FROM TBLCLIENTES
                WHERE StrNombre LIKE @Filtro OR NumDocumento LIKE @Filtro;";

            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    conn.Open();
                    adapter.Fill(dt);
                }

                DGClientes.AutoGenerateColumns = false;
                DGClientes.DataSource = dt;

                foreach (DataGridViewColumn col in DGClientes.Columns)
                {
                    if (col.Name != "IdCliente" &&
                        col.Name != "StrNombre" &&
                        col.Name != "NumDocumento" &&
                        col.Name != "StrTelefono" &&
                        col.Name != "BtnEditar" &&
                        col.Name != "BtnEliminar")
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
