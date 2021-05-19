namespace InventarioFarm_version3
{
    partial class MantoIngresos
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
            this.DVGIngresos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidI = new System.Windows.Forms.TextBox();
            this.cmbIdP = new System.Windows.Forms.ComboBox();
            this.cmbIdB = new System.Windows.Forms.ComboBox();
            this.txtfechaR = new System.Windows.Forms.MaskedTextBox();
            this.txtNfactura = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.cmbIdM = new System.Windows.Forms.ComboBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.btnInsertarI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DVGIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la informacion del Ingreso";
            // 
            // DVGIngresos
            // 
            this.DVGIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGIngresos.Location = new System.Drawing.Point(41, 177);
            this.DVGIngresos.Name = "DVGIngresos";
            this.DVGIngresos.RowTemplate.Height = 28;
            this.DVGIngresos.Size = new System.Drawing.Size(1141, 359);
            this.DVGIngresos.TabIndex = 1;
            this.DVGIngresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVGIngresos_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IdIngreso";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "IdProducto";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IdBodega";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(848, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "FechaRegistro";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 649);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "NFactura";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 649);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "IdMarca";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(969, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 711);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Costo";
            // 
            // txtidI
            // 
            this.txtidI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidI.Location = new System.Drawing.Point(141, 590);
            this.txtidI.Name = "txtidI";
            this.txtidI.Size = new System.Drawing.Size(58, 26);
            this.txtidI.TabIndex = 11;
            // 
            // cmbIdP
            // 
            this.cmbIdP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdP.FormattingEnabled = true;
            this.cmbIdP.Location = new System.Drawing.Point(362, 590);
            this.cmbIdP.Name = "cmbIdP";
            this.cmbIdP.Size = new System.Drawing.Size(121, 28);
            this.cmbIdP.TabIndex = 12;
            // 
            // cmbIdB
            // 
            this.cmbIdB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdB.FormattingEnabled = true;
            this.cmbIdB.Location = new System.Drawing.Point(668, 590);
            this.cmbIdB.Name = "cmbIdB";
            this.cmbIdB.Size = new System.Drawing.Size(121, 28);
            this.cmbIdB.TabIndex = 13;
            // 
            // txtfechaR
            // 
            this.txtfechaR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfechaR.Location = new System.Drawing.Point(1003, 590);
            this.txtfechaR.Name = "txtfechaR";
            this.txtfechaR.Size = new System.Drawing.Size(100, 26);
            this.txtfechaR.TabIndex = 14;
            // 
            // txtNfactura
            // 
            this.txtNfactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNfactura.Location = new System.Drawing.Point(141, 646);
            this.txtNfactura.Name = "txtNfactura";
            this.txtNfactura.Size = new System.Drawing.Size(58, 26);
            this.txtNfactura.TabIndex = 15;
            // 
            // txtdesc
            // 
            this.txtdesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdesc.Location = new System.Drawing.Point(387, 646);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(257, 26);
            this.txtdesc.TabIndex = 16;
            // 
            // cmbIdM
            // 
            this.cmbIdM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdM.FormattingEnabled = true;
            this.cmbIdM.Location = new System.Drawing.Point(800, 646);
            this.cmbIdM.Name = "cmbIdM";
            this.cmbIdM.Size = new System.Drawing.Size(121, 28);
            this.cmbIdM.TabIndex = 17;
            // 
            // txtcant
            // 
            this.txtcant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcant.Location = new System.Drawing.Point(1058, 646);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(71, 26);
            this.txtcant.TabIndex = 18;
            // 
            // txtcosto
            // 
            this.txtcosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcosto.Location = new System.Drawing.Point(103, 708);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(70, 26);
            this.txtcosto.TabIndex = 19;
            // 
            // btnInsertarI
            // 
            this.btnInsertarI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertarI.BackColor = System.Drawing.Color.Purple;
            this.btnInsertarI.ForeColor = System.Drawing.Color.White;
            this.btnInsertarI.Location = new System.Drawing.Point(30, 790);
            this.btnInsertarI.Name = "btnInsertarI";
            this.btnInsertarI.Size = new System.Drawing.Size(175, 48);
            this.btnInsertarI.TabIndex = 26;
            this.btnInsertarI.Text = "Insertar ";
            this.btnInsertarI.UseVisualStyleBackColor = false;
            this.btnInsertarI.Click += new System.EventHandler(this.btnInsertarI_Click);
            // 
            // MantoIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 850);
            this.Controls.Add(this.btnInsertarI);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.cmbIdM);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtNfactura);
            this.Controls.Add(this.txtfechaR);
            this.Controls.Add(this.cmbIdB);
            this.Controls.Add(this.cmbIdP);
            this.Controls.Add(this.txtidI);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DVGIngresos);
            this.Controls.Add(this.label1);
            this.Name = "MantoIngresos";
            this.Text = "MantoIngresos";
            this.Load += new System.EventHandler(this.MantoIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DVGIngresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtidI;
        private System.Windows.Forms.ComboBox cmbIdP;
        private System.Windows.Forms.ComboBox cmbIdB;
        private System.Windows.Forms.MaskedTextBox txtfechaR;
        private System.Windows.Forms.TextBox txtNfactura;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.ComboBox cmbIdM;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Button btnInsertarI;
    }
}