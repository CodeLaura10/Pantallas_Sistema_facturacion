namespace Pantallas_Sistema_facturacion.Seguridad
{
    partial class FrmEmpleadoEdit
    {
        /// <summary>
        /// Componentes del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberación de recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código del Diseñador

        /// <summary>
        /// Inicializa y configura los controles del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            // Título de la ventana de edición
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(126, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESA LOS DATOS";
            // 
            // txtNombre
            // 
            // Campo de nombre (vacío para que no se use como texto real)
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(85, 124);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(279, 48);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TabStop = true;
            this.txtNombre.Text = ""; // ← sin placeholder como contenido
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            // Campo de documento (solo dígitos, validado en el code-behind)
            this.txtDocumento.AnimateReadOnly = false;
            this.txtDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.HideSelection = true;
            this.txtDocumento.LeadingIcon = null;
            this.txtDocumento.Location = new System.Drawing.Point(85, 193);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.PrefixSuffixText = null;
            this.txtDocumento.ReadOnly = false;
            this.txtDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.Size = new System.Drawing.Size(279, 48);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.TabStop = true;
            this.txtDocumento.Text = ""; // ← sin placeholder como contenido
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumento.TrailingIcon = null;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            // Campo de teléfono (opcional; solo dígitos si se llena)
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(85, 264);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PrefixSuffixText = null;
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(279, 48);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TabStop = true;
            this.txtTelefono.Text = ""; // ← sin placeholder como contenido
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            // Botón principal: guarda cambios (Enter)
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(113, 355);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            // Botón secundario: cierra sin aplicar cambios (Esc)
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(239, 355);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleadoEdit
            // 
            // Configuración del formulario modal de edición/creación
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 455);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // modal sin redimensionar
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; // centro respecto al padre
            this.Name = "FrmEmpleadoEdit";
            this.Text = "Empleado";
            // Teclas rápidas: Enter = Guardar, Esc = Cancelar
            this.AcceptButton = this.btnGuardar;
            this.CancelButton = this.btnCancelar;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtDocumento;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}
