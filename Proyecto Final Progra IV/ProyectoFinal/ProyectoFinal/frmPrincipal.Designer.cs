// Original
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbVenta = new System.Windows.Forms.ToolStripButton();
            this.tsbInventario = new System.Windows.Forms.ToolStripButton();
            this.tsbReportes = new System.Windows.Forms.ToolStripButton();
            this.tsbGastos = new System.Windows.Forms.ToolStripButton();
            this.tsbProducto = new System.Windows.Forms.ToolStripButton();
            this.tsbFactura = new System.Windows.Forms.ToolStripButton();
            this.btnProveedores = new System.Windows.Forms.ToolStripButton();
            this.tsPersonas = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tipoProductoTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProductoTableAdapter();
            this.tipoProveedorTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbVenta,
            this.tsbInventario,
            this.tsbReportes,
            this.tsbGastos,
            this.tsbProducto,
            this.tsbFactura,
            this.btnProveedores,
            this.tsPersonas,
            this.tsbUsuarios});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1246, 80);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbVenta
            // 
            this.tsbVenta.AutoSize = false;
            this.tsbVenta.Image = global::ProyectoFinal.Properties.Resources.venta;
            this.tsbVenta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVenta.Name = "tsbVenta";
            this.tsbVenta.Size = new System.Drawing.Size(70, 70);
            this.tsbVenta.Text = "Venta";
            this.tsbVenta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbVenta.Click += new System.EventHandler(this.TsbVenta_Click);
            // 
            // tsbInventario
            // 
            this.tsbInventario.AutoSize = false;
            this.tsbInventario.Image = global::ProyectoFinal.Properties.Resources.inventario;
            this.tsbInventario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInventario.Name = "tsbInventario";
            this.tsbInventario.Size = new System.Drawing.Size(70, 70);
            this.tsbInventario.Text = "Inventario";
            this.tsbInventario.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbInventario.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // tsbReportes
            // 
            this.tsbReportes.AutoSize = false;
            this.tsbReportes.Image = global::ProyectoFinal.Properties.Resources.reportes;
            this.tsbReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Size = new System.Drawing.Size(70, 70);
            this.tsbReportes.Text = "Reportes";
            this.tsbReportes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbReportes.Click += new System.EventHandler(this.TsbReportes_Click);
            // 
            // tsbGastos
            // 
            this.tsbGastos.AutoSize = false;
            this.tsbGastos.Image = global::ProyectoFinal.Properties.Resources.gastos;
            this.tsbGastos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGastos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGastos.Name = "tsbGastos";
            this.tsbGastos.Size = new System.Drawing.Size(70, 70);
            this.tsbGastos.Text = "Gastos";
            this.tsbGastos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbGastos.Click += new System.EventHandler(this.TsbGastos_Click);
            // 
            // tsbProducto
            // 
            this.tsbProducto.AutoSize = false;
            this.tsbProducto.Image = global::ProyectoFinal.Properties.Resources.Productos;
            this.tsbProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProducto.Name = "tsbProducto";
            this.tsbProducto.Size = new System.Drawing.Size(70, 70);
            this.tsbProducto.Text = "Producto";
            this.tsbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbProducto.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // tsbFactura
            // 
            this.tsbFactura.AutoSize = false;
            this.tsbFactura.Image = global::ProyectoFinal.Properties.Resources.factura;
            this.tsbFactura.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tsbFactura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFactura.Name = "tsbFactura";
            this.tsbFactura.Size = new System.Drawing.Size(70, 70);
            this.tsbFactura.Text = "Factura";
            this.tsbFactura.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbFactura.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoSize = false;
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProveedores.Image = global::ProyectoFinal.Properties.Resources.Proveedores;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(72, 70);
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnProveedores.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsPersonas
            // 
            this.tsPersonas.AutoSize = false;
            this.tsPersonas.Image = global::ProyectoFinal.Properties.Resources.Personas;
            this.tsPersonas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tsPersonas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsPersonas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPersonas.Name = "tsPersonas";
            this.tsPersonas.Size = new System.Drawing.Size(70, 70);
            this.tsPersonas.Text = "Personas";
            this.tsPersonas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsPersonas.Click += new System.EventHandler(this.TsPersonas_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.AutoSize = false;
            this.tsbUsuarios.Image = global::ProyectoFinal.Properties.Resources.usuarios;
            this.tsbUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(70, 70);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbUsuarios.Click += new System.EventHandler(this.TsbUsuarios_Click);
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoProveedorTableAdapter
            // 
            this.tipoProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1246, 655);
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
        private System.Windows.Forms.ToolStripButton tsbGastos;
        private System.Windows.Forms.ToolStripButton tsbReportes;
    }
}