
namespace Test.WindowsForms
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.lblListadoVehiculos = new System.Windows.Forms.Label();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPorcentajeAutos = new System.Windows.Forms.Label();
            this.txtPorcentajeAutos = new System.Windows.Forms.TextBox();
            this.lblPorcentajeSuvs = new System.Windows.Forms.Label();
            this.txtPorcentajeSuvs = new System.Windows.Forms.TextBox();
            this.lblAutos = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.txtSuvs = new System.Windows.Forms.TextBox();
            this.txtAutos = new System.Windows.Forms.TextBox();
            this.lblSuvs = new System.Windows.Forms.Label();
            this.txtModeloMasVendido = new System.Windows.Forms.TextBox();
            this.lblModeloMasVendido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoVehiculos
            // 
            this.lblListadoVehiculos.AutoSize = true;
            this.lblListadoVehiculos.Location = new System.Drawing.Point(13, 205);
            this.lblListadoVehiculos.Name = "lblListadoVehiculos";
            this.lblListadoVehiculos.Size = new System.Drawing.Size(165, 15);
            this.lblListadoVehiculos.TabIndex = 5;
            this.lblListadoVehiculos.Text = "Listado de Vehículos Vendidos";
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 15;
            this.lstVehiculos.Location = new System.Drawing.Point(12, 224);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(657, 214);
            this.lstVehiculos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 160);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblPorcentajeAutos
            // 
            this.lblPorcentajeAutos.AutoSize = true;
            this.lblPorcentajeAutos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeAutos.Location = new System.Drawing.Point(218, 117);
            this.lblPorcentajeAutos.Name = "lblPorcentajeAutos";
            this.lblPorcentajeAutos.Size = new System.Drawing.Size(107, 32);
            this.lblPorcentajeAutos.TabIndex = 9;
            this.lblPorcentajeAutos.Text = "% Autos:";
            // 
            // txtPorcentajeAutos
            // 
            this.txtPorcentajeAutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPorcentajeAutos.Location = new System.Drawing.Point(332, 126);
            this.txtPorcentajeAutos.Name = "txtPorcentajeAutos";
            this.txtPorcentajeAutos.ReadOnly = true;
            this.txtPorcentajeAutos.Size = new System.Drawing.Size(87, 23);
            this.txtPorcentajeAutos.TabIndex = 10;
            // 
            // lblPorcentajeSuvs
            // 
            this.lblPorcentajeSuvs.AutoSize = true;
            this.lblPorcentajeSuvs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeSuvs.Location = new System.Drawing.Point(218, 149);
            this.lblPorcentajeSuvs.Name = "lblPorcentajeSuvs";
            this.lblPorcentajeSuvs.Size = new System.Drawing.Size(95, 32);
            this.lblPorcentajeSuvs.TabIndex = 11;
            this.lblPorcentajeSuvs.Text = "% Suvs:";
            // 
            // txtPorcentajeSuvs
            // 
            this.txtPorcentajeSuvs.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPorcentajeSuvs.Location = new System.Drawing.Point(332, 158);
            this.txtPorcentajeSuvs.Name = "txtPorcentajeSuvs";
            this.txtPorcentajeSuvs.ReadOnly = true;
            this.txtPorcentajeSuvs.Size = new System.Drawing.Size(87, 23);
            this.txtPorcentajeSuvs.TabIndex = 12;
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutos.Location = new System.Drawing.Point(218, 53);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(80, 32);
            this.lblAutos.TabIndex = 18;
            this.lblAutos.Text = "Autos:";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotales.Location = new System.Drawing.Point(220, 24);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(93, 32);
            this.lblTotales.TabIndex = 16;
            this.lblTotales.Text = "Totales:";
            // 
            // txtTotales
            // 
            this.txtTotales.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotales.Location = new System.Drawing.Point(331, 33);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.ReadOnly = true;
            this.txtTotales.Size = new System.Drawing.Size(87, 23);
            this.txtTotales.TabIndex = 17;
            // 
            // txtSuvs
            // 
            this.txtSuvs.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSuvs.Location = new System.Drawing.Point(332, 94);
            this.txtSuvs.Name = "txtSuvs";
            this.txtSuvs.ReadOnly = true;
            this.txtSuvs.Size = new System.Drawing.Size(87, 23);
            this.txtSuvs.TabIndex = 21;
            // 
            // txtAutos
            // 
            this.txtAutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAutos.Location = new System.Drawing.Point(332, 62);
            this.txtAutos.Name = "txtAutos";
            this.txtAutos.ReadOnly = true;
            this.txtAutos.Size = new System.Drawing.Size(87, 23);
            this.txtAutos.TabIndex = 19;
            // 
            // lblSuvs
            // 
            this.lblSuvs.AutoSize = true;
            this.lblSuvs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSuvs.Location = new System.Drawing.Point(218, 85);
            this.lblSuvs.Name = "lblSuvs";
            this.lblSuvs.Size = new System.Drawing.Size(68, 32);
            this.lblSuvs.TabIndex = 20;
            this.lblSuvs.Text = "Suvs:";
            // 
            // txModeloMasVendido
            // 
            this.txtModeloMasVendido.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtModeloMasVendido.Location = new System.Drawing.Point(435, 53);
            this.txtModeloMasVendido.Name = "txModeloMasVendido";
            this.txtModeloMasVendido.ReadOnly = true;
            this.txtModeloMasVendido.Size = new System.Drawing.Size(87, 23);
            this.txtModeloMasVendido.TabIndex = 23;
            // 
            // lblModeloMasVendido
            // 
            this.lblModeloMasVendido.AutoSize = true;
            this.lblModeloMasVendido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModeloMasVendido.Location = new System.Drawing.Point(435, 24);
            this.lblModeloMasVendido.Name = "lblModeloMasVendido";
            this.lblModeloMasVendido.Size = new System.Drawing.Size(193, 25);
            this.lblModeloMasVendido.TabIndex = 22;
            this.lblModeloMasVendido.Text = "Modelo más vendido:";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 451);
            this.Controls.Add(this.txtModeloMasVendido);
            this.Controls.Add(this.lblModeloMasVendido);
            this.Controls.Add(this.txtSuvs);
            this.Controls.Add(this.lblSuvs);
            this.Controls.Add(this.txtAutos);
            this.Controls.Add(this.lblAutos);
            this.Controls.Add(this.txtTotales);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.txtPorcentajeSuvs);
            this.Controls.Add(this.lblPorcentajeSuvs);
            this.Controls.Add(this.txtPorcentajeAutos);
            this.Controls.Add(this.lblPorcentajeAutos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblListadoVehiculos);
            this.Controls.Add(this.lstVehiculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla de Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoVehiculos;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPorcentajeAutos;
        private System.Windows.Forms.TextBox txtPorcentajeAutos;
        private System.Windows.Forms.Label lblPorcentajeSuvs;
        private System.Windows.Forms.TextBox txtPorcentajeSuvs;
        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.TextBox txtSuvs;
        private System.Windows.Forms.TextBox txtAutos;
        private System.Windows.Forms.Label lblSuvs;
        private System.Windows.Forms.TextBox txtModeloMasVendido;
        private System.Windows.Forms.Label lblModeloMasVendido;
    }
}