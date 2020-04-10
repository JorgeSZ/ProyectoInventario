namespace ProyectoFinal
{
    partial class frmBusquedaProveedor
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
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtnomProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colidProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldesProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidProveedor,
            this.coldesProveedor,
            this.coltipoProveedor});
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 42);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(468, 178);
            this.dgvBusqueda.TabIndex = 0;
            this.dgvBusqueda.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBusqueda_CellEnter);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(193, 226);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 44);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtnomProveedor
            // 
            this.txtnomProveedor.Location = new System.Drawing.Point(160, 12);
            this.txtnomProveedor.Name = "txtnomProveedor";
            this.txtnomProveedor.Size = new System.Drawing.Size(277, 20);
            this.txtnomProveedor.TabIndex = 2;
            this.txtnomProveedor.TextChanged += new System.EventHandler(this.TxtnomProveedor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Proveedor";
            // 
            // colidProveedor
            // 
            this.colidProveedor.DataPropertyName = "idProveedor";
            this.colidProveedor.HeaderText = "ID";
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.ReadOnly = true;
            // 
            // coldesProveedor
            // 
            this.coldesProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldesProveedor.DataPropertyName = "desProveedor";
            this.coldesProveedor.HeaderText = "Proveedor";
            this.coldesProveedor.Name = "coldesProveedor";
            this.coldesProveedor.ReadOnly = true;
            // 
            // coltipoProveedor
            // 
            this.coltipoProveedor.DataPropertyName = "codTipoProveedor";
            this.coltipoProveedor.HeaderText = "Tipo Proveedor";
            this.coltipoProveedor.Name = "coltipoProveedor";
            this.coltipoProveedor.ReadOnly = true;
            this.coltipoProveedor.Visible = false;
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomProveedor);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvBusqueda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaProveedor";
            this.Text = "frmBusquedaProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtnomProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldesProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoProveedor;
    }
}