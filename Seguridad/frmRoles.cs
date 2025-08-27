using System;
using System.Linq;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmRoles : Form
    {
        // Guarda la descripción original del rol cargado para poder cancelar cambios
        private string _descripcionOriginal = "";
        // Guarda el nombre actual del rol cargado
        private string _rolActual = null;

        public frmRoles()
        {
            InitializeComponent();

            // Habilita autocompletado con los nombres del catálogo
            ConfigurarAutoComplete();

            // Estado inicial de botones
            SetEstadosControles(hayRolCargado: false, hayCambios: false);

            // Eventos
            this.Load += (_, __) => LimpiarUI();
            txtRolNombre.KeyDown += txtRolNombre_KeyDown_EnterBusca;
            txtRolNombre.Leave += (_, __) => CargarRolDesdeUI(); // opcional
            txtRolDescripcion.TextChanged += (_, __) =>
            {
                var hayCambios = _rolActual != null && !string.Equals(txtRolDescripcion.Text, _descripcionOriginal, StringComparison.Ordinal);
                SetEstadosControles(hayRolCargado: _rolActual != null, hayCambios: hayCambios);
            };
            btnRolActualizar.Click += (_, __) => GuardarDescripcion();
            btnRolCancelar.Click += (_, __) => CancelarCambios();
        }

        // Autocompletado de nombres de rol
        private void ConfigurarAutoComplete()
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(RolesStore.GetAllNames());

            // Estas propiedades existen en TextBox estándar
            txtRolNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRolNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRolNombre.AutoCompleteCustomSource = source;
        }

        // Limpia el formulario al iniciar
        private void LimpiarUI()
        {
            txtRolNombre.Text = "";
            txtRolDescripcion.Text = "";
            txtRolDescripcion.ReadOnly = true;
            _rolActual = null;
            _descripcionOriginal = "";
            SetEstadosControles(hayRolCargado: false, hayCambios: false);
        }

        // Maneja Enter en el nombre del rol para cargarlo
        private void txtRolNombre_KeyDown_EnterBusca(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CargarRolDesdeUI();
            }
        }

        // Carga el rol según el texto del nombre; si no existe, lo crea como "otro"
        private void CargarRolDesdeUI()
        {
            var nombre = (txtRolNombre.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa el nombre del rol.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var info = RolesStore.GetOrCreate(nombre, allowCreate: true);
            _rolActual = info.Nombre;
            txtRolDescripcion.Text = info.Descripcion ?? "";
            _descripcionOriginal = txtRolDescripcion.Text;

            SetEstadosControles(hayRolCargado: true, hayCambios: false);
        }

        // Guarda la nueva descripción en el catálogo
        private void GuardarDescripcion()
        {
            if (_rolActual == null)
            {
                MessageBox.Show("Primero carga un rol.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RolesStore.UpdateDescription(_rolActual, txtRolDescripcion.Text ?? "");
            _descripcionOriginal = txtRolDescripcion.Text ?? "";
            SetEstadosControles(hayRolCargado: true, hayCambios: false);
            MessageBox.Show("Descripción actualizada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Cancela los cambios actuales y límpia la UI
        private void CancelarCambios()
        {
            LimpiarUI();
        }

        // Controla habilitación de botones según contexto
        private void SetEstadosControles(bool hayRolCargado, bool hayCambios)
        {
            btnRolActualizar.Enabled = hayRolCargado && hayCambios;
            btnRolCancelar.Enabled = hayRolCargado && hayCambios;
            txtRolDescripcion.ReadOnly = !hayRolCargado; // no se edita si no hay rol
        }
    }
}

