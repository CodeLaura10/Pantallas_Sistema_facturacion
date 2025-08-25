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
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            panel1 = new Panel();
            labelcliente = new Label();
            panel2 = new Panel();
            BtnNuevoCliente = new Button();
            BtnBuscar = new Button();
            BtnSalir = new Button();
            textBoxcliente = new TextBox();
            Id_Cliente = new DataGridViewTextBoxColumn();
            Nombre_Cliente = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            BtnEditar = new DataGridViewButtonColumn();
            BtnEliminar = new DataGridViewButtonColumn();
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
            DGClientes.Location = new Point(28, 158);
            DGClientes.Margin = new Padding(4, 3, 4, 3);
            DGClientes.Name = "DGClientes";
            DGClientes.Size = new Size(876, 263);
            DGClientes.TabIndex = 2;
            DGClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "EDITAR";
            dataGridViewImageColumn1.Image = Resources.a37f4ed0_67cf_472a_9bb5_b12abbedaaed;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.HeaderText = "BORRAR";
            dataGridViewImageColumn2.Image = (Image)resources.GetObject("dataGridViewImageColumn2.Image");
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 81, 181);
            panel1.Controls.Add(labelcliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 76);
            panel1.TabIndex = 3;
            // 
            // labelcliente
            // 
            labelcliente.AutoSize = true;
            labelcliente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcliente.ForeColor = Color.White;
            labelcliente.Location = new Point(262, 22);
            labelcliente.Margin = new Padding(4, 0, 4, 0);
            labelcliente.Name = "labelcliente";
            labelcliente.Size = new Size(408, 29);
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
            panel2.Location = new Point(0, 76);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 55);
            panel2.TabIndex = 4;
            // 
            // BtnNuevoCliente
            // 
            BtnNuevoCliente.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevoCliente.ForeColor = SystemColors.Desktop;
            BtnNuevoCliente.Location = new Point(687, 7);
            BtnNuevoCliente.Name = "BtnNuevoCliente";
            BtnNuevoCliente.Size = new Size(93, 42);
            BtnNuevoCliente.TabIndex = 9;
            BtnNuevoCliente.Text = "Nuevo";
            BtnNuevoCliente.UseVisualStyleBackColor = true;
            BtnNuevoCliente.Click += BtnNuevoCliente_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = SystemColors.Desktop;
            BtnBuscar.Location = new Point(560, 7);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(93, 42);
            BtnBuscar.TabIndex = 8;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.Desktop;
            BtnSalir.Location = new Point(819, 7);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(93, 42);
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
            textBoxcliente.Location = new Point(27, 12);
            textBoxcliente.Margin = new Padding(4, 3, 4, 3);
            textBoxcliente.Name = "textBoxcliente";
            textBoxcliente.Size = new Size(511, 29);
            textBoxcliente.TabIndex = 5;
            // 
            // Id_Cliente
            // 
            Id_Cliente.HeaderText = "ID";
            Id_Cliente.MaxInputLength = 10000;
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.Width = 30;
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.HeaderText = "CLIENTE";
            Nombre_Cliente.Name = "Nombre_Cliente";
            Nombre_Cliente.Width = 320;
            // 
            // Documento
            // 
            Documento.HeaderText = "DOCUMENTO";
            Documento.Name = "Documento";
            Documento.Width = 200;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "TELEFONO";
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
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
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 81, 181);
            ClientSize = new Size(933, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DGClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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
        private Button BtnBuscar;
        private Button BtnNuevoCliente;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Nombre_Cliente;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnEliminar;
    }
}