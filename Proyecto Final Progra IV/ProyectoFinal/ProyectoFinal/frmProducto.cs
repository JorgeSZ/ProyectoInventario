﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ProyectoFinal.Entidades;


namespace ProyectoFinal
{
    public partial class frmProducto : Form
    { 
         SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dr;

        public frmProducto()
        {
            InitializeComponent();
            mostrarProducto();
        }

        //métodos a utilizar.
        #region "Metodos"



            //Establece la conexión con la BD
        private bool establecerConexion()
        {
            try
            {

                cnx = new SqlConnection();
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;  //Add Reference configuration
                cnx.Open();
                if (cnx.State == ConnectionState.Open)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                return false;
            }

        }

        //Método que Permite crear un producto
        void crearProducto()
        {
           
            establecerConexion();
            cmd = new SqlCommand();
            SqlParameter prm = new SqlParameter();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insertar_Producto";
            try
            {
                cmd.Parameters.Add("@descripcionprod", SqlDbType.VarChar, 50).Value = txtDescripcion.Text;
                cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = cmbTipo.SelectedValue;
                cmd.Parameters.Add("@Cost", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtCosto.Text);
                cmd.Parameters.Add("@Utilidad ", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtUtilidad.Text);
                cmd.Parameters.Add("@proveedor", SqlDbType.VarChar, 50).Value = txtCodproveedor.Text;
            }
            catch(Exception )
            {
                MessageBox.Show("Por Favor verifique los valores ingresados");
                return;
            }
           
            // cmd.ExecuteNonQuery();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Ingreso exitoso");
            }

            catch (Exception)
            {
                MessageBox.Show("Dato no ingresado");
            }
            cnx.Close();
            cnx.Dispose();

        }

        //Método que Permite eliminar un producto
        void eliminarProducto()
        {
            if (txtIdProducto.Text == string.Empty)
            {
                return;
            }
            establecerConexion();
            cmd = new SqlCommand();
            SqlParameter prm = new SqlParameter();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Eliminar_Prod";
            cmd.Parameters.Add("Id", SqlDbType.Int).Value = txtIdProducto.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Eliminación exitosa");
            }

            catch (Exception)
            {
                MessageBox.Show("Dato no Eliminado");
            }
            cnx.Close();
            cnx.Dispose();


        }

        //Método que permite mostrar los productos en el grid.
        public void mostrarProducto()
        {
            
            frmPrincipal.listaProducto.Clear();
            dgvProductos.DataSource = new List<Producto>();
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Mostrar_Prod";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto objProducto = new Producto();
                objProducto.idProducto = dr.GetInt32(0);
                objProducto.desProducto = dr.GetString(1);
                objProducto.codTipoProducto = dr.GetInt32(2);
                objProducto.costo = dr.GetDecimal(3);
                objProducto.porcUtilidad = dr.GetDecimal(4);
                objProducto.codProveedor = dr.GetInt32(5);
                frmPrincipal.listaProducto.Add(objProducto);

            }
           
            dgvProductos.DataSource = frmPrincipal.listaProducto;
            cnx.Close();
            cnx.Dispose();


        }

        //Método que permite limpiar los controles del formulario.
        void limpiarPantalla()
        {
            txtIdProducto.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtCosto.Text = String.Empty;
            txtUtilidad.Text = String.Empty;
            txtCodproveedor.Text = String.Empty;
            cmbTipo.SelectedIndex = 0;
            txtIdProducto.Focus();
        }

        //Método que permite modificar un producto.
        void modificarProducto()
        {
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Actualizar_Prod";
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = txtIdProducto.Text;
            cmd.Parameters.Add("@descripcionprod", SqlDbType.VarChar, 50).Value = txtDescripcion.Text;
            cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = cmbTipo.SelectedValue;
            cmd.Parameters.Add("@Cost", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtCosto.Text);
            cmd.Parameters.Add("@Utilidad ", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtUtilidad.Text);
            cmd.Parameters.Add("@proveedor", SqlDbType.VarChar, 50).Value = txtCodproveedor.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Modificación exitosa");
            }

            catch (Exception)
            {
                MessageBox.Show("Dato no modificado");
            }
            cnx.Close();
            cnx.Dispose();

        }

        #endregion


        // Conjunto de eventos que se aplican en el formulario.

            // Eventos click hacen se activan al dar click a un botón del formulario.
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.TipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.prograIVDataSet1.TipoProducto);
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.prograIVDataSet1.Producto);
            limpiarPantalla();

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearProducto();
            mostrarProducto();
            limpiarPantalla();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

           // this.tipo_ProductoTableAdapter.Fill(this.proyecto_InventarioDataSet.Tipo_Producto);
            mostrarProducto();
            txtIdProducto.Focus();

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
            mostrarProducto();
            limpiarPantalla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarProducto();
            mostrarProducto();
            limpiarPantalla();

        }

        //Este método permite cargar los datos de una fila seleccionada en el grid a los controles del formulario.
        private void DgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = dgvProductos.CurrentRow.Cells["idProducto"].Value.ToString();
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells["desProducto"].Value.ToString();
            txtCosto.Text = dgvProductos.CurrentRow.Cells["costo"].Value.ToString();
            txtUtilidad.Text = dgvProductos.CurrentRow.Cells["porcUtilidad"].Value.ToString();
            txtCodproveedor.Text = dgvProductos.CurrentRow.Cells["codProveedor"].Value.ToString();
            cmbTipo.SelectedValue = dgvProductos.CurrentRow.Cells["codTipoProducto"].Value.ToString();




        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor objfrmbusqueda = new frmBusquedaProveedor();
            objfrmbusqueda.ShowDialog();
            txtCodproveedor.Text = frmPrincipal.idbusqueda.ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
