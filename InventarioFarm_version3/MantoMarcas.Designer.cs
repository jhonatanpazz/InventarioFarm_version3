namespace InventarioFarm_version3
{
    partial class MantoMarcas
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
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.DGVMarca = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.btnInsertarM = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnAtualizarM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Informacion de la Marca ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Marca";
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarMarca.Location = new System.Drawing.Point(285, 141);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(130, 26);
            this.txtBuscarMarca.TabIndex = 2;
            this.txtBuscarMarca.TextChanged += new System.EventHandler(this.txtBuscarMarca_TextChanged);
            // 
            // DGVMarca
            // 
            this.DGVMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMarca.Location = new System.Drawing.Point(86, 205);
            this.DGVMarca.Name = "DGVMarca";
            this.DGVMarca.RowTemplate.Height = 28;
            this.DGVMarca.Size = new System.Drawing.Size(471, 150);
            this.DGVMarca.TabIndex = 3;
            this.DGVMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMarca_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IdMarca";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre Marca";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdMarca.Enabled = false;
            this.txtIdMarca.Location = new System.Drawing.Point(204, 403);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(78, 26);
            this.txtIdMarca.TabIndex = 6;
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreMarca.Location = new System.Drawing.Point(543, 403);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(130, 26);
            this.txtNombreMarca.TabIndex = 7;
            // 
            // btnInsertarM
            // 
            this.btnInsertarM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertarM.BackColor = System.Drawing.Color.Purple;
            this.btnInsertarM.ForeColor = System.Drawing.Color.White;
            this.btnInsertarM.Location = new System.Drawing.Point(86, 480);
            this.btnInsertarM.Name = "btnInsertarM";
            this.btnInsertarM.Size = new System.Drawing.Size(154, 48);
            this.btnInsertarM.TabIndex = 16;
            this.btnInsertarM.Text = "Insertar Marca";
            this.btnInsertarM.UseVisualStyleBackColor = false;
            this.btnInsertarM.Click += new System.EventHandler(this.btnInsertarM_Click);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarM.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarM.ForeColor = System.Drawing.Color.White;
            this.btnEliminarM.Location = new System.Drawing.Point(305, 480);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(154, 48);
            this.btnEliminarM.TabIndex = 17;
            this.btnEliminarM.Text = "Eliminar Marca";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnAtualizarM
            // 
            this.btnAtualizarM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizarM.BackColor = System.Drawing.Color.Purple;
            this.btnAtualizarM.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarM.Location = new System.Drawing.Point(509, 480);
            this.btnAtualizarM.Name = "btnAtualizarM";
            this.btnAtualizarM.Size = new System.Drawing.Size(154, 48);
            this.btnAtualizarM.TabIndex = 18;
            this.btnAtualizarM.Text = "Actualizar Marca";
            this.btnAtualizarM.UseVisualStyleBackColor = false;
            this.btnAtualizarM.Click += new System.EventHandler(this.btnAtualizarM_Click);
            // 
            // MantoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 596);
            this.Controls.Add(this.btnAtualizarM);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.btnInsertarM);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVMarca);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantoMarcas";
            this.Text = "MantoMarcas";
            this.Load += new System.EventHandler(this.MantoMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.DataGridView DGVMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Button btnInsertarM;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnAtualizarM;
    }
}