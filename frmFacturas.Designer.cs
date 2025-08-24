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
            cleinte = new MaterialSkin.Controls.MaterialLabel();
            empleado = new MaterialSkin.Controls.MaterialLabel();
            totalIva = new MaterialSkin.Controls.MaterialLabel();
            Tfactura = new MaterialSkin.Controls.MaterialLabel();
            fRegistro = new MaterialSkin.Controls.MaterialLabel();
            estadoF = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
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
            titulofacturas.Size = new Size(214, 19);
            titulofacturas.TabIndex = 0;
            titulofacturas.Text = "ADMINISTRACIÓN FACTURAS";
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
            nroFactura.Size = new Size(84, 19);
            nroFactura.TabIndex = 1;
            nroFactura.Text = "Nro Factura";
            // 
            // cleinte
            // 
            cleinte.AutoSize = true;
            cleinte.Depth = 0;
            cleinte.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cleinte.Location = new Point(64, 163);
            cleinte.MouseState = MaterialSkin.MouseState.HOVER;
            cleinte.Name = "cleinte";
            cleinte.Size = new Size(49, 19);
            cleinte.TabIndex = 2;
            cleinte.Text = "Cliente";
            // 
            // empleado
            // 
            empleado.AutoSize = true;
            empleado.Depth = 0;
            empleado.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            empleado.Location = new Point(64, 217);
            empleado.MouseState = MaterialSkin.MouseState.HOVER;
            empleado.Name = "empleado";
            empleado.Size = new Size(72, 19);
            empleado.TabIndex = 3;
            empleado.Text = "Empleado";
            // 
            // totalIva
            // 
            totalIva.AutoSize = true;
            totalIva.Depth = 0;
            totalIva.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalIva.Location = new Point(64, 284);
            totalIva.MouseState = MaterialSkin.MouseState.HOVER;
            totalIva.Name = "totalIva";
            totalIva.Size = new Size(66, 19);
            totalIva.TabIndex = 4;
            totalIva.Text = "Total IVA";
            // 
            // Tfactura
            // 
            Tfactura.AutoSize = true;
            Tfactura.Depth = 0;
            Tfactura.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tfactura.Location = new Point(64, 352);
            Tfactura.MouseState = MaterialSkin.MouseState.HOVER;
            Tfactura.Name = "Tfactura";
            Tfactura.Size = new Size(96, 19);
            Tfactura.TabIndex = 5;
            Tfactura.Text = "Total Factura";
            Tfactura.Click += materialLabel5_Click;
            // 
            // fRegistro
            // 
            fRegistro.AutoSize = true;
            fRegistro.Depth = 0;
            fRegistro.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fRegistro.Location = new Point(650, 163);
            fRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            fRegistro.Name = "fRegistro";
            fRegistro.Size = new Size(110, 19);
            fRegistro.TabIndex = 6;
            fRegistro.Text = "Fecha Registro ";
            // 
            // estadoF
            // 
            estadoF.AutoSize = true;
            estadoF.Depth = 0;
            estadoF.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            estadoF.Location = new Point(650, 236);
            estadoF.MouseState = MaterialSkin.MouseState.HOVER;
            estadoF.Name = "estadoF";
            estadoF.Size = new Size(108, 19);
            estadoF.TabIndex = 7;
            estadoF.Text = "Estado Factura";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(627, 304);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(107, 19);
            materialLabel8.TabIndex = 8;
            materialLabel8.Text = "materialLabel8";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(586, 384);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(107, 19);
            materialLabel9.TabIndex = 9;
            materialLabel9.Text = "materialLabel9";
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(832, 603);
            Controls.Add(materialLabel9);
            Controls.Add(materialLabel8);
            Controls.Add(estadoF);
            Controls.Add(fRegistro);
            Controls.Add(Tfactura);
            Controls.Add(totalIva);
            Controls.Add(empleado);
            Controls.Add(cleinte);
            Controls.Add(nroFactura);
            Controls.Add(titulofacturas);
            Name = "frmFacturas";
            Text = "frmFacturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel titulofacturas;
        private MaterialSkin.Controls.MaterialLabel nroFactura;
        private MaterialSkin.Controls.MaterialLabel cleinte;
        private MaterialSkin.Controls.MaterialLabel empleado;
        private MaterialSkin.Controls.MaterialLabel totalIva;
        private MaterialSkin.Controls.MaterialLabel Tfactura;
        private MaterialSkin.Controls.MaterialLabel fRegistro;
        private MaterialSkin.Controls.MaterialLabel estadoF;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}