namespace FrmCategoria
{
    partial class FrmInsertarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblDescripciónCategoria = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblTituloCategoria = new System.Windows.Forms.Label();
            this.TxTId_Categoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.ForeColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(29, 66);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(75, 19);
            this.LblCategoria.TabIndex = 0;
            this.LblCategoria.Text = "Categoria";
            this.LblCategoria.Click += new System.EventHandler(this.NombreCategoria_Click);
            // 
            // LblDescripciónCategoria
            // 
            this.LblDescripciónCategoria.AutoSize = true;
            this.LblDescripciónCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripciónCategoria.ForeColor = System.Drawing.Color.White;
            this.LblDescripciónCategoria.Location = new System.Drawing.Point(29, 118);
            this.LblDescripciónCategoria.Name = "LblDescripciónCategoria";
            this.LblDescripciónCategoria.Size = new System.Drawing.Size(88, 19);
            this.LblDescripciónCategoria.TabIndex = 1;
            this.LblDescripciónCategoria.Text = "Descripción";
            this.LblDescripciónCategoria.Click += new System.EventHandler(this.DescripciónCategoria_Click);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCategoria.Location = new System.Drawing.Point(32, 88);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(266, 20);
            this.TxtCategoria.TabIndex = 3;
            this.TxtCategoria.TextChanged += new System.EventHandler(this.TxtCategoria_TextChanged);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtDescripcion.Location = new System.Drawing.Point(32, 140);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(266, 97);
            this.TxtDescripcion.TabIndex = 4;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Blue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.Location = new System.Drawing.Point(33, 257);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(118, 30);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(181, 257);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 30);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblTituloCategoria
            // 
            this.LblTituloCategoria.AutoSize = true;
            this.LblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCategoria.ForeColor = System.Drawing.Color.White;
            this.LblTituloCategoria.Location = new System.Drawing.Point(30, 9);
            this.LblTituloCategoria.Name = "LblTituloCategoria";
            this.LblTituloCategoria.Size = new System.Drawing.Size(185, 29);
            this.LblTituloCategoria.TabIndex = 7;
            this.LblTituloCategoria.Text = "Titulo Categoria";
            this.LblTituloCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxTId_Categoria
            // 
            this.TxTId_Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxTId_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxTId_Categoria.ForeColor = System.Drawing.SystemColors.Window;
            this.TxTId_Categoria.Location = new System.Drawing.Point(301, 56);
            this.TxTId_Categoria.Name = "TxTId_Categoria";
            this.TxTId_Categoria.Size = new System.Drawing.Size(18, 20);
            this.TxTId_Categoria.TabIndex = 7;
            this.TxTId_Categoria.TextChanged += new System.EventHandler(this.TxTId_Categoria_TextChanged);
            // 
            // FrmInsertarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(330, 300);
            this.Controls.Add(this.LblTituloCategoria);
            this.Controls.Add(this.TxTId_Categoria);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.LblDescripciónCategoria);
            this.Controls.Add(this.LblCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertarCategoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblDescripciónCategoria;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblTituloCategoria;
        private System.Windows.Forms.TextBox TxTId_Categoria;
        //       private System.Windows.Forms.TextBox IdCategoria;
    }
}