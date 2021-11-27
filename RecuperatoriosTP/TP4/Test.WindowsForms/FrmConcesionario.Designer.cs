
namespace Test.WindowsForms
{
    partial class FrmConcesionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConcesionario));
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblListadoVehiculos = new System.Windows.Forms.Label();
            this.lstOrdenamiento = new System.Windows.Forms.Label();
            this.cboOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnInformarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 15;
            this.lstVehiculos.Location = new System.Drawing.Point(11, 266);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(657, 214);
            this.lstVehiculos.TabIndex = 0;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(674, 315);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(113, 33);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(674, 354);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(113, 33);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblListadoVehiculos
            // 
            this.lblListadoVehiculos.AutoSize = true;
            this.lblListadoVehiculos.Location = new System.Drawing.Point(12, 247);
            this.lblListadoVehiculos.Name = "lblListadoVehiculos";
            this.lblListadoVehiculos.Size = new System.Drawing.Size(298, 15);
            this.lblListadoVehiculos.TabIndex = 3;
            this.lblListadoVehiculos.Text = "Listado de Vehículos - Capacidad Máxima: 10 Vehículos";
            // 
            // lstOrdenamiento
            // 
            this.lstOrdenamiento.AutoSize = true;
            this.lstOrdenamiento.Location = new System.Drawing.Point(676, 266);
            this.lstOrdenamiento.Name = "lstOrdenamiento";
            this.lstOrdenamiento.Size = new System.Drawing.Size(71, 15);
            this.lstOrdenamiento.TabIndex = 4;
            this.lstOrdenamiento.Text = "Ordenar por";
            // 
            // cboOrdenamiento
            // 
            this.cboOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenamiento.FormattingEnabled = true;
            this.cboOrdenamiento.Location = new System.Drawing.Point(675, 286);
            this.cboOrdenamiento.Name = "cboOrdenamiento";
            this.cboOrdenamiento.Size = new System.Drawing.Size(121, 23);
            this.cboOrdenamiento.TabIndex = 5;
            this.cboOrdenamiento.SelectedValueChanged += new System.EventHandler(this.cboOrdenamiento_SelectedValueChanged);
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIngresos.Location = new System.Drawing.Point(11, 491);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(108, 32);
            this.lblIngresos.TabIndex = 6;
            this.lblIngresos.Text = "Ingresos:";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEgresos.Location = new System.Drawing.Point(309, 491);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(100, 32);
            this.lblEgresos.TabIndex = 7;
            this.lblEgresos.Text = "Egresos:";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIngresos.Location = new System.Drawing.Point(125, 500);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.ReadOnly = true;
            this.txtIngresos.Size = new System.Drawing.Size(168, 23);
            this.txtIngresos.TabIndex = 8;
            // 
            // txtEgresos
            // 
            this.txtEgresos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEgresos.Location = new System.Drawing.Point(415, 500);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.ReadOnly = true;
            this.txtEgresos.Size = new System.Drawing.Size(168, 23);
            this.txtEgresos.TabIndex = 9;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(676, 502);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 23);
            this.cboCriterio.TabIndex = 11;
            this.cboCriterio.SelectedValueChanged += new System.EventHandler(this.cboCriterio_SelectedValueChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(676, 484);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(46, 15);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 271);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(674, 393);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(113, 42);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "GENERAR XML DE VENTAS";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnInformarVentas
            // 
            this.btnInformarVentas.Location = new System.Drawing.Point(674, 438);
            this.btnInformarVentas.Name = "btnInformarVentas";
            this.btnInformarVentas.Size = new System.Drawing.Size(113, 42);
            this.btnInformarVentas.TabIndex = 14;
            this.btnInformarVentas.Text = "PLANILLA DE VENTAS";
            this.btnInformarVentas.UseVisualStyleBackColor = true;
            this.btnInformarVentas.Click += new System.EventHandler(this.btnInformarVentas_Click);
            // 
            // FrmConcesionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.btnInformarVentas);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.lblEgresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.cboOrdenamiento);
            this.Controls.Add(this.lstOrdenamiento);
            this.Controls.Add(this.lblListadoVehiculos);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lstVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConcesionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concesionario Ford";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConcesionario_FormClosing);
            this.Load += new System.EventHandler(this.FrmConcesionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblListadoVehiculos;
        private System.Windows.Forms.Label lstOrdenamiento;
        private System.Windows.Forms.ComboBox cboOrdenamiento;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnInformarVentas;
    }
}

