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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prograIVDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prograIVDataSet1 = new ProyectoFinal.PrograIVDataSet1();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.cmbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.tipoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtnomProveedor = new System.Windows.Forms.TextBox();
            this.tipoProveedorTableAdapter1 = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter();
            this.proveedorTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.ProveedorTableAdapter();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(56, 381);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedor,
            this.desProveedor,
            this.TipoProveedor});
            this.dgvProveedores.Location = new System.Drawing.Point(725, 64);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.Size = new System.Drawing.Size(631, 452);
            this.dgvProveedores.TabIndex = 1;
            this.dgvProveedores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellEnter);
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
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 3;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(270, 381);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(162, 36);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(502, 381);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 36);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo Proveedor";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(213, 64);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(451, 24);
            this.txtIdProveedor.TabIndex = 7;
            // 
            // cmbTipoProveedor
            // 
            this.cmbTipoProveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoProveedorBindingSource, "idTipoProveedor", true));
            this.cmbTipoProveedor.DataSource = this.tipoProveedorBindingSource1;
            this.cmbTipoProveedor.DisplayMember = "desTipoProveedor";
            this.cmbTipoProveedor.FormattingEnabled = true;
            this.cmbTipoProveedor.Location = new System.Drawing.Point(213, 188);
            this.cmbTipoProveedor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbTipoProveedor.Name = "cmbTipoProveedor";
            this.cmbTipoProveedor.Size = new System.Drawing.Size(451, 25);
            this.cmbTipoProveedor.TabIndex = 9;
            this.cmbTipoProveedor.ValueMember = "idTipoProveedor";
            // 
            // tipoProveedorBindingSource
            // 
            this.tipoProveedorBindingSource.DataMember = "TipoProveedor";
            this.tipoProveedorBindingSource.DataSource = this.prograIVDataSet1BindingSource;
            // 
            // tipoProveedorBindingSource1
            // 
            this.tipoProveedorBindingSource1.DataMember = "TipoProveedor";
            this.tipoProveedorBindingSource1.DataSource = this.prograIVDataSet1BindingSource;
            // 
            // txtnomProveedor
            // 
            this.txtnomProveedor.Location = new System.Drawing.Point(213, 126);
            this.txtnomProveedor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtnomProveedor.Name = "txtnomProveedor";
            this.txtnomProveedor.Size = new System.Drawing.Size(451, 24);
            this.txtnomProveedor.TabIndex = 8;
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
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "TipoProducto";
            this.tipoProductoBindingSource.DataSource = this.prograIVDataSet1BindingSource;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.prograIVDataSet1BindingSource;
            // 
            // idProveedor
            // 
            this.idProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProveedor.DataPropertyName = "idProveedor";
            this.idProveedor.HeaderText = "ID";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            // 
            // desProveedor
            // 
            this.desProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desProveedor.DataPropertyName = "desProveedor";
            this.desProveedor.HeaderText = "Proveedor";
            this.desProveedor.Name = "desProveedor";
            this.desProveedor.ReadOnly = true;
            // 
            // TipoProveedor
            // 
            this.TipoProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoProveedor.DataPropertyName = "codTipoProveedor";
            this.TipoProveedor.HeaderText = "Tipo";
            this.TipoProveedor.Name = "TipoProveedor";
            this.TipoProveedor.ReadOnly = true;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1418, 600);
            this.Controls.Add(this.txtnomProveedor);
            this.Controls.Add(this.cmbTipoProveedor);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
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
        private System.Windows.Forms.BindingSource tipoProveedorBindingSource1;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn desProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProveedor;
        //   private ProyectoFinal.PrograIVDataSetTableAdapters.TipoProveedorTableAdapter tipoProveedorTableAdapter;
    }
}