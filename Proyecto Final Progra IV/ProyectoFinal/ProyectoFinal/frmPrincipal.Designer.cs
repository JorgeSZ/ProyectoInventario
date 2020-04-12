namespace ProyectoFinal
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnProveedores = new System.Windows.Forms.ToolStripButton();
            this.tsbProducto = new System.Windows.Forms.ToolStripButton();
            this.tsbFactura = new System.Windows.Forms.ToolStripButton();
            this.tsPersonas = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbInventario = new System.Windows.Forms.ToolStripButton();
            this.tipoProductoTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProductoTableAdapter();
            this.tipoProveedorTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter();
            this.tsbVenta = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProveedores,
            this.tsbProducto,
            this.tsbFactura,
            this.tsPersonas,
            this.tsbUsuarios,
            this.tsbInventario,
            this.tsbVenta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnProveedores
            // 
            this.btnProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(23, 22);
            this.btnProveedores.Text = "btnProveedores";
            this.btnProveedores.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbProducto
            // 
            this.tsbProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProducto.Image = ((System.Drawing.Image)(resources.GetObject("tsbProducto.Image")));
            this.tsbProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProducto.Name = "tsbProducto";
            this.tsbProducto.Size = new System.Drawing.Size(23, 22);
            this.tsbProducto.Text = "Producto";
            this.tsbProducto.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // tsbFactura
            // 
            this.tsbFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsbFactura.Image")));
            this.tsbFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFactura.Name = "tsbFactura";
            this.tsbFactura.Size = new System.Drawing.Size(23, 22);
            this.tsbFactura.Text = "tsbFactura";
            this.tsbFactura.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // tsPersonas
            // 
            this.tsPersonas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPersonas.Image = ((System.Drawing.Image)(resources.GetObject("tsPersonas.Image")));
            this.tsPersonas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPersonas.Name = "tsPersonas";
            this.tsPersonas.Size = new System.Drawing.Size(23, 22);
            this.tsPersonas.Text = "Personas";
            this.tsPersonas.Click += new System.EventHandler(this.TsPersonas_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuarios.Image")));
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(23, 22);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Click += new System.EventHandler(this.TsbUsuarios_Click);
            // 
            // tsbInventario
            // 
            this.tsbInventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInventario.Image = ((System.Drawing.Image)(resources.GetObject("tsbInventario.Image")));
            this.tsbInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInventario.Name = "tsbInventario";
            this.tsbInventario.Size = new System.Drawing.Size(23, 22);
            this.tsbInventario.Text = "Inventario";
            this.tsbInventario.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoProveedorTableAdapter
            // 
            this.tipoProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tsbVenta
            // 
            this.tsbVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVenta.Image = ((System.Drawing.Image)(resources.GetObject("tsbVenta.Image")));
            this.tsbVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVenta.Name = "tsbVenta";
            this.tsbVenta.Size = new System.Drawing.Size(23, 22);
            this.tsbVenta.Text = "Venta";
            this.tsbVenta.Click += new System.EventHandler(this.TsbVenta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Sistema de Control Verdulería";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnProveedores;
        private System.Windows.Forms.ToolStripButton tsbProducto;
        private System.Windows.Forms.ToolStripButton tsbFactura;
        private PrograIVDataSet1TableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter tipoProveedorTableAdapter;
        private System.Windows.Forms.ToolStripButton tsPersonas;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbInventario;
        private System.Windows.Forms.ToolStripButton tsbVenta;
    }
}