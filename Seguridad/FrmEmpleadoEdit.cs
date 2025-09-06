using System;
using System.Linq;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class FrmEmpleadoEdit : Form
    {
        private readonly Empleado _original;
        private readonly ErrorProvider errorProvider1;

        // Salida para el llamador
        public string Nombre => txtNombre.Text.Trim();
        public string Documento => txtDocumento.Text.Trim();
        public string Telefono => txtTelefono.Text.Trim();
        public string Correo => txtCorreo.Text.Trim();
        public string Direccion => txtDireccion.Text.Trim();

        // ⇩ Nuevo: del ComboBox de rol
        public int? IdRolEmpleado
        {
            get
            {
                var v = cboRol.SelectedValue;
                if (v == null || v == DBNull.Value) return null;
                return Convert.ToInt32(v);
            }
        }
        public string NombreRol => cboRol.Text?.Trim() ?? "";

        public FrmEmpleadoEdit()
        {
            InitializeComponent();

            errorProvider1 = new ErrorProvider { ContainerControl = this };

            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;

            txtDocumento.KeyPress += SoloNumeros_KeyPress;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;

            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarRoles();
            Shown += (_, __) => txtNombre.Focus();
        }

        private void CargarRoles()
        {
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.DataSource = RolesStore.GetAllNames(); 
        }


        public FrmEmpleadoEdit(Empleado existente) : this()
        {
            _original = existente;
            txtNombre.Text = existente.Nombre;
            txtDocumento.Text = existente.Documento;
            txtTelefono.Text = existente.Telefono;
            txtCorreo.Text = existente.Correo;
            txtDireccion.Text = existente.Direccion;

            var nombres = (string[])cboRol.DataSource;
            var match = nombres.FirstOrDefault(n =>
                string.Equals(n, existente.NombreRol, StringComparison.OrdinalIgnoreCase));
            
            cboRol.SelectedItem = match ?? null;
        }

        private bool SoloDigitos(string s) =>
            !string.IsNullOrWhiteSpace(s) && s.All(char.IsDigit);

        private bool Validar()
        {
            errorProvider1.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                errorProvider1.SetError(txtNombre, "El nombre es requerido");
                ok = false;
            }

            if (!SoloDigitos(Documento))
            {
                errorProvider1.SetError(txtDocumento, "Documento numérico");
                ok = false;
            }

            if (!string.IsNullOrWhiteSpace(Telefono) && !SoloDigitos(Telefono))
            {
                errorProvider1.SetError(txtTelefono, "Teléfono numérico (opcional)");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(Correo))
            {
                errorProvider1.SetError(txtCorreo, "El correo es necesario");
                ok = false;
            }

            // ⇩ Dirección: requerida (no uses SoloDigitos aquí)
            if (string.IsNullOrWhiteSpace(Direccion))
            {
                errorProvider1.SetError(txtDireccion, "La dirección es necesaria");
                ok = false;
            }

            // ⇩ Rol: exige selección válida (SelectedValue)
            if (string.IsNullOrWhiteSpace(NombreRol))
            {
                errorProvider1.SetError(cboRol, "Selecciona un rol");
                ok = false;
            }

            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
