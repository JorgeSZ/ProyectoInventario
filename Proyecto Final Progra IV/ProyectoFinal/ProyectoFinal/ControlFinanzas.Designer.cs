namespace ProyectoFinal
{
    partial class ControlFinanzas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtAhorro = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgFinanzas = new System.Windows.Forms.DataGridView();
            this.idRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dahorro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnActuaizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinanzas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Ingrese en formato de diaFecha)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ahorros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto gasto del dia ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto de ingreso del dia";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(223, 67);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 22);
            this.txtRegistro.TabIndex = 6;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(223, 131);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 22);
            this.txtIngreso.TabIndex = 7;
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(223, 200);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(100, 22);
            this.txtGasto.TabIndex = 8;
            // 
            // txtAhorro
            // 
            this.txtAhorro.Location = new System.Drawing.Point(223, 257);
            this.txtAhorro.Name = "txtAhorro";
            this.txtAhorro.Size = new System.Drawing.Size(100, 22);
            this.txtAhorro.TabIndex = 9;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(223, 328);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 22);
            this.txtDetalle.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingresar un registro";
            // 
            // dgFinanzas
            // 
            this.dgFinanzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFinanzas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRegistro,
            this.ingreso,
            this.gasto,
            this.dahorro,
            this.detalle});
            this.dgFinanzas.Location = new System.Drawing.Point(645, 47);
            this.dgFinanzas.Name = "dgFinanzas";
            this.dgFinanzas.RowTemplate.Height = 24;
            this.dgFinanzas.Size = new System.Drawing.Size(602, 315);
            this.dgFinanzas.TabIndex = 12;
            // 
            // idRegistro
            // 
            this.idRegistro.DataPropertyName = "idregistro";
            this.idRegistro.HeaderText = "idRegistro";
            this.idRegistro.Name = "idRegistro";
            // 
            // ingreso
            // 
            this.ingreso.DataPropertyName = "ingreso";
            this.ingreso.HeaderText = "ingreso";
            this.ingreso.Name = "ingreso";
            // 
            // gasto
            // 
            this.gasto.DataPropertyName = "gasto";
            this.gasto.HeaderText = "gasto";
            this.gasto.Name = "gasto";
            // 
            // dahorro
            // 
            this.dahorro.DataPropertyName = "dahorro";
            this.dahorro.HeaderText = "dahorro";
            this.dahorro.Name = "dahorro";
            // 
            // detalle
            // 
            this.detalle.DataPropertyName = "detalle";
            this.detalle.HeaderText = "detalle";
            this.detalle.Name = "detalle";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(223, 387);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(86, 37);
            this.btnIngresar.TabIndex = 13;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnActuaizar
            // 
            this.btnActuaizar.Location = new System.Drawing.Point(723, 392);
            this.btnActuaizar.Name = "btnActuaizar";
            this.btnActuaizar.Size = new System.Drawing.Size(95, 32);
            this.btnActuaizar.TabIndex = 14;
            this.btnActuaizar.Text = "Actualizar";
            this.btnActuaizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1015, 392);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 32);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ControlFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActuaizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dgFinanzas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtAhorro);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ControlFinanzas";
            this.Text = "ControlFinanzas";
            this.Load += new System.EventHandler(this.ControlFinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFinanzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.TextBox txtAhorro;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgFinanzas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dahorro;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnActuaizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}