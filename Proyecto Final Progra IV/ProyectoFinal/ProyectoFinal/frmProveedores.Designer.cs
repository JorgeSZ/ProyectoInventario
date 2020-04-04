namespace ProyectoFinal
{
    partial class frmProveedores
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.nomProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prograIVDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prograIVDataSet1 = new ProyectoFinal.PrograIVDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.cmbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.tipoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtnomProveedor = new System.Windows.Forms.TextBox();
            this.tipoProveedorTableAdapter1 = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter();
            this.proveedorTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.ProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoGenerateColumns = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomProveedorDataGridViewTextBoxColumn,
            this.codTipoProveedorDataGridViewTextBoxColumn});
            this.dgvProveedores.DataSource = this.proveedorBindingSource;
            this.dgvProveedores.Location = new System.Drawing.Point(13, 203);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(287, 150);
            this.dgvProveedores.TabIndex = 1;
            // 
            // nomProveedorDataGridViewTextBoxColumn
            // 
            this.nomProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomProveedorDataGridViewTextBoxColumn.DataPropertyName = "nomProveedor";
            this.nomProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nomProveedorDataGridViewTextBoxColumn.Name = "nomProveedorDataGridViewTextBoxColumn";
            // 
            // codTipoProveedorDataGridViewTextBoxColumn
            // 
            this.codTipoProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.codTipoProveedorDataGridViewTextBoxColumn.DataPropertyName = "codTipoProveedor";
            this.codTipoProveedorDataGridViewTextBoxColumn.HeaderText = "TipoProveedor";
            this.codTipoProveedorDataGridViewTextBoxColumn.Name = "codTipoProveedorDataGridViewTextBoxColumn";
            this.codTipoProveedorDataGridViewTextBoxColumn.Width = 21;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.prograIVDataSet1BindingSource;
            // 
            // prograIVDataSet1BindingSource
            // 
            this.prograIVDataSet1BindingSource.DataSource = this.prograIVDataSet1;
            this.prograIVDataSet1BindingSource.Position = 0;
            // 
            // prograIVDataSet1
            // 
            this.prograIVDataSet1.DataSetName = "PrograIVDataSet1";
            this.prograIVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo Proveedor";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(116, 34);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(121, 20);
            this.txtIdProveedor.TabIndex = 7;
            // 
            // cmbTipoProveedor
            // 
            this.cmbTipoProveedor.DataSource = this.tipoProveedorBindingSource;
            this.cmbTipoProveedor.DisplayMember = "desTipoProveedor";
            this.cmbTipoProveedor.FormattingEnabled = true;
            this.cmbTipoProveedor.Location = new System.Drawing.Point(116, 106);
            this.cmbTipoProveedor.Name = "cmbTipoProveedor";
            this.cmbTipoProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoProveedor.TabIndex = 8;
            this.cmbTipoProveedor.ValueMember = "idTipoProveedor";
            // 
            // tipoProveedorBindingSource
            // 
            this.tipoProveedorBindingSource.DataMember = "TipoProveedor";
            this.tipoProveedorBindingSource.DataSource = this.prograIVDataSet1BindingSource;
            // 
            // txtnomProveedor
            // 
            this.txtnomProveedor.Location = new System.Drawing.Point(116, 70);
            this.txtnomProveedor.Name = "txtnomProveedor";
            this.txtnomProveedor.Size = new System.Drawing.Size(121, 20);
            this.txtnomProveedor.TabIndex = 9;
            this.txtnomProveedor.TextChanged += new System.EventHandler(this.TxtnomProveedor_TextChanged);
            // 
            // tipoProveedorTableAdapter1
            // 
            this.tipoProveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 369);
            this.Controls.Add(this.txtnomProveedor);
            this.Controls.Add(this.cmbTipoProveedor);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.button1);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.ComboBox cmbTipoProveedor;
        private System.Windows.Forms.TextBox txtnomProveedor;
        private System.Windows.Forms.BindingSource prograIVDataSet1BindingSource;
        private PrograIVDataSet1 prograIVDataSet1;
        private System.Windows.Forms.BindingSource tipoProveedorBindingSource;
        private PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter tipoProveedorTableAdapter1;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private PrograIVDataSet1TableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoProveedorDataGridViewTextBoxColumn;
     //   private ProyectoFinal.PrograIVDataSetTableAdapters.TipoProveedorTableAdapter tipoProveedorTableAdapter;
    }
}