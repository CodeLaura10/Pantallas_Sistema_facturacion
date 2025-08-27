using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmSeguridad : Form
    {
        // Empleado actual seleccionado (null si aún no hay)
        private Empleado? _empleadoActual;

        // Guarda lo último persistido para detectar cambios
        private string _usernameOriginal = "";
        private string _passwordOriginal = "";

        public frmSeguridad()
        {
            InitializeComponent();

            // Carga inicial: limpia y configura eventos
            this.Load += (_, __) => LimpiarUI();

            // Autocompletar para nombres de empleados (TextBox estándar)
            ConfigurarAutoComplete();

            // Enter en el nombre del empleado → cargar
            txtSegEmpleado.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    CargarEmpleadoDesdeUI();
                }
            };

            // Clicks de botones
            btnSegActualizar.Click += (_, __) => Guardar();
            btnSegCancelar.Click += (_, __) => LimpiarUI();

            // Detecta cambios para habilitar/inhabilitar botones
            txtSegUsuario.TextChanged += (_, __) => EvaluarCambios();
            txtSegClave.TextChanged += (_, __) => EvaluarCambios();
        }

        // Llena la fuente de autocompletado con nombres de empleados
        private void ConfigurarAutoComplete()
        {
            var src = new AutoCompleteStringCollection();
            var nombres = EmpleadoStore.Empleados.Select(e => e.Nombre).Distinct().OrderBy(n => n).ToArray();
            src.AddRange(nombres);
            txtSegEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSegEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSegEmpleado.AutoCompleteCustomSource = src;
        }

        private bool _silencioUI = false;

        // Limpia campos y estado; deshabilita edición hasta seleccionar un empleado
        private void LimpiarUI()
        {
            _silencioUI = true;            
            txtSegEmpleado.Text = "";
            txtSegUsuario.Text = "";
            txtSegClave.Text = "";
            txtSegUsuario.ReadOnly = true;
            txtSegClave.ReadOnly = true;
            _empleadoActual = null;
            _usernameOriginal = "";
            _passwordOriginal = "";
            SetBotones(habilitar: false);
            _silencioUI = false;

            txtSegEmpleado.Focus();   
        }


        // Activa/desactiva Actualizar/Cancelar
        private void SetBotones(bool habilitar)
        {
            btnSegActualizar.Enabled = habilitar;
            btnSegCancelar.Enabled = habilitar;
        }

        // Carga un empleado por nombre (primera coincidencia, ignore case)
        private void CargarEmpleadoDesdeUI()
        {
            var nombre = (txtSegEmpleado.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa el nombre del empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var emp = EmpleadoStore.Empleados
                .FirstOrDefault(e => string.Equals(e.Nombre, nombre, StringComparison.OrdinalIgnoreCase));

            if (emp == null)
            {
                MessageBox.Show("Empleado no encontrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _empleadoActual = emp;

            var u = UsuariosStore.GetByEmpleadoId(emp.Id);
            txtSegUsuario.Text = u?.Username ?? "";
            txtSegClave.Text = u?.Password ?? ""; // Solo para práctica

            _usernameOriginal = txtSegUsuario.Text;
            _passwordOriginal = txtSegClave.Text;

            txtSegUsuario.ReadOnly = false;
            txtSegClave.ReadOnly = false;

            SetBotones(habilitar: false); // no hay cambios aún
            txtSegUsuario.Focus();
        }

        // Habilita botones cuando hay diferencias con lo guardado
        private void EvaluarCambios()
        {
            if (_silencioUI || _empleadoActual == null)
            {
                SetBotones(false);
                return;
            }

            bool hayCambios = !string.Equals(txtSegUsuario.Text, _usernameOriginal, StringComparison.Ordinal)
                           || !string.Equals(txtSegClave.Text, _passwordOriginal, StringComparison.Ordinal);

            SetBotones(habilitar: hayCambios);
        }

        // Valida reglas: usuario requerido; contraseña ≥ 6 y alfanumérica
        private bool ValidarCampos()
        {
            var user = (txtSegUsuario.Text ?? "").Trim();
            var pass = (txtSegClave.Text ?? "").Trim();

            // Usuario requerido y sin espacios
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("El usuario es requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegUsuario.Clear();
                txtSegUsuario.Focus();
                return false;
            }
            if (user.Contains(" "))
            {
                MessageBox.Show("El usuario no debe tener espacios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegUsuario.Clear();
                txtSegUsuario.Focus();
                return false;
            }

            // Contraseña: mínimo 6, solo alfanumérica
            if (pass.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegClave.Clear();
                txtSegClave.Focus();
                return false;
            }
            if (!Regex.IsMatch(pass, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("La contraseña debe ser alfanumérica (sin símbolos ni espacios).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegClave.Clear();
                txtSegClave.Focus();
                return false;
            }

            return true;
        }

        // Guarda cambios en el store y actualiza estado original
        private void Guardar()
        {
            if (_empleadoActual == null)
            {
                MessageBox.Show("Primero selecciona un empleado.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarCampos()) return;

            UsuariosStore.Upsert(_empleadoActual.Id,
                                 txtSegUsuario.Text.Trim(),
                                 txtSegClave.Text.Trim());

            MessageBox.Show("Credenciales actualizadas.", "OK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // limpia todo después de actualizar
            LimpiarUI();
        }

    }
}

