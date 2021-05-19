namespace InventarioFarm_version3
{
    partial class MantoProveedores
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarProve = new System.Windows.Forms.TextBox();
            this.DGVproveedor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtDireccionP = new System.Windows.Forms.TextBox();
            this.txtCiudadP = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmailP = new System.Windows.Forms.TextBox();
            this.btnInsertarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnActualizarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Informacion del Proveedor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Proveedor";
            // 
            // txtBuscarProve
            // 
            this.txtBuscarProve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarProve.Location = new System.Drawing.Point(246, 81);
            this.txtBuscarProve.Name = "txtBuscarProve";
            this.txtBuscarProve.Size = new System.Drawing.Size(164, 26);
            this.txtBuscarProve.TabIndex = 2;
            this.txtBuscarProve.TextChanged += new System.EventHandler(this.txtBuscarProve_TextChanged);
            // 
            // DGVproveedor
            // 
            this.DGVproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproveedor.Location = new System.Drawing.Point(36, 145);
            this.DGVproveedor.Name = "DGVproveedor";
            this.DGVproveedor.RowTemplate.Height = 28;
            this.DGVproveedor.Size = new System.Drawing.Size(1148, 198);
            this.DGVproveedor.TabIndex = 3;
            this.DGVproveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproveedor_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IdProveedor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NombreContacto";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Empresa";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(912, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ciudad";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Region";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "CodPostal";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(916, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(704, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Pais";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Email";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdProveedor.Location = new System.Drawing.Point(177, 380);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(58, 26);
            this.txtIdProveedor.TabIndex = 14;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpresa.Location = new System.Drawing.Point(394, 380);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(124, 26);
            this.txtEmpresa.TabIndex = 15;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreP.Location = new System.Drawing.Point(727, 380);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(139, 26);
            this.txtNombreP.TabIndex = 16;
            // 
            // txtDireccionP
            // 
            this.txtDireccionP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccionP.Location = new System.Drawing.Point(1027, 380);
            this.txtDireccionP.Name = "txtDireccionP";
            this.txtDireccionP.Size = new System.Drawing.Size(130, 26);
            this.txtDireccionP.TabIndex = 17;
            // 
            // txtCiudadP
            // 
            this.txtCiudadP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCiudadP.Location = new System.Drawing.Point(114, 431);
            this.txtCiudadP.Name = "txtCiudadP";
            this.txtCiudadP.Size = new System.Drawing.Size(105, 26);
            this.txtCiudadP.TabIndex = 18;
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegion.Location = new System.Drawing.Point(351, 431);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(105, 26);
            this.txtRegion.TabIndex = 19;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPostal.Location = new System.Drawing.Point(596, 431);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(84, 26);
            this.txtCodPostal.TabIndex = 20;
            // 
            // txtPais
            // 
            this.txtPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPais.Location = new System.Drawing.Point(788, 431);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(105, 26);
            this.txtPais.TabIndex = 21;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Location = new System.Drawing.Point(1052, 431);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(105, 26);
            this.txtTelefono.TabIndex = 22;
            // 
            // txtEmailP
            // 
            this.txtEmailP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailP.Location = new System.Drawing.Point(123, 484);
            this.txtEmailP.Name = "txtEmailP";
            this.txtEmailP.Size = new System.Drawing.Size(112, 26);
            this.txtEmailP.TabIndex = 23;
            // 
            // btnInsertarP
            // 
            this.btnInsertarP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertarP.BackColor = System.Drawing.Color.Purple;
            this.btnInsertarP.ForeColor = System.Drawing.Color.White;
            this.btnInsertarP.Location = new System.Drawing.Point(94, 568);
            this.btnInsertarP.Name = "btnInsertarP";
            this.btnInsertarP.Size = new System.Drawing.Size(175, 48);
            this.btnInsertarP.TabIndex = 24;
            this.btnInsertarP.Text = "Insertar Proveedor";
            this.btnInsertarP.UseVisualStyleBackColor = false;
            this.btnInsertarP.Click += new System.EventHandler(this.btnInsertarP_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarP.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarP.ForeColor = System.Drawing.Color.White;
            this.btnEliminarP.Location = new System.Drawing.Point(343, 568);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(175, 48);
            this.btnEliminarP.TabIndex = 25;
            this.btnEliminarP.Text = "Eliminar Proveedor";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnActualizarP
            // 
            this.btnActualizarP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarP.BackColor = System.Drawing.Color.Purple;
            this.btnActualizarP.ForeColor = System.Drawing.Color.White;
            this.btnActualizarP.Location = new System.Drawing.Point(596, 568);
            this.btnActualizarP.Name = "btnActualizarP";
            this.btnActualizarP.Size = new System.Drawing.Size(193, 48);
            this.btnActualizarP.TabIndex = 26;
            this.btnActualizarP.Text = "Actualizar Proveedor";
            this.btnActualizarP.UseVisualStyleBackColor = false;
            this.btnActualizarP.Click += new System.EventHandler(this.btnActualizarP_Click);
            // 
            // MantoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 639);
            this.Controls.Add(this.btnActualizarP);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnInsertarP);
            this.Controls.Add(this.txtEmailP);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCiudadP);
            this.Controls.Add(this.txtDireccionP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVproveedor);
            this.Controls.Add(this.txtBuscarProve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantoProveedores";
            this.Text = "MantoProveedores";
            this.Load += new System.EventHandler(this.MantoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarProve;
        private System.Windows.Forms.DataGridView DGVproveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtDireccionP;
        private System.Windows.Forms.TextBox txtCiudadP;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmailP;
        private System.Windows.Forms.Button btnInsertarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnActualizarP;
    }
}