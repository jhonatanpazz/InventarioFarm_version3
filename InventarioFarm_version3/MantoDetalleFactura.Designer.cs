namespace InventarioFarm_version3
{
    partial class MantoDetalleFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVdetalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidDFactura = new System.Windows.Forms.TextBox();
            this.cmbIdfactura = new System.Windows.Forms.ComboBox();
            this.cmbIdproducto = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresarDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Detalle de Factura";
            // 
            // DGVdetalle
            // 
            this.DGVdetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdetalle.Location = new System.Drawing.Point(43, 136);
            this.DGVdetalle.Name = "DGVdetalle";
            this.DGVdetalle.RowTemplate.Height = 28;
            this.DGVdetalle.Size = new System.Drawing.Size(904, 214);
            this.DGVdetalle.TabIndex = 1;
            this.DGVdetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IdDetalle";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "IdProducto";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IdFactura";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(779, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "FechaDetalle Factura";
            // 
            // txtidDFactura
            // 
            this.txtidDFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidDFactura.Location = new System.Drawing.Point(149, 424);
            this.txtidDFactura.Name = "txtidDFactura";
            this.txtidDFactura.Size = new System.Drawing.Size(57, 26);
            this.txtidDFactura.TabIndex = 7;
            // 
            // cmbIdfactura
            // 
            this.cmbIdfactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdfactura.FormattingEnabled = true;
            this.cmbIdfactura.Location = new System.Drawing.Point(366, 424);
            this.cmbIdfactura.Name = "cmbIdfactura";
            this.cmbIdfactura.Size = new System.Drawing.Size(84, 28);
            this.cmbIdfactura.TabIndex = 8;
            // 
            // cmbIdproducto
            // 
            this.cmbIdproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdproducto.FormattingEnabled = true;
            this.cmbIdproducto.Location = new System.Drawing.Point(650, 422);
            this.cmbIdproducto.Name = "cmbIdproducto";
            this.cmbIdproducto.Size = new System.Drawing.Size(104, 28);
            this.cmbIdproducto.TabIndex = 9;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcantidad.Location = new System.Drawing.Point(901, 424);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 26);
            this.txtcantidad.TabIndex = 10;
            // 
            // txtfecha
            // 
            this.txtfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfecha.Location = new System.Drawing.Point(245, 488);
            this.txtfecha.Mask = "00/00/0000";
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 26);
            this.txtfecha.TabIndex = 11;
            this.txtfecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnIngresarDetalle
            // 
            this.btnIngresarDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresarDetalle.BackColor = System.Drawing.Color.Purple;
            this.btnIngresarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnIngresarDetalle.Location = new System.Drawing.Point(43, 557);
            this.btnIngresarDetalle.Name = "btnIngresarDetalle";
            this.btnIngresarDetalle.Size = new System.Drawing.Size(176, 47);
            this.btnIngresarDetalle.TabIndex = 15;
            this.btnIngresarDetalle.Text = "Ingresar Detalle";
            this.btnIngresarDetalle.UseVisualStyleBackColor = false;
            this.btnIngresarDetalle.Click += new System.EventHandler(this.btnIngresarDetalle_Click);
            // 
            // MantoDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 659);
            this.Controls.Add(this.btnIngresarDetalle);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.cmbIdproducto);
            this.Controls.Add(this.cmbIdfactura);
            this.Controls.Add(this.txtidDFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVdetalle);
            this.Controls.Add(this.label1);
            this.Name = "MantoDetalleFactura";
            this.Text = "MantoDetalleFactura";
            this.Load += new System.EventHandler(this.MantoDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVdetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidDFactura;
        private System.Windows.Forms.ComboBox cmbIdfactura;
        private System.Windows.Forms.ComboBox cmbIdproducto;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.MaskedTextBox txtfecha;
        private System.Windows.Forms.Button btnIngresarDetalle;
    }
}