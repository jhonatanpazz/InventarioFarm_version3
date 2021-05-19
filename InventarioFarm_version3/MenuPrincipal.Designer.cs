namespace InventarioFarm_version3
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMantos = new System.Windows.Forms.Panel();
            this.btnMantoProveedor = new FontAwesome.Sharp.IconButton();
            this.btnMantoMarcas = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnMantoMedicamentos = new FontAwesome.Sharp.IconButton();
            this.btnMantos = new FontAwesome.Sharp.IconButton();
            this.btnCreadores = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnFacturar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarratitle = new System.Windows.Forms.Panel();
            this.labeltituloform = new System.Windows.Forms.Label();
            this.iconformularioactual = new FontAwesome.Sharp.IconPictureBox();
            this.panelsombra = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMantoInventario = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelMantos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarratitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconformularioactual)).BeginInit();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.panelMantos);
            this.panelMenu.Controls.Add(this.btnMantos);
            this.panelMenu.Controls.Add(this.btnCreadores);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnFacturar);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(266, 1031);
            this.panelMenu.TabIndex = 0;
            // 
            // panelMantos
            // 
            this.panelMantos.Controls.Add(this.btnMantoInventario);
            this.panelMantos.Controls.Add(this.btnMantoProveedor);
            this.panelMantos.Controls.Add(this.btnMantoMarcas);
            this.panelMantos.Controls.Add(this.iconButton2);
            this.panelMantos.Controls.Add(this.btnEmpleado);
            this.panelMantos.Controls.Add(this.btnCliente);
            this.panelMantos.Controls.Add(this.btnMantoMedicamentos);
            this.panelMantos.Location = new System.Drawing.Point(3, 469);
            this.panelMantos.Name = "panelMantos";
            this.panelMantos.Size = new System.Drawing.Size(263, 538);
            this.panelMantos.TabIndex = 10;
            // 
            // btnMantoProveedor
            // 
            this.btnMantoProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantoProveedor.FlatAppearance.BorderSize = 0;
            this.btnMantoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantoProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMantoProveedor.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnMantoProveedor.IconColor = System.Drawing.Color.White;
            this.btnMantoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantoProveedor.Location = new System.Drawing.Point(0, 368);
            this.btnMantoProveedor.Name = "btnMantoProveedor";
            this.btnMantoProveedor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMantoProveedor.Size = new System.Drawing.Size(263, 52);
            this.btnMantoProveedor.TabIndex = 11;
            this.btnMantoProveedor.Text = "Mantenimiento Proveedor";
            this.btnMantoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantoProveedor.UseVisualStyleBackColor = true;
            this.btnMantoProveedor.Click += new System.EventHandler(this.btnMantoProveedor_Click);
            // 
            // btnMantoMarcas
            // 
            this.btnMantoMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantoMarcas.FlatAppearance.BorderSize = 0;
            this.btnMantoMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantoMarcas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMantoMarcas.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnMantoMarcas.IconColor = System.Drawing.Color.White;
            this.btnMantoMarcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantoMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantoMarcas.Location = new System.Drawing.Point(0, 316);
            this.btnMantoMarcas.Name = "btnMantoMarcas";
            this.btnMantoMarcas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMantoMarcas.Size = new System.Drawing.Size(263, 52);
            this.btnMantoMarcas.TabIndex = 10;
            this.btnMantoMarcas.Text = "Mantenimiento Marcas";
            this.btnMantoMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantoMarcas.UseVisualStyleBackColor = true;
            this.btnMantoMarcas.Click += new System.EventHandler(this.btnMantoMarcas_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 234);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(263, 82);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Mantenimiento Sucursales";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.Walking;
            this.btnEmpleado.IconColor = System.Drawing.Color.White;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 160);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(263, 74);
            this.btnEmpleado.TabIndex = 8;
            this.btnEmpleado.Text = "Mantenimiento Empleado";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.btnCliente.IconColor = System.Drawing.Color.White;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 78);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(263, 82);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "Mantenimiento Cliente";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // btnMantoMedicamentos
            // 
            this.btnMantoMedicamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantoMedicamentos.FlatAppearance.BorderSize = 0;
            this.btnMantoMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantoMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantoMedicamentos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMantoMedicamentos.IconChar = FontAwesome.Sharp.IconChar.Monero;
            this.btnMantoMedicamentos.IconColor = System.Drawing.Color.White;
            this.btnMantoMedicamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantoMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantoMedicamentos.Location = new System.Drawing.Point(0, 0);
            this.btnMantoMedicamentos.Name = "btnMantoMedicamentos";
            this.btnMantoMedicamentos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMantoMedicamentos.Size = new System.Drawing.Size(263, 78);
            this.btnMantoMedicamentos.TabIndex = 6;
            this.btnMantoMedicamentos.Text = "Mantenimientos de Medicamentos";
            this.btnMantoMedicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantoMedicamentos.UseVisualStyleBackColor = true;
            this.btnMantoMedicamentos.Click += new System.EventHandler(this.btnMantoMedicamentos_Click_1);
            // 
            // btnMantos
            // 
            this.btnMantos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantos.FlatAppearance.BorderSize = 0;
            this.btnMantos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMantos.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnMantos.IconColor = System.Drawing.Color.White;
            this.btnMantos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantos.Location = new System.Drawing.Point(0, 388);
            this.btnMantos.Name = "btnMantos";
            this.btnMantos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMantos.Size = new System.Drawing.Size(266, 75);
            this.btnMantos.TabIndex = 9;
            this.btnMantos.Text = "Mantenimientos";
            this.btnMantos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantos.UseVisualStyleBackColor = true;
            this.btnMantos.Click += new System.EventHandler(this.btnMantos_Click_1);
            // 
            // btnCreadores
            // 
            this.btnCreadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreadores.FlatAppearance.BorderSize = 0;
            this.btnCreadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreadores.IconChar = FontAwesome.Sharp.IconChar.Deezer;
            this.btnCreadores.IconColor = System.Drawing.Color.White;
            this.btnCreadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreadores.Location = new System.Drawing.Point(0, 306);
            this.btnCreadores.Name = "btnCreadores";
            this.btnCreadores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreadores.Size = new System.Drawing.Size(266, 82);
            this.btnCreadores.TabIndex = 7;
            this.btnCreadores.Text = "Creadores";
            this.btnCreadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreadores.UseVisualStyleBackColor = true;
            this.btnCreadores.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(266, 76);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacturar.IconChar = FontAwesome.Sharp.IconChar.Deezer;
            this.btnFacturar.IconColor = System.Drawing.Color.White;
            this.btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(0, 148);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFacturar.Size = new System.Drawing.Size(266, 82);
            this.btnFacturar.TabIndex = 5;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 148);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelBarratitle
            // 
            this.panelBarratitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBarratitle.Controls.Add(this.labeltituloform);
            this.panelBarratitle.Controls.Add(this.iconformularioactual);
            this.panelBarratitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarratitle.Location = new System.Drawing.Point(266, 0);
            this.panelBarratitle.Name = "panelBarratitle";
            this.panelBarratitle.Size = new System.Drawing.Size(1232, 62);
            this.panelBarratitle.TabIndex = 1;
            this.panelBarratitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitleBar);
            // 
            // labeltituloform
            // 
            this.labeltituloform.AutoSize = true;
            this.labeltituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltituloform.ForeColor = System.Drawing.Color.Magenta;
            this.labeltituloform.Location = new System.Drawing.Point(73, 13);
            this.labeltituloform.Name = "labeltituloform";
            this.labeltituloform.Size = new System.Drawing.Size(57, 22);
            this.labeltituloform.TabIndex = 1;
            this.labeltituloform.Text = "Home";
            // 
            // iconformularioactual
            // 
            this.iconformularioactual.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconformularioactual.ForeColor = System.Drawing.Color.Magenta;
            this.iconformularioactual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconformularioactual.IconColor = System.Drawing.Color.Magenta;
            this.iconformularioactual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconformularioactual.IconSize = 38;
            this.iconformularioactual.Location = new System.Drawing.Point(24, 13);
            this.iconformularioactual.Name = "iconformularioactual";
            this.iconformularioactual.Size = new System.Drawing.Size(32, 32);
            this.iconformularioactual.TabIndex = 0;
            this.iconformularioactual.TabStop = false;
            // 
            // panelsombra
            // 
            this.panelsombra.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelsombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsombra.Location = new System.Drawing.Point(266, 62);
            this.panelsombra.Name = "panelsombra";
            this.panelsombra.Size = new System.Drawing.Size(1232, 10);
            this.panelsombra.TabIndex = 2;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelCentral.Controls.Add(this.pictureBox2);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(266, 72);
            this.panelCentral.MinimumSize = new System.Drawing.Size(981, 900);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1232, 959);
            this.panelCentral.TabIndex = 3;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(544, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnMantoInventario
            // 
            this.btnMantoInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantoInventario.FlatAppearance.BorderSize = 0;
            this.btnMantoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantoInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMantoInventario.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnMantoInventario.IconColor = System.Drawing.Color.White;
            this.btnMantoInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantoInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantoInventario.Location = new System.Drawing.Point(0, 420);
            this.btnMantoInventario.Name = "btnMantoInventario";
            this.btnMantoInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMantoInventario.Size = new System.Drawing.Size(263, 52);
            this.btnMantoInventario.TabIndex = 12;
            this.btnMantoInventario.Text = "Mantenimiento Inventario";
            this.btnMantoInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantoInventario.UseVisualStyleBackColor = true;
            this.btnMantoInventario.Click += new System.EventHandler(this.btnMantoInventario_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1498, 1031);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelsombra);
            this.Controls.Add(this.panelBarratitle);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1520, 985);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMantos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarratitle.ResumeLayout(false);
            this.panelBarratitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconformularioactual)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBarratitle;
        private System.Windows.Forms.Label labeltituloform;
        private FontAwesome.Sharp.IconPictureBox iconformularioactual;
        private System.Windows.Forms.Panel panelsombra;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnCreadores;
        private FontAwesome.Sharp.IconButton btnMantos;
        private System.Windows.Forms.Panel panelMantos;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnMantoMedicamentos;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnMantoMarcas;
        private FontAwesome.Sharp.IconButton btnMantoProveedor;
        private FontAwesome.Sharp.IconButton btnMantoInventario;
    }
}

