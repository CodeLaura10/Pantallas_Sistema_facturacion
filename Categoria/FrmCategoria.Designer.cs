using MaterialSkin;
using MaterialSkin.Controls;

namespace FrmCategoria
{
    partial class FrmCategorias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            BtnNuevoCliente = new Button();
            BtnSalir = new Button();
            textBoxcliente = new TextBox();
            panel1 = new Panel();
            labelcategoria = new Label();
            DGCategoria = new DataGridView();
            Id_Categoria = new DataGridViewTextBoxColumn();
            Nombre_Categoria = new DataGridViewTextBoxColumn();
            Descripción_Categoria = new DataGridViewTextBoxColumn();
            BtnEditar = new DataGridViewButtonColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGCategoria).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 62, 153);
            panel2.Controls.Add(BtnNuevoCliente);
            panel2.Controls.Add(BtnSalir);
            panel2.Controls.Add(textBoxcliente);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.Info;
            panel2.Location = new Point(0, 101);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 73);
            panel2.TabIndex = 10;
            // 
            // BtnNuevoCliente
            // 
            BtnNuevoCliente.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevoCliente.ForeColor = SystemColors.Desktop;
            BtnNuevoCliente.Location = new Point(650, 9);
            BtnNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            BtnNuevoCliente.Name = "BtnNuevoCliente";
            BtnNuevoCliente.Size = new Size(241, 56);
            BtnNuevoCliente.TabIndex = 13;
            BtnNuevoCliente.Text = "Nuevo Cliente";
            BtnNuevoCliente.UseVisualStyleBackColor = true;
            BtnNuevoCliente.Click += BtnNuevaCaegoria_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.Desktop;
            BtnSalir.Location = new Point(936, 9);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(106, 56);
            BtnSalir.TabIndex = 11;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click_1;
            // 
            // textBoxcliente
            // 
            textBoxcliente.BackColor = Color.FromArgb(47, 62, 153);
            textBoxcliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcliente.ForeColor = SystemColors.Window;
            textBoxcliente.Location = new Point(31, 16);
            textBoxcliente.Margin = new Padding(5, 4, 5, 4);
            textBoxcliente.Name = "textBoxcliente";
            textBoxcliente.Size = new Size(583, 34);
            textBoxcliente.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelcategoria);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 101);
            panel1.TabIndex = 9;
            // 
            // labelcategoria
            // 
            labelcategoria.AutoSize = true;
            labelcategoria.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcategoria.ForeColor = Color.White;
            labelcategoria.Location = new Point(280, 29);
            labelcategoria.Margin = new Padding(5, 0, 5, 0);
            labelcategoria.Name = "labelcategoria";
            labelcategoria.Size = new Size(555, 36);
            labelcategoria.TabIndex = 1;
            labelcategoria.Text = "ADMINISTRACIÓN DE CATEGORIAS";
            labelcategoria.Click += labelproductos_Click;
            // 
            // DGCategoria
            // 
            DGCategoria.BackgroundColor = SystemColors.ButtonFace;
            DGCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGCategoria.Columns.AddRange(new DataGridViewColumn[] { Id_Categoria, Nombre_Categoria, Descripción_Categoria, BtnEditar, BtnEliminar });
            DGCategoria.Location = new Point(32, 211);
            DGCategoria.Margin = new Padding(5, 4, 5, 4);
            DGCategoria.Name = "DGCategoria";
            DGCategoria.RowHeadersWidth = 51;
            DGCategoria.Size = new Size(1001, 351);
            DGCategoria.TabIndex = 8;
            DGCategoria.CellContentClick += DGCategoria_CellContentClick;
            // 
            // Id_Categoria
            // 
            Id_Categoria.HeaderText = "ID";
            Id_Categoria.MinimumWidth = 6;
            Id_Categoria.Name = "Id_Categoria";
            Id_Categoria.Width = 30;
            // 
            // Nombre_Categoria
            // 
            Nombre_Categoria.HeaderText = "CATEGORIA";
            Nombre_Categoria.MinimumWidth = 6;
            Nombre_Categoria.Name = "Nombre_Categoria";
            Nombre_Categoria.Width = 190;
            // 
            // Descripción_Categoria
            // 
            Descripción_Categoria.HeaderText = "DESCRIPCIÓN";
            Descripción_Categoria.MinimumWidth = 6;
            Descripción_Categoria.Name = "Descripción_Categoria";
            Descripción_Categoria.Width = 480;
            // 
            // BtnEditar
            // 
            BtnEditar.HeaderText = "EDITAR";
            BtnEditar.MinimumWidth = 6;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Text = "Editar";
            BtnEditar.UseColumnTextForButtonValue = true;
            BtnEditar.Width = 65;
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "ELIMINAR";
            BtnEliminar.MinimumWidth = 6;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseColumnTextForButtonValue = true;
            BtnEliminar.Width = 65;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 81, 181);
            ClientSize = new Size(1066, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DGCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategorias";
            Load += FrmCategoria_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxcliente;
        /* private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar; */
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelcategoria;
        private System.Windows.Forms.DataGridView DGCategoria;
        private Button BtnSalir;
        private Button BtnNuevoCliente;
        private DataGridViewTextBoxColumn Id_Categoria;
        private DataGridViewTextBoxColumn Nombre_Categoria;
        private DataGridViewTextBoxColumn Descripción_Categoria;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnEliminar;
    }
}

