﻿namespace ProyectoFinal
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
            this.frmProveedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsPersonas = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tipoProductoTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProductoTableAdapter();
            this.tipoProveedorTableAdapter = new ProyectoFinal.PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmProveedores,
            this.toolStripButton2,
            this.toolStripButton3,
            this.tsPersonas,
            this.tsbUsuarios,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmProveedores
            // 
            this.frmProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.frmProveedores.Image = ((System.Drawing.Image)(resources.GetObject("frmProveedores.Image")));
            this.frmProveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.frmProveedores.Name = "frmProveedores";
            this.frmProveedores.Size = new System.Drawing.Size(23, 22);
            this.frmProveedores.Text = "btnProveedores";
            this.frmProveedores.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // tsPersonas
            // 
            this.tsPersonas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPersonas.Image = ((System.Drawing.Image)(resources.GetObject("tsPersonas.Image")));
            this.tsPersonas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPersonas.Name = "tsPersonas";
            this.tsPersonas.Size = new System.Drawing.Size(23, 22);
            this.tsPersonas.Text = "toolStripButton1";
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
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoProveedorTableAdapter
            // 
            this.tipoProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
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
        private System.Windows.Forms.ToolStripButton frmProveedores;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private PrograIVDataSet1TableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private PrograIVDataSet1TableAdapters.TipoProveedorTableAdapter tipoProveedorTableAdapter;
        private System.Windows.Forms.ToolStripButton tsPersonas;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}