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
            this.colidProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldesProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtnomProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidProveedor,
            this.coldesProveedor,
            this.coltipoProveedor});
            this.dgvBusqueda.Location = new System.Drawing.Point(22, 125);
            this.dgvBusqueda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.RowHeadersVisible = false;
            this.dgvBusqueda.Size = new System.Drawing.Size(858, 364);
            this.dgvBusqueda.TabIndex = 0;
            this.dgvBusqueda.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBusqueda_CellEnter);
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
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 3;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAceptar.Location = new System.Drawing.Point(739, 28);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 39);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtnomProveedor
            // 
            this.txtnomProveedor.Location = new System.Drawing.Point(199, 36);
            this.txtnomProveedor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtnomProveedor.Name = "txtnomProveedor";
            this.txtnomProveedor.Size = new System.Drawing.Size(485, 24);
            this.txtnomProveedor.TabIndex = 2;
            this.txtnomProveedor.TextChanged += new System.EventHandler(this.TxtnomProveedor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Proveedor";
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(908, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomProveedor);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvBusqueda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaProveedor";
            this.Text = "frmBusquedaProveedor";
            this.Load += new System.EventHandler(this.FrmBusquedaProveedor_Load);
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