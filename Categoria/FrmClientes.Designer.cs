using Pantallas_Sistema_facturacion.Properties;

namespace FrmCategoria
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            DGClientes = new DataGridView();
            Id_Cliente = new DataGridViewTextBoxColumn();
            Nombre_Cliente = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            BtnEditar = new DataGridViewButtonColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            panel1 = new Panel();
            labelcliente = new Label();
            panel2 = new Panel();
            BtnNuevoCliente = new Button();
            BtnSalir = new Button();
            textBoxcliente = new TextBox();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGClientes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGClientes
            // 
            DGClientes.BackgroundColor = SystemColors.ButtonFace;
            DGClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGClientes.Columns.AddRange(new DataGridViewColumn[] { Id_Cliente, Nombre_Cliente, Documento, Telefono, BtnEditar, BtnEliminar });
            DGClientes.Location = new Point(32, 211);
            DGClientes.Margin = new Padding(5, 4, 5, 4);
            DGClientes.Name = "DGClientes";
            DGClientes.RowHeadersWidth = 51;
            DGClientes.Size = new Size(1001, 351);
            DGClientes.TabIndex = 2;
            DGClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id_Cliente
            // 
            Id_Cliente.HeaderText = "ID";
            Id_Cliente.MaxInputLength = 10000;
            Id_Cliente.MinimumWidth = 6;
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.Width = 30;
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.HeaderText = "CLIENTE";
            Nombre_Cliente.MinimumWidth = 6;
            Nombre_Cliente.Name = "Nombre_Cliente";
            Nombre_Cliente.Width = 320;
            // 
            // Documento
            // 
            Documento.HeaderText = "DOCUMENTO";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.Width = 200;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "TELEFONO";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
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
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "EDITAR";
            dataGridViewImageColumn1.Image = Resources.a37f4ed0_67cf_472a_9bb5_b12abbedaaed;
            dataGridViewImageColumn1.MinimumWidth = 6;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.HeaderText = "BORRAR";
            dataGridViewImageColumn2.Image = (Image)resources.GetObject("dataGridViewImageColumn2.Image");
            dataGridViewImageColumn2.MinimumWidth = 6;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 81, 181);
            panel1.Controls.Add(labelcliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 101);
            panel1.TabIndex = 3;
            // 
            // labelcliente
            // 
            labelcliente.AutoSize = true;
            labelcliente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcliente.ForeColor = Color.White;
            labelcliente.Location = new Point(299, 29);
            labelcliente.Margin = new Padding(5, 0, 5, 0);
            labelcliente.Name = "labelcliente";
            labelcliente.Size = new Size(503, 36);
            labelcliente.TabIndex = 1;
            labelcliente.Text = "ADMINISTRACIÓN DE CLIENTES";
            labelcliente.Click += labelcliente_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 62, 153);
            panel2.Controls.Add(BtnNuevoCliente);
            panel2.Controls.Add(BtnBuscar);
            panel2.Controls.Add(BtnSalir);
            panel2.Controls.Add(textBoxcliente);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.Info;
            panel2.Location = new Point(0, 101);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 73);
            panel2.TabIndex = 4;
            // 
            // BtnNuevoCliente
            // 
            BtnNuevoCliente.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevoCliente.ForeColor = SystemColors.Desktop;
            BtnNuevoCliente.Location = new Point(785, 9);
            BtnNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            BtnNuevoCliente.Name = "BtnNuevoCliente";
            BtnNuevoCliente.Size = new Size(106, 56);
            BtnNuevoCliente.TabIndex = 9;
            BtnNuevoCliente.Text = "Nuevo";
            BtnNuevoCliente.UseVisualStyleBackColor = true;
            BtnNuevoCliente.Click += BtnNuevoCliente_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.Desktop;
            BtnSalir.Location = new Point(936, 9);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(106, 56);
            BtnSalir.TabIndex = 7;
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
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = SystemColors.Desktop;
            BtnBuscar.Location = new Point(640, 9);
            BtnBuscar.Margin = new Padding(3, 4, 3, 4);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(106, 56);
            BtnBuscar.TabIndex = 8;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 81, 181);
            ClientSize = new Size(1066, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DGClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)DGClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        /* private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar; */
        private System.Windows.Forms.Label labelcliente;
        private System.Windows.Forms.TextBox textBoxcliente;
        private Button BtnSalir;
        private Button BtnNuevoCliente;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Nombre_Cliente;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnEliminar;
        private Button BtnBuscar;
    }
}