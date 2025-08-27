namespace Pantallas_Sistema_facturacion.Seguridad
{
    partial class frmRoles
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreRol = new MaterialSkin.Controls.MaterialLabel();
            this.pnlRolNombre = new System.Windows.Forms.Panel();
            this.txtRolNombre = new System.Windows.Forms.TextBox();
            this.pnlUnderlineRolNombre = new System.Windows.Forms.Panel();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.txtRolDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnRolActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnRolCancelar = new MaterialSkin.Controls.MaterialButton();
            this.pnlRolNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            // Título de la sección
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.Location = new System.Drawing.Point(355, 49);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ROLES DE LOS EMPLEADOS";
            // 
            // lblNombreRol
            // 
            // Etiqueta para el nombre del rol
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Depth = 0;
            this.lblNombreRol.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreRol.Location = new System.Drawing.Point(271, 116);
            this.lblNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(101, 14);
            this.lblNombreRol.TabIndex = 1;
            this.lblNombreRol.Text = "Nombre del rol";
            // 
            // pnlRolNombre
            // 
            // Contenedor visual para imitar un MaterialTextBox (underline)
            this.pnlRolNombre.BackColor = System.Drawing.Color.Transparent;
            this.pnlRolNombre.Controls.Add(this.txtRolNombre);
            this.pnlRolNombre.Controls.Add(this.pnlUnderlineRolNombre);
            this.pnlRolNombre.Location = new System.Drawing.Point(271, 135);
            this.pnlRolNombre.Name = "pnlRolNombre";
            this.pnlRolNombre.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0); // margen interno
            this.pnlRolNombre.Size = new System.Drawing.Size(435, 42);
            this.pnlRolNombre.TabIndex = 2;
            // 
            // txtRolNombre
            // 
            // TextBox estándar sin borde para permitir autocompletar, simulando Material
            this.txtRolNombre.BackColor = System.Drawing.Color.White;
            this.txtRolNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRolNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtRolNombre.ForeColor = System.Drawing.Color.Black;
            this.txtRolNombre.Location = new System.Drawing.Point(10, 12);
            this.txtRolNombre.Name = "txtRolNombre";
            this.txtRolNombre.Size = new System.Drawing.Size(415, 23);
            this.txtRolNombre.TabIndex = 0;
            this.txtRolNombre.Text = ""; // vacío; el code-behind maneja autocompletar
            // 
            // pnlUnderlineRolNombre
            // 
            // Línea inferior para el efecto "underline" tipo Material
            this.pnlUnderlineRolNombre.BackColor = System.Drawing.Color.Silver;
            this.pnlUnderlineRolNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUnderlineRolNombre.Location = new System.Drawing.Point(8, 40);
            this.pnlUnderlineRolNombre.Name = "pnlUnderlineRolNombre";
            this.pnlUnderlineRolNombre.Size = new System.Drawing.Size(419, 2);
            this.pnlUnderlineRolNombre.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            // Etiqueta para la descripción del rol
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcion.Location = new System.Drawing.Point(271, 189);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(183, 14);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción detallada del rol";
            // 
            // txtRolDescripcion
            // 
            // Campo de descripción editable (multilínea). Se habilita cuando hay un rol cargado.
            this.txtRolDescripcion.AnimateReadOnly = false;
            this.txtRolDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRolDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRolDescripcion.Depth = 0;
            this.txtRolDescripcion.HideSelection = true;
            this.txtRolDescripcion.Location = new System.Drawing.Point(271, 212);
            this.txtRolDescripcion.MaxLength = 32767;
            this.txtRolDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRolDescripcion.Name = "txtRolDescripcion";
            this.txtRolDescripcion.PasswordChar = '\0';
            this.txtRolDescripcion.ReadOnly = true; // se pondrá en false cuando se cargue un rol
            this.txtRolDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRolDescripcion.SelectedText = "";
            this.txtRolDescripcion.SelectionLength = 0;
            this.txtRolDescripcion.SelectionStart = 0;
            this.txtRolDescripcion.ShortcutsEnabled = true;
            this.txtRolDescripcion.Size = new System.Drawing.Size(435, 209);
            this.txtRolDescripcion.TabIndex = 4;
            this.txtRolDescripcion.TabStop = false;
            this.txtRolDescripcion.Text = ""; // sin placeholder como texto real
            this.txtRolDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRolDescripcion.UseSystemPasswordChar = false;
            // 
            // btnRolActualizar
            // 
            // Guarda la descripción editada
            this.btnRolActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRolActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRolActualizar.Depth = 0;
            this.btnRolActualizar.Enabled = false; // se habilita cuando hay cambios
            this.btnRolActualizar.HighEmphasis = true;
            this.btnRolActualizar.Icon = null;
            this.btnRolActualizar.Location = new System.Drawing.Point(346, 455);
            this.btnRolActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRolActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRolActualizar.Name = "btnRolActualizar";
            this.btnRolActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRolActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnRolActualizar.TabIndex = 5;
            this.btnRolActualizar.Text = "ACTUALIZAR";
            this.btnRolActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRolActualizar.UseAccentColor = false;
            this.btnRolActualizar.UseVisualStyleBackColor = true;
            // 
            // btnRolCancelar
            // 
            // Restaura la descripción al último valor guardado
            this.btnRolCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRolCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRolCancelar.Depth = 0;
            this.btnRolCancelar.Enabled = false; // se habilita cuando hay cambios
            this.btnRolCancelar.HighEmphasis = true;
            this.btnRolCancelar.Icon = null;
            this.btnRolCancelar.Location = new System.Drawing.Point(501, 455);
            this.btnRolCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRolCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRolCancelar.Name = "btnRolCancelar";
            this.btnRolCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRolCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnRolCancelar.TabIndex = 6;
            this.btnRolCancelar.Text = "CANCELAR";
            this.btnRolCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRolCancelar.UseAccentColor = false;
            this.btnRolCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRoles
            // 
            // Form embebible sin bordes (igual estilo que Empleados)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 548);
            this.Controls.Add(this.btnRolCancelar);
            this.Controls.Add(this.btnRolActualizar);
            this.Controls.Add(this.txtRolDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pnlRolNombre);
            this.Controls.Add(this.lblNombreRol);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            // Atajos: Enter = Actualizar, Esc = Cancelar (puedes ajustar desde code-behind)
            this.AcceptButton = this.btnRolActualizar;
            this.CancelButton = this.btnRolCancelar;
            this.pnlRolNombre.ResumeLayout(false);
            this.pnlRolNombre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblNombreRol;
        private System.Windows.Forms.Panel pnlRolNombre;
        private System.Windows.Forms.TextBox txtRolNombre;
        private System.Windows.Forms.Panel pnlUnderlineRolNombre;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtRolDescripcion;
        private MaterialSkin.Controls.MaterialButton btnRolActualizar;
        private MaterialSkin.Controls.MaterialButton btnRolCancelar;
    }
}
