namespace Pantallas_Sistema_facturacion
{
    partial class frmFacturas
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
            titulofacturas = new MaterialSkin.Controls.MaterialLabel();
            nroFactura = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            eFactura = new Label();
            fRegistro = new Label();
            tIVA = new Label();
            descuento = new Label();
            empleado = new Label();
            cliente = new Label();
            tFactura = new Label();
            nFactura = new Label();
            btnActualizar = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titulofacturas
            // 
            titulofacturas.AutoSize = true;
            titulofacturas.Depth = 0;
            titulofacturas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            titulofacturas.Location = new Point(278, 57);
            titulofacturas.MouseState = MaterialSkin.MouseState.HOVER;
            titulofacturas.Name = "titulofacturas";
            titulofacturas.Size = new Size(1, 0);
            titulofacturas.TabIndex = 0;
            titulofacturas.Click += materialLabel1_Click;
            // 
            // nroFactura
            // 
            nroFactura.AutoSize = true;
            nroFactura.Depth = 0;
            nroFactura.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nroFactura.Location = new Point(64, 110);
            nroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            nroFactura.Name = "nroFactura";
            nroFactura.Size = new Size(1, 0);
            nroFactura.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(eFactura);
            panel1.Controls.Add(fRegistro);
            panel1.Controls.Add(tIVA);
            panel1.Controls.Add(descuento);
            panel1.Controls.Add(empleado);
            panel1.Controls.Add(cliente);
            panel1.Controls.Add(tFactura);
            panel1.Controls.Add(nFactura);
            panel1.Location = new Point(27, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 261);
            panel1.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(408, 171);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(131, 28);
            comboBox3.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(424, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 28);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 28);
            comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // eFactura
            // 
            eFactura.AutoSize = true;
            eFactura.Location = new Point(408, 140);
            eFactura.Name = "eFactura";
            eFactura.Size = new Size(109, 20);
            eFactura.TabIndex = 7;
            eFactura.Text = "Estado Factura ";
            // 
            // fRegistro
            // 
            fRegistro.AutoSize = true;
            fRegistro.Location = new Point(424, 30);
            fRegistro.Name = "fRegistro";
            fRegistro.Size = new Size(106, 20);
            fRegistro.TabIndex = 6;
            fRegistro.Text = "Fecha Registro";
            // 
            // tIVA
            // 
            tIVA.AutoSize = true;
            tIVA.Location = new Point(25, 179);
            tIVA.Name = "tIVA";
            tIVA.Size = new Size(68, 20);
            tIVA.TabIndex = 5;
            tIVA.Text = "Total IVA";
            // 
            // descuento
            // 
            descuento.AutoSize = true;
            descuento.Location = new Point(25, 140);
            descuento.Name = "descuento";
            descuento.Size = new Size(72, 20);
            descuento.TabIndex = 4;
            descuento.Text = "Desuento";
            // 
            // empleado
            // 
            empleado.AutoSize = true;
            empleado.Location = new Point(25, 107);
            empleado.Name = "empleado";
            empleado.Size = new Size(77, 20);
            empleado.TabIndex = 3;
            empleado.Text = "Empleado";
            empleado.Click += label4_Click;
            // 
            // cliente
            // 
            cliente.AutoSize = true;
            cliente.Location = new Point(25, 68);
            cliente.Name = "cliente";
            cliente.Size = new Size(55, 20);
            cliente.TabIndex = 2;
            cliente.Text = "Cliente";
            cliente.Click += label3_Click;
            // 
            // tFactura
            // 
            tFactura.AutoSize = true;
            tFactura.Location = new Point(25, 216);
            tFactura.Name = "tFactura";
            tFactura.Size = new Size(93, 20);
            tFactura.TabIndex = 1;
            tFactura.Text = "Total Factura";
            // 
            // nFactura
            // 
            nFactura.AutoSize = true;
            nFactura.Location = new Point(25, 30);
            nFactura.Name = "nFactura";
            nFactura.Size = new Size(85, 20);
            nFactura.TabIndex = 0;
            nFactura.Text = "Nro Factura";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkGray;
            btnActualizar.Location = new Point(639, 220);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 35);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(27, 430);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 135);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkGray;
            btnSalir.Location = new Point(656, 520);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 32);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Location = new Point(27, 394);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "DETALLE FACTURA";
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1067, 692);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(panel2);
            Controls.Add(btnActualizar);
            Controls.Add(panel1);
            Controls.Add(nroFactura);
            Controls.Add(titulofacturas);
            Name = "frmFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                                ADMINISTRACIÓN FACTURAS";
            Load += frmFacturas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel titulofacturas;
        private MaterialSkin.Controls.MaterialLabel nroFactura;
        private Panel panel1;
        private Button btnActualizar;
        private Panel panel2;
        private Button btnSalir;
        private Label eFactura;
        private Label fRegistro;
        private Label tIVA;
        private Label descuento;
        private Label empleado;
        private Label cliente;
        private Label tFactura;
        private Label nFactura;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}