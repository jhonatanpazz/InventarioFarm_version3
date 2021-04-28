namespace InventarioFarm_version3
{
    partial class Facturar
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.DGVFactura = new System.Windows.Forms.DataGridView();
            this.Codigop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productonom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnImprimirClase = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPrecio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalp = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(167, 75);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 28);
            this.cmbCliente.TabIndex = 3;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(167, 123);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 28);
            this.cmbEmpleado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sucursal";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(456, 75);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 28);
            this.cmbSucursal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha";
            // 
            // txtFechaF
            // 
            this.txtFechaF.Location = new System.Drawing.Point(456, 122);
            this.txtFechaF.Mask = "00/00/0000";
            this.txtFechaF.Name = "txtFechaF";
            this.txtFechaF.Size = new System.Drawing.Size(121, 26);
            this.txtFechaF.TabIndex = 8;
            this.txtFechaF.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(158, 244);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(130, 26);
            this.txtCantidad.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Purple;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(340, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 38);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar a lista";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Purple;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(519, 238);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 38);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar de Lista";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DGVFactura
            // 
            this.DGVFactura.AllowUserToAddRows = false;
            this.DGVFactura.AllowUserToDeleteRows = false;
            this.DGVFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigop,
            this.Productonom,
            this.Preciop,
            this.Cantidadp,
            this.Totalp});
            this.DGVFactura.Location = new System.Drawing.Point(31, 303);
            this.DGVFactura.Name = "DGVFactura";
            this.DGVFactura.ReadOnly = true;
            this.DGVFactura.RowTemplate.Height = 28;
            this.DGVFactura.Size = new System.Drawing.Size(763, 229);
            this.DGVFactura.TabIndex = 13;
            // 
            // Codigop
            // 
            this.Codigop.HeaderText = "Codigo";
            this.Codigop.Name = "Codigop";
            this.Codigop.ReadOnly = true;
            // 
            // Productonom
            // 
            this.Productonom.HeaderText = "Producto";
            this.Productonom.Name = "Productonom";
            this.Productonom.ReadOnly = true;
            // 
            // Preciop
            // 
            this.Preciop.HeaderText = "Precio";
            this.Preciop.Name = "Preciop";
            this.Preciop.ReadOnly = true;
            // 
            // Cantidadp
            // 
            this.Cantidadp.HeaderText = "Cantidad";
            this.Cantidadp.Name = "Cantidadp";
            this.Cantidadp.ReadOnly = true;
            // 
            // Totalp
            // 
            this.Totalp.HeaderText = "Total";
            this.Totalp.Name = "Totalp";
            this.Totalp.ReadOnly = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Purple;
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(31, 538);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(125, 47);
            this.btnFacturar.TabIndex = 14;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnImprimirClase
            // 
            this.btnImprimirClase.BackColor = System.Drawing.Color.Purple;
            this.btnImprimirClase.ForeColor = System.Drawing.Color.White;
            this.btnImprimirClase.Location = new System.Drawing.Point(177, 538);
            this.btnImprimirClase.Name = "btnImprimirClase";
            this.btnImprimirClase.Size = new System.Drawing.Size(196, 47);
            this.btnImprimirClase.TabIndex = 15;
            this.btnImprimirClase.Text = "Imprimir Factura";
            this.btnImprimirClase.UseVisualStyleBackColor = false;
            this.btnImprimirClase.Click += new System.EventHandler(this.btnImprimirClase_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(167, 193);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 28);
            this.cmbProducto.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio";
            // 
            // cmbPrecio
            // 
            this.cmbPrecio.FormattingEnabled = true;
            this.cmbPrecio.Location = new System.Drawing.Point(456, 187);
            this.cmbPrecio.Name = "cmbPrecio";
            this.cmbPrecio.Size = new System.Drawing.Size(121, 28);
            this.cmbPrecio.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(590, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total a Pagar";
            // 
            // txtTotalp
            // 
            this.txtTotalp.Location = new System.Drawing.Point(761, 548);
            this.txtTotalp.Name = "txtTotalp";
            this.txtTotalp.Size = new System.Drawing.Size(100, 26);
            this.txtTotalp.TabIndex = 21;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Purple;
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(392, 538);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(192, 47);
            this.btnTotal.TabIndex = 22;
            this.btnTotal.Text = "Calcular Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 618);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtTotalp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnImprimirClase);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.DGVFactura);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechaF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.Facturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFechaF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView DGVFactura;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnImprimirClase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productonom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalp;
        private System.Windows.Forms.Button btnTotal;
    }
}