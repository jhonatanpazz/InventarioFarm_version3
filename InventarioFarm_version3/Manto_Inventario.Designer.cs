namespace InventarioFarm_version3
{
    partial class Manto_Inventario
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
            this.txtBuscarI = new System.Windows.Forms.TextBox();
            this.DGVInventario = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdInventario = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtFechaI = new System.Windows.Forms.MaskedTextBox();
            this.btnInsertarI = new System.Windows.Forms.Button();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnActualizarI = new System.Windows.Forms.Button();
            this.cmbIdProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Informacion Del Inventario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Producto";
            // 
            // txtBuscarI
            // 
            this.txtBuscarI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarI.Location = new System.Drawing.Point(235, 83);
            this.txtBuscarI.Name = "txtBuscarI";
            this.txtBuscarI.Size = new System.Drawing.Size(152, 26);
            this.txtBuscarI.TabIndex = 2;
            this.txtBuscarI.TextChanged += new System.EventHandler(this.txtBuscarI_TextChanged);
            // 
            // DGVInventario
            // 
            this.DGVInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInventario.Location = new System.Drawing.Point(65, 142);
            this.DGVInventario.Name = "DGVInventario";
            this.DGVInventario.RowTemplate.Height = 28;
            this.DGVInventario.Size = new System.Drawing.Size(803, 246);
            this.DGVInventario.TabIndex = 3;
            this.DGVInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInventario_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IdInventario";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "IdProducto";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "NombreProducto";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // txtIdInventario
            // 
            this.txtIdInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdInventario.Location = new System.Drawing.Point(154, 435);
            this.txtIdInventario.Name = "txtIdInventario";
            this.txtIdInventario.Size = new System.Drawing.Size(55, 26);
            this.txtIdInventario.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(576, 435);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 26);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreP.Location = new System.Drawing.Point(877, 435);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(176, 26);
            this.txtNombreP.TabIndex = 12;
            // 
            // txtFechaI
            // 
            this.txtFechaI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaI.Location = new System.Drawing.Point(248, 487);
            this.txtFechaI.Mask = "00/00/0000";
            this.txtFechaI.Name = "txtFechaI";
            this.txtFechaI.Size = new System.Drawing.Size(131, 26);
            this.txtFechaI.TabIndex = 13;
            this.txtFechaI.ValidatingType = typeof(System.DateTime);
            // 
            // btnInsertarI
            // 
            this.btnInsertarI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertarI.BackColor = System.Drawing.Color.Purple;
            this.btnInsertarI.ForeColor = System.Drawing.Color.White;
            this.btnInsertarI.Location = new System.Drawing.Point(34, 561);
            this.btnInsertarI.Name = "btnInsertarI";
            this.btnInsertarI.Size = new System.Drawing.Size(175, 48);
            this.btnInsertarI.TabIndex = 25;
            this.btnInsertarI.Text = "Insertar Producto";
            this.btnInsertarI.UseVisualStyleBackColor = false;
            this.btnInsertarI.Click += new System.EventHandler(this.btnInsertarI_Click);
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarI.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarI.ForeColor = System.Drawing.Color.White;
            this.btnEliminarI.Location = new System.Drawing.Point(297, 561);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(175, 48);
            this.btnEliminarI.TabIndex = 26;
            this.btnEliminarI.Text = "Eliminar Producto";
            this.btnEliminarI.UseVisualStyleBackColor = false;
            this.btnEliminarI.Click += new System.EventHandler(this.btnEliminarI_Click);
            // 
            // btnActualizarI
            // 
            this.btnActualizarI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarI.BackColor = System.Drawing.Color.Purple;
            this.btnActualizarI.ForeColor = System.Drawing.Color.White;
            this.btnActualizarI.Location = new System.Drawing.Point(576, 561);
            this.btnActualizarI.Name = "btnActualizarI";
            this.btnActualizarI.Size = new System.Drawing.Size(175, 48);
            this.btnActualizarI.TabIndex = 27;
            this.btnActualizarI.Text = "Modificar Producto";
            this.btnActualizarI.UseVisualStyleBackColor = false;
            this.btnActualizarI.Click += new System.EventHandler(this.btnActualizarI_Click);
            // 
            // cmbIdProducto
            // 
            this.cmbIdProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIdProducto.FormattingEnabled = true;
            this.cmbIdProducto.Location = new System.Drawing.Point(354, 432);
            this.cmbIdProducto.Name = "cmbIdProducto";
            this.cmbIdProducto.Size = new System.Drawing.Size(75, 28);
            this.cmbIdProducto.TabIndex = 28;
            // 
            // Manto_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 650);
            this.Controls.Add(this.cmbIdProducto);
            this.Controls.Add(this.btnActualizarI);
            this.Controls.Add(this.btnEliminarI);
            this.Controls.Add(this.btnInsertarI);
            this.Controls.Add(this.txtFechaI);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdInventario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVInventario);
            this.Controls.Add(this.txtBuscarI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manto_Inventario";
            this.Text = "Manto_Inventario";
            this.Load += new System.EventHandler(this.Manto_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarI;
        private System.Windows.Forms.DataGridView DGVInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdInventario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.MaskedTextBox txtFechaI;
        private System.Windows.Forms.Button btnInsertarI;
        private System.Windows.Forms.Button btnEliminarI;
        private System.Windows.Forms.Button btnActualizarI;
        private System.Windows.Forms.ComboBox cmbIdProducto;
    }
}