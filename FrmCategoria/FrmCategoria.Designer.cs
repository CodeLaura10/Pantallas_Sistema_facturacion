using MaterialSkin;
using MaterialSkin.Controls;

namespace FrmCategoria
{
    partial class FrmCategoria
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxcliente = new System.Windows.Forms.TextBox();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelcategoria = new System.Windows.Forms.Label();
            this.DGCategoria = new System.Windows.Forms.DataGridView();
            this.Id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.textBoxcliente);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Info;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 48);
            this.panel2.TabIndex = 10;
            // 
            // textBoxcliente
            // 
            this.textBoxcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.textBoxcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcliente.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxcliente.Location = new System.Drawing.Point(23, 9);
            this.textBoxcliente.Name = "textBoxcliente";
            this.textBoxcliente.Size = new System.Drawing.Size(439, 29);
            this.textBoxcliente.TabIndex = 5;
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(729, 5);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(578, 5);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(143, 36);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nueva Categoria";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(494, 5);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelcategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 9;
            // 
            // labelcategoria
            // 
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria.ForeColor = System.Drawing.Color.White;
            this.labelcategoria.Location = new System.Drawing.Point(177, 19);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(447, 29);
            this.labelcategoria.TabIndex = 1;
            this.labelcategoria.Text = "ADMINISTRACIÓN DE CATEGORIAS";
            this.labelcategoria.Click += new System.EventHandler(this.labelproductos_Click);
            // 
            // DGCategoria
            // 
            this.DGCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Categoria,
            this.Nombre_Categoria,
            this.Descripción_Categoria,
            this.BtnEditar,
            this.BtnEliminar});
            this.DGCategoria.Location = new System.Drawing.Point(37, 140);
            this.DGCategoria.Name = "DGCategoria";
            this.DGCategoria.Size = new System.Drawing.Size(737, 228);
            this.DGCategoria.TabIndex = 8;
            this.DGCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCategoria_CellContentClick);
            // 
            // Id_Categoria
            // 
            this.Id_Categoria.HeaderText = "ID";
            this.Id_Categoria.Name = "Id_Categoria";
            this.Id_Categoria.Width = 30;
            // 
            // Nombre_Categoria
            // 
            this.Nombre_Categoria.HeaderText = "CATEGORIA";
            this.Nombre_Categoria.Name = "Nombre_Categoria";
            this.Nombre_Categoria.Width = 120;
            // 
            // Descripción_Categoria
            // 
            this.Descripción_Categoria.HeaderText = "DESCRIPCIÓN";
            this.Descripción_Categoria.Name = "Descripción_Categoria";
            this.Descripción_Categoria.Width = 340;
            // 
            // BtnEditar
            // 
            this.BtnEditar.HeaderText = "EDITAR";
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseColumnTextForButtonValue = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.HeaderText = "ELIMINAR";
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseColumnTextForButtonValue = true;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxcliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelcategoria;
        private System.Windows.Forms.DataGridView DGCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción_Categoria;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
    }
}

