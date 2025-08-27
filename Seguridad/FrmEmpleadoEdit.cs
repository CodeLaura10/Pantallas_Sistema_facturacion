using System;
using System.Linq;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class FrmEmpleadoEdit : Form
    {
        // Referencia al empleado cuando se edita (nulo cuando es nuevo)
        private readonly Empleado _original;

        // Componente para mostrar mensajes de validación junto a los campos
        private readonly ErrorProvider errorProvider1;

        // Propiedades de salida que lee el formulario llamador
        public string Nombre => txtNombre.Text.Trim();
        public string Documento => txtDocumento.Text.Trim();
        public string Telefono => txtTelefono.Text.Trim();

        // Constructor para creación (nuevo)
        public FrmEmpleadoEdit()
        {
            InitializeComponent();

            // Inicializa el ErrorProvider y lo asocia al formulario
            errorProvider1 = new ErrorProvider { ContainerControl = this };

            // Define teclas rápidas: Enter = Guardar, Esc = Cancelar
            this.AcceptButton = btnGuardar;
            this.CancelButton = btnCancelar;

            // Asegura la conexión de los eventos de los botones
            // Si ya están conectados en el diseñador, no es necesario volver a conectarlos.
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;

            // Restringe a dígitos en Documento y Teléfono (opcional, mejora UX)
            txtDocumento.KeyPress += SoloNumeros_KeyPress;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;

            // Coloca el foco inicial
            this.Shown += (_, __) => txtNombre.Focus();
        }

        // Constructor para edición (precarga los campos con datos existentes)
        public FrmEmpleadoEdit(Empleado existente) : this()
        {
            _original = existente;
            txtNombre.Text = existente.Nombre;
            txtDocumento.Text = existente.Documento;
            txtTelefono.Text = existente.Telefono;
        }

        // Valida que una cadena tenga solo dígitos y no esté vacía
        private bool SoloDigitos(string s) => !string.IsNullOrWhiteSpace(s) && s.All(char.IsDigit);

        // Valida los campos y marca errores cuando corresponde
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

            return ok;
        }

        // Guardar: valida y cierra devolviendo OK
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancelar: cierra devolviendo Cancel
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Filtro de teclado: permite solo dígitos y teclas de control (Backspace, etc.)
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
