namespace InventarioFarm_version3
{
    partial class MantoClientes
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
            this.DGVclientes = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtApellidoC = new System.Windows.Forms.TextBox();
            this.txtDireccionC = new System.Windows.Forms.TextBox();
            this.txtTelefonoC = new System.Windows.Forms.TextBox();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.btnInsertarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnActualizarC = new System.Windows.Forms.Button();
            this.ss = new MaterialSkin.Controls.MaterialLabel();
            this.txtbuscarCliente = new System.Windows.Forms.TextBox();
            this.btnReporteCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVclientes
            // 
            this.DGVclientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclientes.Location = new System.Drawing.Point(26, 86);
            this.DGVclientes.Name = "DGVclientes";
            this.DGVclientes.RowTemplate.Height = 28;
            this.DGVclientes.Size = new System.Drawing.Size(918, 186);
            this.DGVclientes.TabIndex = 1;
            this.DGVclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVclientes_CellContentClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 296);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(30, 27);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Id";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(90, 296);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(91, 27);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Nombre";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(284, 296);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(90, 27);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Apellido";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(470, 296);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(104, 27);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Direccion";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(659, 296);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(100, 27);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Telefono";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(782, 296);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(66, 27);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Email";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(17, 354);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(53, 26);
            this.txtIdCliente.TabIndex = 8;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreC.Location = new System.Drawing.Point(95, 354);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(176, 26);
            this.txtNombreC.TabIndex = 9;
            this.txtNombreC.TextChanged += new System.EventHandler(this.txtNombreC_TextChanged);
            // 
            // txtApellidoC
            // 
            this.txtApellidoC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidoC.Location = new System.Drawing.Point(289, 354);
            this.txtApellidoC.Name = "txtApellidoC";
            this.txtApellidoC.Size = new System.Drawing.Size(169, 26);
            this.txtApellidoC.TabIndex = 10;
            // 
            // txtDireccionC
            // 
            this.txtDireccionC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccionC.Location = new System.Drawing.Point(475, 354);
            this.txtDireccionC.Name = "txtDireccionC";
            this.txtDireccionC.Size = new System.Drawing.Size(168, 26);
            this.txtDireccionC.TabIndex = 11;
            // 
            // txtTelefonoC
            // 
            this.txtTelefonoC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonoC.Location = new System.Drawing.Point(664, 354);
            this.txtTelefonoC.Name = "txtTelefonoC";
            this.txtTelefonoC.Size = new System.Drawing.Size(100, 26);
            this.txtTelefonoC.TabIndex = 12;
            // 
            // txtEmailC
            // 
            this.txtEmailC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailC.Location = new System.Drawing.Point(787, 354);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(157, 26);
            this.txtEmailC.TabIndex = 13;
            // 
            // btnInsertarC
            // 
            this.btnInsertarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsertarC.BackColor = System.Drawing.Color.Purple;
            this.btnInsertarC.ForeColor = System.Drawing.Color.White;
            this.btnInsertarC.Location = new System.Drawing.Point(17, 430);
            this.btnInsertarC.Name = "btnInsertarC";
            this.btnInsertarC.Size = new System.Drawing.Size(139, 48);
            this.btnInsertarC.TabIndex = 14;
            this.btnInsertarC.Text = "Insertar Cliente";
            this.btnInsertarC.UseVisualStyleBackColor = false;
            this.btnInsertarC.Click += new System.EventHandler(this.btnInsertarC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarC.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarC.ForeColor = System.Drawing.Color.White;
            this.btnEliminarC.Location = new System.Drawing.Point(187, 430);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(139, 48);
            this.btnEliminarC.TabIndex = 15;
            this.btnEliminarC.Text = "Eliminar Cliente";
            this.btnEliminarC.UseVisualStyleBackColor = false;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnActualizarC
            // 
            this.btnActualizarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarC.BackColor = System.Drawing.Color.Purple;
            this.btnActualizarC.ForeColor = System.Drawing.Color.White;
            this.btnActualizarC.Location = new System.Drawing.Point(360, 430);
            this.btnActualizarC.Name = "btnActualizarC";
            this.btnActualizarC.Size = new System.Drawing.Size(147, 48);
            this.btnActualizarC.TabIndex = 16;
            this.btnActualizarC.Text = "Actualizar Cliente";
            this.btnActualizarC.UseVisualStyleBackColor = false;
            this.btnActualizarC.Click += new System.EventHandler(this.btnActualizarC_Click);
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Depth = 0;
            this.ss.Font = new System.Drawing.Font("Roboto", 11F);
            this.ss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ss.Location = new System.Drawing.Point(21, 45);
            this.ss.MouseState = MaterialSkin.MouseState.HOVER;
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(147, 27);
            this.ss.TabIndex = 17;
            this.ss.Text = "BuscarCliente";
            // 
            // txtbuscarCliente
            // 
            this.txtbuscarCliente.Location = new System.Drawing.Point(187, 47);
            this.txtbuscarCliente.Name = "txtbuscarCliente";
            this.txtbuscarCliente.Size = new System.Drawing.Size(247, 26);
            this.txtbuscarCliente.TabIndex = 18;
            this.txtbuscarCliente.TextChanged += new System.EventHandler(this.txtbuscarCliente_TextChanged);
            // 
            // btnReporteCliente
            // 
            this.btnReporteCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReporteCliente.BackColor = System.Drawing.Color.Purple;
            this.btnReporteCliente.ForeColor = System.Drawing.Color.White;
            this.btnReporteCliente.Location = new System.Drawing.Point(554, 430);
            this.btnReporteCliente.Name = "btnReporteCliente";
            this.btnReporteCliente.Size = new System.Drawing.Size(164, 48);
            this.btnReporteCliente.TabIndex = 19;
            this.btnReporteCliente.Text = "ReporteCliente";
            this.btnReporteCliente.UseVisualStyleBackColor = false;
            this.btnReporteCliente.Click += new System.EventHandler(this.btnReporteCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ingrese Informacion del Cliente";
            // 
            // MantoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(967, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReporteCliente);
            this.Controls.Add(this.txtbuscarCliente);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.btnActualizarC);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.btnInsertarC);
            this.Controls.Add(this.txtEmailC);
            this.Controls.Add(this.txtTelefonoC);
            this.Controls.Add(this.txtDireccionC);
            this.Controls.Add(this.txtApellidoC);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.DGVclientes);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "MantoClientes";
            this.Text = "MantoClientes";
            this.Load += new System.EventHandler(this.MantoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVclientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtApellidoC;
        private System.Windows.Forms.TextBox txtDireccionC;
        private System.Windows.Forms.TextBox txtTelefonoC;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.Button btnInsertarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnActualizarC;
        private MaterialSkin.Controls.MaterialLabel ss;
        private System.Windows.Forms.TextBox txtbuscarCliente;
        private System.Windows.Forms.Button btnReporteCliente;
        private System.Windows.Forms.Label label1;
    }
}