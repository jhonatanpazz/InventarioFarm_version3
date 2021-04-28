namespace InventarioFarm_version3
{
    partial class MantoMedicamentocs
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
            this.DGVmedicamentos = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtPrecioM = new System.Windows.Forms.TextBox();
            this.cmbIdMarcaM = new System.Windows.Forms.ComboBox();
            this.cmbIdProvM = new System.Windows.Forms.ComboBox();
            this.txtDescpM = new System.Windows.Forms.TextBox();
            this.btnInsertarMedicamento = new System.Windows.Forms.Button();
            this.btnEliminarMedicamento = new System.Windows.Forms.Button();
            this.btnActualizarMedicamento = new System.Windows.Forms.Button();
            this.cmbIdCatMedicamento = new System.Windows.Forms.ComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarMedicamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVmedicamentos
            // 
            this.DGVmedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVmedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmedicamentos.Location = new System.Drawing.Point(51, 132);
            this.DGVmedicamentos.Name = "DGVmedicamentos";
            this.DGVmedicamentos.RowTemplate.Height = 28;
            this.DGVmedicamentos.Size = new System.Drawing.Size(912, 158);
            this.DGVmedicamentos.TabIndex = 0;
            this.DGVmedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVmedicamentos_CellClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 309);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(165, 27);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "IdMedicamento";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(200, 309);
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
            this.materialLabel4.Location = new System.Drawing.Point(417, 309);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(106, 27);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Categoria";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(566, 309);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(92, 27);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Precio $";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(32, 395);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(127, 27);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Descripcion";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(692, 309);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(74, 27);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Marca";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(838, 309);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(113, 27);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Proveedor";
            // 
            // txtIdM
            // 
            this.txtIdM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdM.Enabled = false;
            this.txtIdM.Location = new System.Drawing.Point(32, 346);
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(70, 26);
            this.txtIdM.TabIndex = 9;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreM.Location = new System.Drawing.Point(204, 346);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(188, 26);
            this.txtNombreM.TabIndex = 10;
            // 
            // txtPrecioM
            // 
            this.txtPrecioM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecioM.Location = new System.Drawing.Point(570, 345);
            this.txtPrecioM.Name = "txtPrecioM";
            this.txtPrecioM.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioM.TabIndex = 12;
            // 
            // cmbIdMarcaM
            // 
            this.cmbIdMarcaM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdMarcaM.FormattingEnabled = true;
            this.cmbIdMarcaM.Location = new System.Drawing.Point(696, 343);
            this.cmbIdMarcaM.Name = "cmbIdMarcaM";
            this.cmbIdMarcaM.Size = new System.Drawing.Size(121, 28);
            this.cmbIdMarcaM.TabIndex = 13;
            // 
            // cmbIdProvM
            // 
            this.cmbIdProvM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdProvM.FormattingEnabled = true;
            this.cmbIdProvM.Location = new System.Drawing.Point(843, 343);
            this.cmbIdProvM.Name = "cmbIdProvM";
            this.cmbIdProvM.Size = new System.Drawing.Size(136, 28);
            this.cmbIdProvM.TabIndex = 14;
            this.cmbIdProvM.SelectedIndexChanged += new System.EventHandler(this.cmbIdProvM_SelectedIndexChanged);
            // 
            // txtDescpM
            // 
            this.txtDescpM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescpM.Location = new System.Drawing.Point(178, 397);
            this.txtDescpM.Name = "txtDescpM";
            this.txtDescpM.Size = new System.Drawing.Size(572, 26);
            this.txtDescpM.TabIndex = 15;
            // 
            // btnInsertarMedicamento
            // 
            this.btnInsertarMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertarMedicamento.BackColor = System.Drawing.Color.Purple;
            this.btnInsertarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnInsertarMedicamento.Location = new System.Drawing.Point(68, 457);
            this.btnInsertarMedicamento.Name = "btnInsertarMedicamento";
            this.btnInsertarMedicamento.Size = new System.Drawing.Size(107, 38);
            this.btnInsertarMedicamento.TabIndex = 16;
            this.btnInsertarMedicamento.Text = "Insertar";
            this.btnInsertarMedicamento.UseVisualStyleBackColor = false;
            this.btnInsertarMedicamento.Click += new System.EventHandler(this.btnInsertarMedicamento_Click);
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarMedicamento.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMedicamento.Location = new System.Drawing.Point(216, 457);
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(129, 38);
            this.btnEliminarMedicamento.TabIndex = 17;
            this.btnEliminarMedicamento.Text = "Eliminar";
            this.btnEliminarMedicamento.UseVisualStyleBackColor = false;
            this.btnEliminarMedicamento.Click += new System.EventHandler(this.btnEliminarMedicamento_Click);
            // 
            // btnActualizarMedicamento
            // 
            this.btnActualizarMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarMedicamento.BackColor = System.Drawing.Color.Purple;
            this.btnActualizarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnActualizarMedicamento.Location = new System.Drawing.Point(376, 457);
            this.btnActualizarMedicamento.Name = "btnActualizarMedicamento";
            this.btnActualizarMedicamento.Size = new System.Drawing.Size(136, 38);
            this.btnActualizarMedicamento.TabIndex = 18;
            this.btnActualizarMedicamento.Text = "Actualizar";
            this.btnActualizarMedicamento.UseVisualStyleBackColor = false;
            this.btnActualizarMedicamento.Click += new System.EventHandler(this.btnActualizarMedicamento_Click);
            // 
            // cmbIdCatMedicamento
            // 
            this.cmbIdCatMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdCatMedicamento.FormattingEnabled = true;
            this.cmbIdCatMedicamento.Location = new System.Drawing.Point(422, 343);
            this.cmbIdCatMedicamento.Name = "cmbIdCatMedicamento";
            this.cmbIdCatMedicamento.Size = new System.Drawing.Size(121, 28);
            this.cmbIdCatMedicamento.TabIndex = 19;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(32, 68);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(220, 27);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "Buscar Medicamento";
            // 
            // txtBuscarMedicamento
            // 
            this.txtBuscarMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarMedicamento.Location = new System.Drawing.Point(265, 68);
            this.txtBuscarMedicamento.Name = "txtBuscarMedicamento";
            this.txtBuscarMedicamento.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarMedicamento.TabIndex = 21;
            this.txtBuscarMedicamento.TextChanged += new System.EventHandler(this.txtBuscarMedicamento_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(552, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "Reporte Medicamentos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ingrese la Informacion del Medicamento";
            // 
            // MantoMedicamentocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscarMedicamento);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.cmbIdCatMedicamento);
            this.Controls.Add(this.btnActualizarMedicamento);
            this.Controls.Add(this.btnEliminarMedicamento);
            this.Controls.Add(this.btnInsertarMedicamento);
            this.Controls.Add(this.txtDescpM);
            this.Controls.Add(this.cmbIdProvM);
            this.Controls.Add(this.cmbIdMarcaM);
            this.Controls.Add(this.txtPrecioM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.txtIdM);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.DGVmedicamentos);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "MantoMedicamentocs";
            this.Text = "MantoMedicamentocs";
            this.Load += new System.EventHandler(this.MantoMedicamentocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVmedicamentos;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtPrecioM;
        private System.Windows.Forms.ComboBox cmbIdMarcaM;
        private System.Windows.Forms.ComboBox cmbIdProvM;
        private System.Windows.Forms.TextBox txtDescpM;
        private System.Windows.Forms.Button btnInsertarMedicamento;
        private System.Windows.Forms.Button btnEliminarMedicamento;
        private System.Windows.Forms.Button btnActualizarMedicamento;
        private System.Windows.Forms.ComboBox cmbIdCatMedicamento;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.TextBox txtBuscarMedicamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}