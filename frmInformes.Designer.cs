namespace Pantallas_Sistema_facturacion
{
    partial class frmInformes
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
            ordenar = new Panel();
            btnExcel = new RadioButton();
            btnPdf = new RadioButton();
            btnEnpantalla = new RadioButton();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            fechafinal = new Label();
            label3 = new Label();
            fechainicio = new Label();
            informe = new Label();
            btnSalir = new Button();
            btnInforme = new Button();
            panel1 = new Panel();
            ordenar.SuspendLayout();
            SuspendLayout();
            // 
            // ordenar
            // 
            ordenar.BackColor = SystemColors.ControlLight;
            ordenar.Controls.Add(btnExcel);
            ordenar.Controls.Add(btnPdf);
            ordenar.Controls.Add(btnEnpantalla);
            ordenar.Controls.Add(dateTimePicker2);
            ordenar.Controls.Add(dateTimePicker1);
            ordenar.Controls.Add(comboBox2);
            ordenar.Controls.Add(comboBox1);
            ordenar.Controls.Add(fechafinal);
            ordenar.Controls.Add(label3);
            ordenar.Controls.Add(fechainicio);
            ordenar.Controls.Add(informe);
            ordenar.Controls.Add(btnSalir);
            ordenar.Controls.Add(btnInforme);
            ordenar.Location = new Point(6, 67);
            ordenar.Name = "ordenar";
            ordenar.Size = new Size(1050, 374);
            ordenar.TabIndex = 0;
            // 
            // btnExcel
            // 
            btnExcel.AutoSize = true;
            btnExcel.Font = new Font("Arial", 9F);
            btnExcel.Location = new Point(655, 235);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(65, 21);
            btnExcel.TabIndex = 12;
            btnExcel.TabStop = true;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            btnPdf.AutoSize = true;
            btnPdf.Font = new Font("Arial", 9F);
            btnPdf.Location = new Point(429, 235);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(51, 21);
            btnPdf.TabIndex = 11;
            btnPdf.TabStop = true;
            btnPdf.Text = "Pdf";
            btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnEnpantalla
            // 
            btnEnpantalla.AutoSize = true;
            btnEnpantalla.Font = new Font("Arial", 9F);
            btnEnpantalla.Location = new Point(170, 235);
            btnEnpantalla.Name = "btnEnpantalla";
            btnEnpantalla.Size = new Size(103, 21);
            btnEnpantalla.TabIndex = 10;
            btnEnpantalla.TabStop = true;
            btnEnpantalla.Text = "En Pantalla";
            btnEnpantalla.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Arial", 10.8F);
            dateTimePicker2.Location = new Point(609, 149);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 28);
            dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 10.8F);
            dateTimePicker1.Font = new Font("Arial", 10.8F);
            dateTimePicker1.Location = new Point(170, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Arial", 10.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(765, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 29);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 10.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(245, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(347, 29);
            comboBox1.TabIndex = 6;
            // 
            // fechafinal
            // 
            fechafinal.AutoSize = true;
            fechafinal.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            fechafinal.Location = new Point(481, 153);
            fechafinal.Name = "fechafinal";
            fechafinal.Size = new Size(98, 21);
            fechafinal.TabIndex = 5;
            fechafinal.Text = "Fecha final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            label3.Location = new Point(629, 54);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 4;
            label3.Text = "Ordenar por";
            // 
            // fechainicio
            // 
            fechainicio.AutoSize = true;
            fechainicio.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            fechainicio.Location = new Point(46, 153);
            fechainicio.Name = "fechainicio";
            fechainicio.Size = new Size(106, 21);
            fechainicio.TabIndex = 3;
            fechainicio.Text = "Fecha Inicio";
            // 
            // informe
            // 
            informe.AutoSize = true;
            informe.Font = new Font("Arial", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            informe.Location = new Point(46, 54);
            informe.Name = "informe";
            informe.Size = new Size(167, 21);
            informe.TabIndex = 2;
            informe.Text = "Seleccione Informe ";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ButtonShadow;
            btnSalir.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(655, 293);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 47);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInforme
            // 
            btnInforme.BackColor = SystemColors.ButtonShadow;
            btnInforme.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInforme.Location = new Point(170, 293);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(242, 47);
            btnInforme.TabIndex = 0;
            btnInforme.Text = "GENERAR INFORME";
            btnInforme.UseVisualStyleBackColor = false;
            btnInforme.Click += btnInforme_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(6, 442);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 203);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 651);
            Controls.Add(panel1);
            Controls.Add(ordenar);
            DrawerAutoHide = false;
            Name = "frmInformes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                                     GENERADOR DE INFORMES DE FACTURACIÓN";
            ordenar.ResumeLayout(false);
            ordenar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ordenar;
        private Label fechafinal;
        private Label label3;
        private Label fechainicio;
        private Label informe;
        private Button btnSalir;
        private Button btnInforme;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel panel1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private RadioButton btnExcel;
        private RadioButton btnPdf;
        private RadioButton btnEnpantalla;
    }
}