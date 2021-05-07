namespace InventarioFarm_version3
{
    partial class MantoSucursales
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
            this.txtBuscarSucursal = new System.Windows.Forms.TextBox();
            this.DGVSucursales = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIDSucursal = new System.Windows.Forms.TextBox();
            this.txtNombreS = new System.Windows.Forms.TextBox();
            this.txtDireccionS = new System.Windows.Forms.TextBox();
            this.txtGerenteS = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnInsertarS = new System.Windows.Forms.Button();
            this.btnEliminarS = new System.Windows.Forms.Button();
            this.btnActualizarS = new System.Windows.Forms.Button();
            this.btnReporteS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la informacion de las sucursales";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Sucursal";
            // 
            // txtBuscarSucursal
            // 
            this.txtBuscarSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarSucursal.Location = new System.Drawing.Point(247, 98);
            this.txtBuscarSucursal.Name = "txtBuscarSucursal";
            this.txtBuscarSucursal.Size = new System.Drawing.Size(179, 26);
            this.txtBuscarSucursal.TabIndex = 2;
            this.txtBuscarSucursal.TextChanged += new System.EventHandler(this.txtBuscarSucursal_TextChanged);
            // 
            // DGVSucursales
            // 
            this.DGVSucursales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSucursales.Location = new System.Drawing.Point(35, 147);
            this.DGVSucursales.Name = "DGVSucursales";
            this.DGVSucursales.RowTemplate.Height = 28;
            this.DGVSucursales.Size = new System.Drawing.Size(950, 221);
            this.DGVSucursales.TabIndex = 3;
            this.DGVSucursales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSucursales_CellContentClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(44, 388);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 27);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "IdSucursal";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(191, 388);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 27);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(359, 388);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 27);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Direccion";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(695, 388);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(89, 27);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Gerente";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(865, 388);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(98, 27);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Cantidad";
            // 
            // txtIDSucursal
            // 
            this.txtIDSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDSucursal.Location = new System.Drawing.Point(49, 435);
            this.txtIDSucursal.Name = "txtIDSucursal";
            this.txtIDSucursal.Size = new System.Drawing.Size(69, 26);
            this.txtIDSucursal.TabIndex = 9;
            // 
            // txtNombreS
            // 
            this.txtNombreS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreS.Location = new System.Drawing.Point(196, 435);
            this.txtNombreS.Name = "txtNombreS";
            this.txtNombreS.Size = new System.Drawing.Size(115, 26);
            this.txtNombreS.TabIndex = 10;
            // 
            // txtDireccionS
            // 
            this.txtDireccionS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccionS.Location = new System.Drawing.Point(364, 435);
            this.txtDireccionS.Name = "txtDireccionS";
            this.txtDireccionS.Size = new System.Drawing.Size(229, 26);
            this.txtDireccionS.TabIndex = 11;
            // 
            // txtGerenteS
            // 
            this.txtGerenteS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGerenteS.Location = new System.Drawing.Point(700, 435);
            this.txtGerenteS.Name = "txtGerenteS";
            this.txtGerenteS.Size = new System.Drawing.Size(115, 26);
            this.txtGerenteS.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(870, 435);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(115, 26);
            this.txtCantidad.TabIndex = 13;
            // 
            // btnInsertarS
            // 
            this.btnInsertarS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertarS.BackColor = System.Drawing.Color.Purple;
            this.btnInsertarS.ForeColor = System.Drawing.Color.White;
            this.btnInsertarS.Location = new System.Drawing.Point(35, 492);
            this.btnInsertarS.Name = "btnInsertarS";
            this.btnInsertarS.Size = new System.Drawing.Size(154, 48);
            this.btnInsertarS.TabIndex = 15;
            this.btnInsertarS.Text = "Insertar Sucursal";
            this.btnInsertarS.UseVisualStyleBackColor = false;
            this.btnInsertarS.Click += new System.EventHandler(this.btnInsertarS_Click);
            // 
            // btnEliminarS
            // 
            this.btnEliminarS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarS.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarS.ForeColor = System.Drawing.Color.White;
            this.btnEliminarS.Location = new System.Drawing.Point(223, 492);
            this.btnEliminarS.Name = "btnEliminarS";
            this.btnEliminarS.Size = new System.Drawing.Size(161, 48);
            this.btnEliminarS.TabIndex = 16;
            this.btnEliminarS.Text = "Eliminar Sucursal";
            this.btnEliminarS.UseVisualStyleBackColor = false;
            this.btnEliminarS.Click += new System.EventHandler(this.btnEliminarS_Click);
            // 
            // btnActualizarS
            // 
            this.btnActualizarS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarS.BackColor = System.Drawing.Color.Purple;
            this.btnActualizarS.ForeColor = System.Drawing.Color.White;
            this.btnActualizarS.Location = new System.Drawing.Point(416, 492);
            this.btnActualizarS.Name = "btnActualizarS";
            this.btnActualizarS.Size = new System.Drawing.Size(177, 48);
            this.btnActualizarS.TabIndex = 17;
            this.btnActualizarS.Text = "Actualizar Sucursal";
            this.btnActualizarS.UseVisualStyleBackColor = false;
            this.btnActualizarS.Click += new System.EventHandler(this.btnActualizarS_Click);
            // 
            // btnReporteS
            // 
            this.btnReporteS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReporteS.BackColor = System.Drawing.Color.Purple;
            this.btnReporteS.ForeColor = System.Drawing.Color.White;
            this.btnReporteS.Location = new System.Drawing.Point(615, 492);
            this.btnReporteS.Name = "btnReporteS";
            this.btnReporteS.Size = new System.Drawing.Size(139, 48);
            this.btnReporteS.TabIndex = 18;
            this.btnReporteS.Text = "Reporte";
            this.btnReporteS.UseVisualStyleBackColor = false;
            // 
            // MantoSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 581);
            this.Controls.Add(this.btnReporteS);
            this.Controls.Add(this.btnActualizarS);
            this.Controls.Add(this.btnEliminarS);
            this.Controls.Add(this.btnInsertarS);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtGerenteS);
            this.Controls.Add(this.txtDireccionS);
            this.Controls.Add(this.txtNombreS);
            this.Controls.Add(this.txtIDSucursal);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.DGVSucursales);
            this.Controls.Add(this.txtBuscarSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantoSucursales";
            this.Text = "MantoSucursales";
            this.Load += new System.EventHandler(this.MantoSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarSucursal;
        private System.Windows.Forms.DataGridView DGVSucursales;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox txtIDSucursal;
        private System.Windows.Forms.TextBox txtNombreS;
        private System.Windows.Forms.TextBox txtDireccionS;
        private System.Windows.Forms.TextBox txtGerenteS;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnInsertarS;
        private System.Windows.Forms.Button btnEliminarS;
        private System.Windows.Forms.Button btnActualizarS;
        private System.Windows.Forms.Button btnReporteS;
    }
}