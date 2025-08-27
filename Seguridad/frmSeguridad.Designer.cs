namespace Pantallas_Sistema_facturacion.Seguridad
{
    partial class frmSeguridad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.pnlEmpleado = new System.Windows.Forms.Panel();
            this.txtSegEmpleado = new System.Windows.Forms.TextBox();
            this.pnlUnderlineEmpleado = new System.Windows.Forms.Panel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.txtSegUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblClave = new MaterialSkin.Controls.MaterialLabel();
            this.txtSegClave = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSegActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnSegCancelar = new MaterialSkin.Controls.MaterialButton();
            this.pnlEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.Location = new System.Drawing.Point(380, 40);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ASIGNACIÓN DE CREDENCIALES";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmpleado.Location = new System.Drawing.Point(250, 100);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(139, 14);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Buscar empleado";
            // 
            // pnlEmpleado
            // 
            this.pnlEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmpleado.Controls.Add(this.txtSegEmpleado);
            this.pnlEmpleado.Controls.Add(this.pnlUnderlineEmpleado);
            this.pnlEmpleado.Location = new System.Drawing.Point(250, 120);
            this.pnlEmpleado.Name = "pnlEmpleado";
            this.pnlEmpleado.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.pnlEmpleado.Size = new System.Drawing.Size(480, 42);
            this.pnlEmpleado.TabIndex = 2;
            // 
            // txtSegEmpleado
            // 
            this.txtSegEmpleado.BackColor = System.Drawing.Color.White;
            this.txtSegEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegEmpleado.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSegEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtSegEmpleado.Location = new System.Drawing.Point(10, 12);
            this.txtSegEmpleado.Name = "txtSegEmpleado";
            this.txtSegEmpleado.Size = new System.Drawing.Size(460, 23);
            this.txtSegEmpleado.TabIndex = 0;
            // 
            // pnlUnderlineEmpleado
            // 
            this.pnlUnderlineEmpleado.BackColor = System.Drawing.Color.Silver;
            this.pnlUnderlineEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUnderlineEmpleado.Location = new System.Drawing.Point(8, 40);
            this.pnlUnderlineEmpleado.Name = "pnlUnderlineEmpleado";
            this.pnlUnderlineEmpleado.Size = new System.Drawing.Size(464, 2);
            this.pnlUnderlineEmpleado.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuario.Location = new System.Drawing.Point(250, 185);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 14);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtSegUsuario
            // 
            this.txtSegUsuario.AnimateReadOnly = false;
            this.txtSegUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSegUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSegUsuario.Depth = 0;
            this.txtSegUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSegUsuario.HideSelection = true;
            this.txtSegUsuario.LeadingIcon = null;
            this.txtSegUsuario.Location = new System.Drawing.Point(250, 205);
            this.txtSegUsuario.MaxLength = 100;
            this.txtSegUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegUsuario.Name = "txtSegUsuario";
            this.txtSegUsuario.PasswordChar = '\0';
            this.txtSegUsuario.PrefixSuffixText = null;
            this.txtSegUsuario.ReadOnly = true; // se habilita al cargar un empleado
            this.txtSegUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSegUsuario.SelectedText = "";
            this.txtSegUsuario.SelectionLength = 0;
            this.txtSegUsuario.SelectionStart = 0;
            this.txtSegUsuario.ShortcutsEnabled = true;
            this.txtSegUsuario.Size = new System.Drawing.Size(480, 48);
            this.txtSegUsuario.TabIndex = 1;
            this.txtSegUsuario.TabStop = false;
            this.txtSegUsuario.Text = "";
            this.txtSegUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSegUsuario.TrailingIcon = null;
            this.txtSegUsuario.UseSystemPasswordChar = false;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Depth = 0;
            this.lblClave.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblClave.Location = new System.Drawing.Point(250, 270);
            this.lblClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(72, 14);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Contraseña";
            // 
            // txtSegClave
            // 
            this.txtSegClave.AnimateReadOnly = false;
            this.txtSegClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSegClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSegClave.Depth = 0;
            this.txtSegClave.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSegClave.HideSelection = true;
            this.txtSegClave.LeadingIcon = null;
            this.txtSegClave.Location = new System.Drawing.Point(250, 290);
            this.txtSegClave.MaxLength = 100;
            this.txtSegClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegClave.Name = "txtSegClave";
            this.txtSegClave.PasswordChar = '●'; // oculta caracteres
            this.txtSegClave.PrefixSuffixText = null;
            this.txtSegClave.ReadOnly = true; // se habilita al cargar un empleado
            this.txtSegClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSegClave.SelectedText = "";
            this.txtSegClave.SelectionLength = 0;
            this.txtSegClave.SelectionStart = 0;
            this.txtSegClave.ShortcutsEnabled = true;
            this.txtSegClave.Size = new System.Drawing.Size(480, 48);
            this.txtSegClave.TabIndex = 2;
            this.txtSegClave.TabStop = false;
            this.txtSegClave.Text = "";
            this.txtSegClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSegClave.TrailingIcon = null;
            this.txtSegClave.UseSystemPasswordChar = true;
            // 
            // btnSegActualizar
            // 
            this.btnSegActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSegActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSegActualizar.Depth = 0;
            this.btnSegActualizar.Enabled = false; // se habilita cuando hay cambios
            this.btnSegActualizar.HighEmphasis = true;
            this.btnSegActualizar.Icon = null;
            this.btnSegActualizar.Location = new System.Drawing.Point(355, 370);
            this.btnSegActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSegActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSegActualizar.Name = "btnSegActualizar";
            this.btnSegActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSegActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnSegActualizar.TabIndex = 3;
            this.btnSegActualizar.Text = "ACTUALIZAR";
            this.btnSegActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSegActualizar.UseAccentColor = false;
            this.btnSegActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSegCancelar
            // 
            this.btnSegCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSegCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSegCancelar.Depth = 0;
            this.btnSegCancelar.Enabled = false; // se habilita cuando hay cambios
            this.btnSegCancelar.HighEmphasis = true;
            this.btnSegCancelar.Icon = null;
            this.btnSegCancelar.Location = new System.Drawing.Point(510, 370);
            this.btnSegCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSegCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSegCancelar.Name = "btnSegCancelar";
            this.btnSegCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSegCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnSegCancelar.TabIndex = 4;
            this.btnSegCancelar.Text = "CANCELAR";
            this.btnSegCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSegCancelar.UseAccentColor = false;
            this.btnSegCancelar.UseVisualStyleBackColor = true;
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 548);
            this.Controls.Add(this.btnSegCancelar);
            this.Controls.Add(this.btnSegActualizar);
            this.Controls.Add(this.txtSegClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtSegUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeguridad";
            this.Text = "frmSeguridad";
            this.AcceptButton = this.btnSegActualizar;
            this.CancelButton = this.btnSegCancelar;
            this.pnlEmpleado.ResumeLayout(false);
            this.pnlEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private System.Windows.Forms.Panel pnlEmpleado;
        private System.Windows.Forms.TextBox txtSegEmpleado;
        private System.Windows.Forms.Panel pnlUnderlineEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegUsuario;
        private MaterialSkin.Controls.MaterialLabel lblClave;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegClave;
        private MaterialSkin.Controls.MaterialButton btnSegActualizar;
        private MaterialSkin.Controls.MaterialButton btnSegCancelar;
    }
}
