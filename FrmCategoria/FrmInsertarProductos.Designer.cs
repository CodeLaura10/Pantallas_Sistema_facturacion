namespace FrmCategoria
{
    partial class FrmInsertarProductos
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblTituloProducto = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtVenta = new System.Windows.Forms.TextBox();
            this.TxtCompra = new System.Windows.Forms.TextBox();
            this.TxTId_Producto = new System.Windows.Forms.TextBox();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblPrecioVenta = new System.Windows.Forms.Label();
            this.LblPrecioCompra = new System.Windows.Forms.Label();
            this.LblNroReferencia = new System.Windows.Forms.Label();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.TxtDetalle = new System.Windows.Forms.TextBox();
            this.LblDetalleProducto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblRutaImagen = new System.Windows.Forms.Label();
            this.ComboxCategoria = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(345, 339);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 30);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Blue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.Location = new System.Drawing.Point(197, 339);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(118, 30);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblTituloProducto
            // 
            this.LblTituloProducto.AutoSize = true;
            this.LblTituloProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloProducto.ForeColor = System.Drawing.Color.White;
            this.LblTituloProducto.Location = new System.Drawing.Point(30, 9);
            this.LblTituloProducto.Name = "LblTituloProducto";
            this.LblTituloProducto.Size = new System.Drawing.Size(177, 29);
            this.LblTituloProducto.TabIndex = 9;
            this.LblTituloProducto.Text = "Titulo Producto";
            this.LblTituloProducto.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // TxtStock
            // 
            this.TxtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStock.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtStock.Location = new System.Drawing.Point(55, 296);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(244, 20);
            this.TxtStock.TabIndex = 31;
            // 
            // TxtVenta
            // 
            this.TxtVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtVenta.Location = new System.Drawing.Point(55, 244);
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.Size = new System.Drawing.Size(244, 20);
            this.TxtVenta.TabIndex = 30;
            // 
            // TxtCompra
            // 
            this.TxtCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCompra.Location = new System.Drawing.Point(55, 192);
            this.TxtCompra.Name = "TxtCompra";
            this.TxtCompra.Size = new System.Drawing.Size(244, 20);
            this.TxtCompra.TabIndex = 29;
            // 
            // TxTId_Producto
            // 
            this.TxTId_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxTId_Producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxTId_Producto.ForeColor = System.Drawing.SystemColors.Window;
            this.TxTId_Producto.Location = new System.Drawing.Point(630, 58);
            this.TxTId_Producto.Name = "TxTId_Producto";
            this.TxTId_Producto.Size = new System.Drawing.Size(18, 20);
            this.TxTId_Producto.TabIndex = 28;
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReferencia.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtReferencia.Location = new System.Drawing.Point(33, 140);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(266, 20);
            this.TxtReferencia.TabIndex = 27;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.Location = new System.Drawing.Point(33, 88);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(266, 20);
            this.TxtNombre.TabIndex = 26;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.ForeColor = System.Drawing.Color.White;
            this.LblStock.Location = new System.Drawing.Point(50, 274);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(111, 19);
            this.LblStock.TabIndex = 25;
            this.LblStock.Text = "Cantidad Stock";
            // 
            // LblPrecioVenta
            // 
            this.LblPrecioVenta.AutoSize = true;
            this.LblPrecioVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.LblPrecioVenta.Location = new System.Drawing.Point(50, 222);
            this.LblPrecioVenta.Name = "LblPrecioVenta";
            this.LblPrecioVenta.Size = new System.Drawing.Size(109, 19);
            this.LblPrecioVenta.TabIndex = 24;
            this.LblPrecioVenta.Text = "💲 Precio Venta";
            // 
            // LblPrecioCompra
            // 
            this.LblPrecioCompra.AutoSize = true;
            this.LblPrecioCompra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioCompra.ForeColor = System.Drawing.Color.White;
            this.LblPrecioCompra.Location = new System.Drawing.Point(50, 170);
            this.LblPrecioCompra.Name = "LblPrecioCompra";
            this.LblPrecioCompra.Size = new System.Drawing.Size(123, 19);
            this.LblPrecioCompra.TabIndex = 23;
            this.LblPrecioCompra.Text = "💲 Precio Compra";
            this.LblPrecioCompra.Click += new System.EventHandler(this.LblPrecioCompra_Click);
            // 
            // LblNroReferencia
            // 
            this.LblNroReferencia.AutoSize = true;
            this.LblNroReferencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroReferencia.ForeColor = System.Drawing.Color.White;
            this.LblNroReferencia.Location = new System.Drawing.Point(29, 118);
            this.LblNroReferencia.Name = "LblNroReferencia";
            this.LblNroReferencia.Size = new System.Drawing.Size(117, 19);
            this.LblNroReferencia.TabIndex = 22;
            this.LblNroReferencia.Text = "Nro. Referencia";
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.LblNombreProducto.Location = new System.Drawing.Point(29, 66);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(126, 19);
            this.LblNombreProducto.TabIndex = 21;
            this.LblNombreProducto.Text = "Nombre Producto";
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.TxtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDetalle.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtDetalle.Location = new System.Drawing.Point(382, 192);
            this.TxtDetalle.Multiline = true;
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Size = new System.Drawing.Size(266, 124);
            this.TxtDetalle.TabIndex = 33;
            // 
            // LblDetalleProducto
            // 
            this.LblDetalleProducto.AutoSize = true;
            this.LblDetalleProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleProducto.ForeColor = System.Drawing.Color.White;
            this.LblDetalleProducto.Location = new System.Drawing.Point(378, 170);
            this.LblDetalleProducto.Name = "LblDetalleProducto";
            this.LblDetalleProducto.Size = new System.Drawing.Size(121, 19);
            this.LblDetalleProducto.TabIndex = 32;
            this.LblDetalleProducto.Text = "Detalle Producto";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(382, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 35;
            // 
            // LblRutaImagen
            // 
            this.LblRutaImagen.AutoSize = true;
            this.LblRutaImagen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutaImagen.ForeColor = System.Drawing.Color.White;
            this.LblRutaImagen.Location = new System.Drawing.Point(378, 119);
            this.LblRutaImagen.Name = "LblRutaImagen";
            this.LblRutaImagen.Size = new System.Drawing.Size(96, 19);
            this.LblRutaImagen.TabIndex = 34;
            this.LblRutaImagen.Text = "Ruta Imagen";
            // 
            // ComboxCategoria
            // 
            this.ComboxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ComboxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboxCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.ComboxCategoria.FormattingEnabled = true;
            this.ComboxCategoria.Items.AddRange(new object[] {
            "Categoria 1",
            "Categoria 2",
            "Categoria 3"});
            this.ComboxCategoria.Location = new System.Drawing.Point(383, 88);
            this.ComboxCategoria.Name = "ComboxCategoria";
            this.ComboxCategoria.Size = new System.Drawing.Size(266, 21);
            this.ComboxCategoria.TabIndex = 36;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.ForeColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(378, 66);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(75, 19);
            this.LblCategoria.TabIndex = 37;
            this.LblCategoria.Text = "Categoria";
            // 
            // FrmInsertarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.ComboxCategoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblRutaImagen);
            this.Controls.Add(this.TxtDetalle);
            this.Controls.Add(this.LblDetalleProducto);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtVenta);
            this.Controls.Add(this.TxtCompra);
            this.Controls.Add(this.TxTId_Producto);
            this.Controls.Add(this.TxtReferencia);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblPrecioVenta);
            this.Controls.Add(this.LblPrecioCompra);
            this.Controls.Add(this.LblNroReferencia);
            this.Controls.Add(this.LblNombreProducto);
            this.Controls.Add(this.LblTituloProducto);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertarProductos";
            this.Load += new System.EventHandler(this.FrmInsertarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblTituloProducto;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtVenta;
        private System.Windows.Forms.TextBox TxtCompra;
        private System.Windows.Forms.TextBox TxTId_Producto;
        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblPrecioVenta;
        private System.Windows.Forms.Label LblPrecioCompra;
        private System.Windows.Forms.Label LblNroReferencia;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.TextBox TxtDetalle;
        private System.Windows.Forms.Label LblDetalleProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblRutaImagen;
        private System.Windows.Forms.ComboBox ComboxCategoria;
        private System.Windows.Forms.Label LblCategoria;
    }
}