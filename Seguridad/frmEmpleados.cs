using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmEmpleados : Form
    {
        // Fuente de datos para enlazar el DataGridView
        private readonly BindingSource _bs = new BindingSource();

        public frmEmpleados()
        {
            InitializeComponent();

            // Configuración básica del grid
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Asegura mapeos y que las columnas de acción sean botones
            AsegurarColumnas();

            // Enlaza el grid a la fuente
            dgvEmpleados.DataSource = _bs;

            // Eventos: el botón Buscar se cablea aquí (en el diseñador no está)
            btnBuscarEmpleados.Click += (_, __) => Cargar(txtBuscarEmpleados.Text?.Trim());

            // Enter en el cuadro de búsqueda para disparar la búsqueda
            txtBuscarEmpleados.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    Cargar(txtBuscarEmpleados.Text?.Trim());
                }
            };
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // Limpia el texto por defecto del campo de búsqueda
            txtBuscarEmpleados.Text = string.Empty;

            // Carga inicial: muestra todos los registros
            Cargar(null);
        }
        private void AsegurarColumnas()
        {
            // Mapea columnas de datos a las propiedades del modelo Empleado
                 
             
                var colId = dgvEmpleados.Columns["ID"];
                if (colId != null) colId.DataPropertyName = "Id";

                var colNombre = dgvEmpleados.Columns["CLIENTE"];
                if (colNombre != null) colNombre.DataPropertyName = "Nombre";

                var colDoc = dgvEmpleados.Columns["DOCUMENTO"];
                if (colDoc != null) colDoc.DataPropertyName = "Documento";

                var colTel = dgvEmpleados.Columns["TELEFONO"];
                if (colTel != null) colTel.DataPropertyName = "Telefono";

                var colCorreo = dgvEmpleados.Columns["CORREO"];
                if (colCorreo != null) colCorreo.DataPropertyName = "Correo";

                var colDir = dgvEmpleados.Columns["DIRECCION"];
                if (colDir != null) colDir.DataPropertyName = "Direccion";

                var colRol = dgvEmpleados.Columns["ROL"];
                if (colRol != null) colRol.DataPropertyName = "NombreRol";

            // Asegura que colEditar sea un botón con texto "Editar"
            var colEditar = dgvEmpleados.Columns["colEditar"];
            if (colEditar != null && colEditar.GetType() != typeof(DataGridViewButtonColumn))
            {
                int idx = colEditar.Index;
                dgvEmpleados.Columns.RemoveAt(idx);
                var btn = new DataGridViewButtonColumn
                {
                    Name = "colEditar",
                    HeaderText = "EDITAR",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvEmpleados.Columns.Insert(idx, btn);
            }
            else if (colEditar is DataGridViewButtonColumn btnE)
            {
                btnE.HeaderText = "EDITAR";
                btnE.Text = "Editar";
                btnE.UseColumnTextForButtonValue = true;
                btnE.Width = 90;
            }

            // Asegura que colBorrar sea un botón con texto "Borrar"
            var colBorrar = dgvEmpleados.Columns["colBorrar"];
            if (colBorrar != null && colBorrar.GetType() != typeof(DataGridViewButtonColumn))
            {
                int idx = colBorrar.Index;
                dgvEmpleados.Columns.RemoveAt(idx);
                var btn = new DataGridViewButtonColumn
                {
                    Name = "colBorrar",
                    HeaderText = "BORRAR",
                    Text = "Borrar",
                    UseColumnTextForButtonValue = true,
                    Width = 90
                };
                dgvEmpleados.Columns.Insert(idx, btn);
            }
            else if (colBorrar is DataGridViewButtonColumn btnB)
            {
                btnB.HeaderText = "BORRAR";
                btnB.Text = "Borrar";
                btnB.UseColumnTextForButtonValue = true;
                btnB.Width = 90;
            }
        }
        private void Cargar(string? filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                // Enlaza la lista maestra para reflejar altas/ediciones en vivo
                _bs.DataSource = EmpleadoDAO.ObtenerTodos();
            }
            else
            {
                // Aplica filtro por nombre (ignorando mayúsculas/minúsculas)
                _bs.DataSource = new BindingList<Empleado>(
                EmpleadoDAO.ObtenerTodos().Where(e =>
                e.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase)).ToList()
                );
            }
        }
        private void NuevoEmpleado()
        {
            using var dlg = new FrmEmpleadoEdit();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                var emp = dlg.ToEmpleado();   // ahora sí existe
                EmpleadoDAO.Guardar(emp, Environment.UserName);
                RefrescarConFiltroActual();
            }
        }
        private void EditarEmpleado(Empleado emp)
        {
            using var dlg = new FrmEmpleadoEdit(emp);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                var actualizado = dlg.ToEmpleado();
                actualizado.Id = emp.Id;      // conserva el Id original
                EmpleadoDAO.Guardar(actualizado, Environment.UserName);
                RefrescarConFiltroActual();
            }
        }
        private void BorrarEmpleado(Empleado emp)
        {
            var r = MessageBox.Show(
            $"¿Eliminar a {emp.Nombre}?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (r != DialogResult.Yes) return;

            try
            {
                // Intenta eliminar desde BD
                bool eliminado = EmpleadoDAO.Eliminar(emp.Id);

                if (eliminado)
                {
                    MessageBox.Show("Empleado eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarConFiltroActual();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefrescarConFiltroActual();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarConFiltroActual()
        {
            var filtro = string.IsNullOrWhiteSpace(txtBuscarEmpleados.Text)
                ? null
                : txtBuscarEmpleados.Text.Trim();

            Cargar(filtro);
        }

        // Handler del botón "Agregar cliente" (cableado en el diseñador)
        private void btnNuevoEmpleado_Click(object sender, EventArgs e) => NuevoEmpleado();

        // Handler del grid para botones Editar/Borrar (cableado en el diseñador)
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora encabezados o clics en columnas que no son de botón
            if (e.RowIndex < 0) return;
            var col = dgvEmpleados.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            if (col == null) return;

            // Obtiene el objeto enlazado a la fila
            var emp = dgvEmpleados.Rows[e.RowIndex].DataBoundItem as Empleado;
            if (emp == null) return;

            // Decide la acción según la columna
            if (col.Name == "colEditar")
                EditarEmpleado(emp);
            else if (col.Name == "colBorrar")
                BorrarEmpleado(emp);
        }

        // Evento del label generado por el diseñador (sin lógica)
        private void materialLabel1_Click(object sender, EventArgs e) { }
    }
}
