namespace ProyectoFinal
{
    partial class frmInventario
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.txtaddProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtminProducto = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 1;
            this.label1.Tag = "ID Producto";
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar Producto";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 3;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(156, 314);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 38);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.desProducto,
            this.cantProducto,
            this.fechaModificación});
            this.dgvInventario.Location = new System.Drawing.Point(448, 53);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(852, 484);
            this.dgvInventario.TabIndex = 5;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 47;
            // 
            // desProducto
            // 
            this.desProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.desProducto.DataPropertyName = "desProducto";
            this.desProducto.HeaderText = "Producto";
            this.desProducto.Name = "desProducto";
            this.desProducto.ReadOnly = true;
            this.desProducto.Width = 94;
            // 
            // cantProducto
            // 
            this.cantProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantProducto.DataPropertyName = "cantProducto";
            this.cantProducto.HeaderText = "Cantidad de Productos";
            this.cantProducto.Name = "cantProducto";
            this.cantProducto.ReadOnly = true;
            this.cantProducto.Width = 168;
            // 
            // fechaModificación
            // 
            this.fechaModificación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaModificación.DataPropertyName = "fechaModificacion";
            this.fechaModificación.HeaderText = "Fecha Ultima Modificación Manual";
            this.fechaModificación.Name = "fechaModificación";
            this.fechaModificación.ReadOnly = true;
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(156, 58);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(248, 24);
            this.txtidProducto.TabIndex = 1;
            // 
            // txtaddProducto
            // 
            this.txtaddProducto.Location = new System.Drawing.Point(156, 141);
            this.txtaddProducto.Name = "txtaddProducto";
            this.txtaddProducto.Size = new System.Drawing.Size(248, 24);
            this.txtaddProducto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disminuir Producto";
            // 
            // txtminProducto
            // 
            this.txtminProducto.Location = new System.Drawing.Point(156, 223);
            this.txtminProducto.Name = "txtminProducto";
            this.txtminProducto.Size = new System.Drawing.Size(248, 24);
            this.txtminProducto.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 3;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCerrar.Location = new System.Drawing.Point(1261, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 34);
            this.btnCerrar.TabIndex = 53;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 587);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtminProducto);
            this.Controls.Add(this.txtaddProducto);
            this.Controls.Add(this.txtidProducto);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.Tag = " ";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.TextBox txtaddProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtminProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn desProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificación;
        private System.Windows.Forms.Button btnCerrar;
    }
}