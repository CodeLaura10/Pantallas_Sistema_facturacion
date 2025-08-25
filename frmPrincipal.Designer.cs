namespace Pantallas_Sistema_facturacion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            pnlPrincipal = new Panel();
            panel1 = new Panel();
            TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            principal = new TabPage();
            BtnSalir = new Button();
            pictureBox6 = new PictureBox();
            tablas = new TabPage();
            btnCategorias = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            pictureBox2 = new PictureBox();
            facturacion = new TabPage();
            btnInformes = new Button();
            btnFacturacion = new Button();
            pictureBox5 = new PictureBox();
            seguridad = new TabPage();
            btnSeguridad = new Button();
            btnRoles = new Button();
            btnEmpleados = new Button();
            pictureBox3 = new PictureBox();
            ayuda = new TabPage();
            btnAyuda = new Button();
            btnAcerca = new Button();
            pictureBox4 = new PictureBox();
            TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            pnlPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            TbpMenu.SuspendLayout();
            principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(282, 231);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = SystemColors.ButtonFace;
            pnlPrincipal.Controls.Add(panel1);
            pnlPrincipal.Location = new Point(1, 60);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1287, 730);
            pnlPrincipal.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(TbpMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 730);
            panel1.TabIndex = 0;
            // 
            // TbpMenu
            // 
            TbpMenu.Controls.Add(principal);
            TbpMenu.Controls.Add(tablas);
            TbpMenu.Controls.Add(facturacion);
            TbpMenu.Controls.Add(seguridad);
            TbpMenu.Controls.Add(ayuda);
            TbpMenu.Depth = 0;
            TbpMenu.Dock = DockStyle.Fill;
            TbpMenu.Location = new Point(0, 0);
            TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            TbpMenu.Multiline = true;
            TbpMenu.Name = "TbpMenu";
            TbpMenu.SelectedIndex = 0;
            TbpMenu.Size = new Size(178, 730);
            TbpMenu.TabIndex = 0;
            // 
            // principal
            // 
            principal.BackColor = Color.CornflowerBlue;
            principal.Controls.Add(BtnSalir);
            principal.Controls.Add(pictureBox6);
            principal.ForeColor = SystemColors.ControlText;
            principal.Location = new Point(4, 79);
            principal.Name = "principal";
            principal.Padding = new Padding(3);
            principal.Size = new Size(170, 647);
            principal.TabIndex = 0;
            principal.Text = "PRINCIPAL";
            // 
            // BtnSalir
            // 
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.ButtonFace;
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(6, 322);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(161, 70);
            BtnSalir.TabIndex = 3;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(128, 128);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // tablas
            // 
            tablas.BackColor = Color.CornflowerBlue;
            tablas.Controls.Add(btnCategorias);
            tablas.Controls.Add(btnProductos);
            tablas.Controls.Add(btnClientes);
            tablas.Controls.Add(pictureBox2);
            tablas.Location = new Point(4, 79);
            tablas.Name = "tablas";
            tablas.Padding = new Padding(3);
            tablas.Size = new Size(170, 647);
            tablas.TabIndex = 1;
            tablas.Text = "TABLAS";
            // 
            // btnCategorias
            // 
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = SystemColors.ButtonFace;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(-1, 396);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(212, 63);
            btnCategorias.TabIndex = 6;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ButtonFace;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 305);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(211, 63);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ButtonFace;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(3, 207);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(191, 63);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // facturacion
            // 
            facturacion.BackColor = Color.CornflowerBlue;
            facturacion.Controls.Add(btnInformes);
            facturacion.Controls.Add(btnFacturacion);
            facturacion.Controls.Add(pictureBox5);
            facturacion.Location = new Point(4, 79);
            facturacion.Name = "facturacion";
            facturacion.Size = new Size(170, 647);
            facturacion.TabIndex = 2;
            facturacion.Text = "FACTURACIÓN";
            // 
            // btnInformes
            // 
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInformes.ForeColor = SystemColors.ButtonFace;
            btnInformes.Image = (Image)resources.GetObject("btnInformes.Image");
            btnInformes.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformes.Location = new Point(0, 304);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(211, 63);
            btnInformes.TabIndex = 7;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturacion.ForeColor = SystemColors.ButtonFace;
            btnFacturacion.Image = (Image)resources.GetObject("btnFacturacion.Image");
            btnFacturacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.Location = new Point(0, 188);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(211, 65);
            btnFacturacion.TabIndex = 6;
            btnFacturacion.Text = "Facturas";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(128, 128);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // seguridad
            // 
            seguridad.BackColor = Color.CornflowerBlue;
            seguridad.Controls.Add(btnSeguridad);
            seguridad.Controls.Add(btnRoles);
            seguridad.Controls.Add(btnEmpleados);
            seguridad.Controls.Add(pictureBox3);
            seguridad.Location = new Point(4, 79);
            seguridad.Name = "seguridad";
            seguridad.Size = new Size(170, 647);
            seguridad.TabIndex = 3;
            seguridad.Text = "SEGURIDAD";
            // 
            // btnSeguridad
            // 
            btnSeguridad.FlatAppearance.BorderSize = 0;
            btnSeguridad.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnSeguridad.FlatStyle = FlatStyle.Flat;
            btnSeguridad.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeguridad.ForeColor = SystemColors.ButtonFace;
            btnSeguridad.Image = (Image)resources.GetObject("btnSeguridad.Image");
            btnSeguridad.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeguridad.Location = new Point(-1, 376);
            btnSeguridad.Name = "btnSeguridad";
            btnSeguridad.Size = new Size(211, 63);
            btnSeguridad.TabIndex = 8;
            btnSeguridad.Text = "Seguridad";
            btnSeguridad.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoles.ForeColor = SystemColors.ButtonFace;
            btnRoles.Image = (Image)resources.GetObject("btnRoles.Image");
            btnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoles.Location = new Point(-1, 273);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(170, 73);
            btnRoles.TabIndex = 7;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = SystemColors.ButtonFace;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(-1, 179);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(211, 63);
            btnEmpleados.TabIndex = 6;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // ayuda
            // 
            ayuda.BackColor = Color.CornflowerBlue;
            ayuda.Controls.Add(btnAyuda);
            ayuda.Controls.Add(btnAcerca);
            ayuda.Controls.Add(pictureBox4);
            ayuda.Location = new Point(4, 79);
            ayuda.Name = "ayuda";
            ayuda.Size = new Size(170, 647);
            ayuda.TabIndex = 4;
            ayuda.Text = "AYUDA";
            // 
            // btnAyuda
            // 
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = SystemColors.ButtonFace;
            btnAyuda.Image = (Image)resources.GetObject("btnAyuda.Image");
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(0, 215);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(167, 72);
            btnAyuda.TabIndex = 7;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnAcerca
            // 
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcerca.ForeColor = SystemColors.ButtonFace;
            btnAcerca.Image = (Image)resources.GetObject("btnAcerca.Image");
            btnAcerca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcerca.Location = new Point(-4, 306);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(174, 84);
            btnAcerca.TabIndex = 6;
            btnAcerca.Text = "Acerca de..";
            btnAcerca.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // TabOpcionesMenu
            // 
            TabOpcionesMenu.BaseTabControl = TbpMenu;
            TabOpcionesMenu.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            TabOpcionesMenu.Depth = 0;
            TabOpcionesMenu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TabOpcionesMenu.Location = new Point(282, 25);
            TabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            TabOpcionesMenu.Name = "TabOpcionesMenu";
            TabOpcionesMenu.Size = new Size(912, 40);
            TabOpcionesMenu.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1067, 692);
            Controls.Add(pnlPrincipal);
            Controls.Add(TabOpcionesMenu);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE FACTURACIÓN";
            Load += button1_Click;
            pnlPrincipal.ResumeLayout(false);
            panel1.ResumeLayout(false);
            TbpMenu.ResumeLayout(false);
            principal.ResumeLayout(false);
            principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tablas.ResumeLayout(false);
            tablas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            facturacion.ResumeLayout(false);
            facturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            seguridad.ResumeLayout(false);
            seguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ayuda.ResumeLayout(false);
            ayuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Panel pnlPrincipal;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private TabPage principal;
        private TabPage tablas;
        private TabPage facturacion;
        private TabPage seguridad;
        private TabPage ayuda;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcionesMenu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Button BtnSalir;
        private Button btnClientes;
        private Button btnCategorias;
        private Button btnProductos;
        private Button btnInformes;
        private Button btnFacturacion;
        private Button btnSeguridad;
        private Button btnRoles;
        private Button btnEmpleados;
        private Button btnAyuda;
        private Button btnAcerca;
    }
}
