namespace FrmCategoria
{
    partial class FrmProductos
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
            DGProductos = new DataGridView();
            Id_Producto = new DataGridViewTextBoxColumn();
            Nombre_Producto = new DataGridViewTextBoxColumn();
            Nombre_Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            BtnEditar = new DataGridViewButtonColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            labelproductos = new Label();
            panel1 = new Panel();
            textBoxcliente = new TextBox();
            panel2 = new Panel();
            BtnNuevoProducto = new Button();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)DGProductos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGProductos
            // 
            DGProductos.BackgroundColor = SystemColors.ButtonFace;
            DGProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGProductos.Columns.AddRange(new DataGridViewColumn[] { Id_Producto, Nombre_Producto, Nombre_Categoria, Precio, Stock, BtnEditar, BtnEliminar });
            DGProductos.Location = new Point(28, 158);
            DGProductos.Margin = new Padding(4, 3, 4, 3);
            DGProductos.Name = "DGProductos";
            DGProductos.Size = new Size(1028, 431);
            DGProductos.TabIndex = 5;
            DGProductos.CellContentClick += DGProductos_CellContentClick;
            // 
            // Id_Producto
            // 
            Id_Producto.HeaderText = "ID";
            Id_Producto.Name = "Id_Producto";
            Id_Producto.Width = 30;
            // 
            // Nombre_Producto
            // 
            Nombre_Producto.HeaderText = "PRODUCTO";
            Nombre_Producto.Name = "Nombre_Producto";
            Nombre_Producto.Width = 230;
            // 
            // Nombre_Categoria
            // 
            Nombre_Categoria.HeaderText = "CATEGORIA";
            Nombre_Categoria.Name = "Nombre_Categoria";
            Nombre_Categoria.Width = 190;
            // 
            // Precio
            // 
            Precio.HeaderText = "PRECIO";
            Precio.Name = "Precio";
            Precio.Width = 130;
            // 
            // Stock
            // 
            Stock.HeaderText = "STOCK";
            Stock.Name = "Stock";
            Stock.Width = 120;
            // 
            // BtnEditar
            // 
            BtnEditar.HeaderText = "EDITAR";
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Text = "Editar";
            BtnEditar.UseColumnTextForButtonValue = true;
            BtnEditar.Width = 65;
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "ELIMINAR";
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseColumnTextForButtonValue = true;
            BtnEliminar.Width = 65;
            // 
            // labelproductos
            // 
            labelproductos.AutoSize = true;
            labelproductos.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelproductos.ForeColor = Color.White;
            labelproductos.Location = new Point(307, 22);
            labelproductos.Margin = new Padding(4, 0, 4, 0);
            labelproductos.Name = "labelproductos";
            labelproductos.Size = new Size(445, 29);
            labelproductos.TabIndex = 1;
            labelproductos.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelproductos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 76);
            panel1.TabIndex = 6;
            // 
            // textBoxcliente
            // 
            textBoxcliente.BackColor = Color.FromArgb(47, 62, 153);
            textBoxcliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcliente.ForeColor = SystemColors.Window;
            textBoxcliente.Location = new Point(27, 12);
            textBoxcliente.Margin = new Padding(4, 3, 4, 3);
            textBoxcliente.Name = "textBoxcliente";
            textBoxcliente.Size = new Size(629, 29);
            textBoxcliente.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 62, 153);
            panel2.Controls.Add(BtnNuevoProducto);
            panel2.Controls.Add(BtnSalir);
            panel2.Controls.Add(textBoxcliente);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.Info;
            panel2.Location = new Point(0, 76);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 55);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // BtnNuevoProducto
            // 
            BtnNuevoProducto.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevoProducto.ForeColor = SystemColors.Desktop;
            BtnNuevoProducto.Location = new Point(704, 5);
            BtnNuevoProducto.Name = "BtnNuevoProducto";
            BtnNuevoProducto.Size = new Size(192, 42);
            BtnNuevoProducto.TabIndex = 8;
            BtnNuevoProducto.Text = "Agregar Producto";
            BtnNuevoProducto.UseVisualStyleBackColor = true;
            BtnNuevoProducto.Click += BtnNuevoProducto_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.Desktop;
            BtnSalir.Location = new Point(944, 5);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(93, 42);
            BtnSalir.TabIndex = 6;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click_1;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 81, 181);
            ClientSize = new Size(1181, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DGProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)DGProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.Label labelproductos;
        private System.Windows.Forms.Panel panel1;
        /* private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir; */
        private System.Windows.Forms.TextBox textBoxcliente;
        private System.Windows.Forms.Panel panel2;
        private Button BtnSalir;
        private Button BtnNuevoProducto;
        private DataGridViewTextBoxColumn Id_Producto;
        private DataGridViewTextBoxColumn Nombre_Producto;
        private DataGridViewTextBoxColumn Nombre_Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnEliminar;
    }
}