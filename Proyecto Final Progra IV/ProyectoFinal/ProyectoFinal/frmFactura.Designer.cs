namespace ProyectoFinal
{
    partial class frmFactura
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.colnumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colidProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colsubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prograIVDataSet = new ProyectoFinal.PrograIVDataSet();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtsubTotal = new System.Windows.Forms.TextBox();
            this.txtidProveedor = new System.Windows.Forms.TextBox();
            this.txtnumFactura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prograIVDataSet1 = new ProyectoFinal.PrograIVDataSet1();
            this.prograIVDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new ProyectoFinal.PrograIVDataSetTableAdapters.FacturaTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.tipoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPagoTableAdapter = new ProyectoFinal.PrograIVDataSetTableAdapters.tipoPagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnumFactura,
            this.colidProveedor,
            this.colFechaFactura,
            this.coltipoPago,
            this.colEstado,
            this.colsubTotal,
            this.colIVA,
            this.colDescuento,
            this.colTotal});
            this.dgvFacturas.Location = new System.Drawing.Point(436, 45);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(5);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.Size = new System.Drawing.Size(898, 467);
            this.dgvFacturas.TabIndex = 49;
            this.dgvFacturas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFacturas_CellEnter);
            this.dgvFacturas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvFacturas_CellFormatting);
            // 
            // colnumFactura
            // 
            this.colnumFactura.DataPropertyName = "numFactura";
            this.colnumFactura.HeaderText = "# Factura";
            this.colnumFactura.Name = "colnumFactura";
            this.colnumFactura.ReadOnly = true;
            // 
            // colidProveedor
            // 
            this.colidProveedor.DataPropertyName = "idProveedor";
            this.colidProveedor.HeaderText = "Proveedor";
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.ReadOnly = true;
            // 
            // colFechaFactura
            // 
            this.colFechaFactura.DataPropertyName = "fechaFactura";
            this.colFechaFactura.HeaderText = "Fecha Factura";
            this.colFechaFactura.Name = "colFechaFactura";
            this.colFechaFactura.ReadOnly = true;
            // 
            // coltipoPago
            // 
            this.coltipoPago.DataPropertyName = "tipoPago";
            this.coltipoPago.HeaderText = "Tipo Pago";
            this.coltipoPago.Name = "coltipoPago";
            this.coltipoPago.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            this.colEstado.HeaderText = "Pagado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colsubTotal
            // 
            this.colsubTotal.DataPropertyName = "subTotal";
            this.colsubTotal.HeaderText = "Sub Total";
            this.colsubTotal.Name = "colsubTotal";
            this.colsubTotal.ReadOnly = true;
            // 
            // colIVA
            // 
            this.colIVA.DataPropertyName = "IVA";
            this.colIVA.HeaderText = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.ReadOnly = true;
            // 
            // colDescuento
            // 
            this.colDescuento.DataPropertyName = "descuento";
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "totalFactura";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.prograIVDataSet;
            // 
            // prograIVDataSet
            // 
            this.prograIVDataSet.DataSetName = "PrograIVDataSet";
            this.prograIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(436, 546);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 36);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 3;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(230, 546);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(162, 36);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 3;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(25, 546);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(162, 36);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtsubTotal
            // 
            this.txtsubTotal.Location = new System.Drawing.Point(230, 366);
            this.txtsubTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtsubTotal.Name = "txtsubTotal";
            this.txtsubTotal.Size = new System.Drawing.Size(164, 23);
            this.txtsubTotal.TabIndex = 44;
            // 
            // txtidProveedor
            // 
            this.txtidProveedor.Location = new System.Drawing.Point(230, 102);
            this.txtidProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtidProveedor.Name = "txtidProveedor";
            this.txtidProveedor.Size = new System.Drawing.Size(164, 23);
            this.txtidProveedor.TabIndex = 41;
            // 
            // txtnumFactura
            // 
            this.txtnumFactura.Location = new System.Drawing.Point(230, 45);
            this.txtnumFactura.Margin = new System.Windows.Forms.Padding(5);
            this.txtnumFactura.Name = "txtnumFactura";
            this.txtnumFactura.Size = new System.Drawing.Size(164, 23);
            this.txtnumFactura.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Sub Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tipo de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Factura #";
            // 
            // prograIVDataSet1
            // 
            this.prograIVDataSet1.DataSetName = "PrograIVDataSet1";
            this.prograIVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prograIVDataSet1BindingSource
            // 
            this.prograIVDataSet1BindingSource.DataSource = this.prograIVDataSet1;
            this.prograIVDataSet1BindingSource.Position = 0;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 3;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(259, 135);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 28);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(230, 489);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(164, 23);
            this.txtDescuento.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 489);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Descuento";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(230, 425);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(5);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(164, 23);
            this.txtIVA.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 436);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "IVA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(230, 173);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFecha.MaxDate = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1985, 6, 20, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(164, 23);
            this.dtpFecha.TabIndex = 55;
            this.dtpFecha.Value = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(230, 306);
            this.chbEstado.Margin = new System.Windows.Forms.Padding(5);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(76, 21);
            this.chbEstado.TabIndex = 56;
            this.chbEstado.Text = "Pagado";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DataSource = this.tipoPagoBindingSource;
            this.cmbTipoPago.DisplayMember = "desTipoPago";
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(230, 239);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(164, 25);
            this.cmbTipoPago.TabIndex = 57;
            this.cmbTipoPago.ValueMember = "idTipoPago";
            // 
            // tipoPagoBindingSource
            // 
            this.tipoPagoBindingSource.DataMember = "tipoPago";
            this.tipoPagoBindingSource.DataSource = this.prograIVDataSet;
            // 
            // tipoPagoTableAdapter
            // 
            this.tipoPagoTableAdapter.ClearBeforeFill = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.chbEstado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtsubTotal);
            this.Controls.Add(this.txtidProveedor);
            this.Controls.Add(this.txtnumFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prograIVDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtsubTotal;
        private System.Windows.Forms.TextBox txtidProveedor;
        private System.Windows.Forms.TextBox txtnumFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource prograIVDataSet1BindingSource;
        private PrograIVDataSet1 prograIVDataSet1;
        private PrograIVDataSet prograIVDataSet;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private PrograIVDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.BindingSource tipoPagoBindingSource;
        private PrograIVDataSetTableAdapters.tipoPagoTableAdapter tipoPagoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoPago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}