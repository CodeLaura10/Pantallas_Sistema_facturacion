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
            BtnNuevaCaegoria = new Button();
            BtnSalir = new Button();
            textBoxcliente = new TextBox();
            panel1 = new Panel();
            labelcategoria = new Label();
            DGCategoria = new DataGridView();
            IdCategoria = new DataGridViewTextBoxColumn();
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
            panel2.Controls.Add(BtnNuevaCaegoria);
            panel2.Controls.Add(BtnSalir);
            panel2.Controls.Add(textBoxcliente);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.Info;
            panel2.Location = new Point(0, 76);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 55);
            panel2.TabIndex = 10;
            // 
            // BtnNuevaCaegoria
            // 
            BtnNuevaCaegoria.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevaCaegoria.ForeColor = SystemColors.Desktop;
            BtnNuevaCaegoria.Location = new Point(704, 5);
            BtnNuevaCaegoria.Name = "BtnNuevaCaegoria";
            BtnNuevaCaegoria.Size = new Size(192, 42);
            BtnNuevaCaegoria.TabIndex = 13;
            BtnNuevaCaegoria.Text = "Agregar Categoria";
            BtnNuevaCaegoria.UseVisualStyleBackColor = true;
            BtnNuevaCaegoria.Click += BtnNuevaCaegoria_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.Desktop;
            BtnSalir.Location = new Point(944, 5);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(93, 42);
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
            textBoxcliente.Location = new Point(27, 12);
            textBoxcliente.Margin = new Padding(4, 3, 4, 3);
            textBoxcliente.Name = "textBoxcliente";
            textBoxcliente.Size = new Size(629, 29);
            textBoxcliente.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelcategoria);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 76);
            panel1.TabIndex = 9;
            // 
            // labelcategoria
            // 
            labelcategoria.AutoSize = true;
            labelcategoria.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcategoria.ForeColor = Color.White;
            labelcategoria.Location = new Point(307, 22);
            labelcategoria.Margin = new Padding(4, 0, 4, 0);
            labelcategoria.Name = "labelcategoria";
            labelcategoria.Size = new Size(447, 29);
            labelcategoria.TabIndex = 1;
            labelcategoria.Text = "ADMINISTRACIÓN DE CATEGORIAS";
            labelcategoria.Click += labelproductos_Click;
            // 
            // DGCategoria
            // 
            DGCategoria.BackgroundColor = SystemColors.ButtonFace;
            DGCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGCategoria.Columns.AddRange(new DataGridViewColumn[] { IdCategoria, Nombre_Categoria, Descripción_Categoria, BtnEditar, BtnEliminar });
            DGCategoria.Location = new Point(28, 158);
            DGCategoria.Margin = new Padding(4, 3, 4, 3);
            DGCategoria.Name = "DGCategoria";
            DGCategoria.Size = new Size(1028, 431);
            DGCategoria.TabIndex = 8;
            DGCategoria.CellContentClick += DGCategoria_CellContentClick;
            // 
            // IdCategoria
            // 
            IdCategoria.DataPropertyName = "IdCategoria";
            IdCategoria.HeaderText = "ID";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.Width = 30;
            // 
            // Nombre_Categoria
            // 
            Nombre_Categoria.HeaderText = "CATEGORIA";
            Nombre_Categoria.Name = "Nombre_Categoria";
            Nombre_Categoria.Width = 190;
            // 
            // Descripción_Categoria
            // 
            Descripción_Categoria.HeaderText = "DESCRIPCIÓN";
            Descripción_Categoria.Name = "Descripción_Categoria";
            Descripción_Categoria.Width = 480;
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
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 81, 181);
            ClientSize = new Size(1181, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DGCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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
        private Button BtnNuevaCaegoria;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Nombre_Categoria;
        private DataGridViewTextBoxColumn Descripción_Categoria;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnEliminar;
    }
}

