﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Entidades;
using System.Data.SqlClient;
using System.Configuration;


namespace ProyectoFinal
{


    public partial class frmProveedores : Form
    {


        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;

        // conjunto de métodos a utilizar.
        #region "Metodos"
            
            // establece la conexión con la BD
        private bool establecerConexion()
        {
            try
            {
                cnx = new SqlConnection();
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
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

        //Actualiza el grid del formulario.
        public void actualizargrid()
        {

            frmPrincipal.listaProveedor.Clear();
            dgvProveedores.DataSource = new List<Proveedor>();
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "Select * from Proveedor";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Proveedor objProveedor = new Proveedor();
                objProveedor.idProveedor= dr.GetInt32(0);
                objProveedor.desProveedor = dr.GetString(1);
                objProveedor.codTipoProveedor = dr.GetInt32(2);
                
                frmPrincipal.listaProveedor.Add(objProveedor);
            }

            dgvProveedores.DataSource = frmPrincipal.listaProveedor;
            cnx.Close();
            cnx.Dispose();
            



        }

        //permite limpiar los controles del formulario.
        void limpiarControles()
        {
            txtIdProveedor.Text = "";
            txtnomProveedor.Text = string.Empty;
           // cmbTipoProveedor.SelectedIndex = 0;
            txtIdProveedor.Focus();
        }

        //Obtiene los parametros necesarios para enviar a la BD en los distintos métodos.
        void obtenerparametros()
        {
            try
            {
                Proveedor objproveedor = new Proveedor();
                objproveedor.idProveedor = Convert.ToInt32(txtIdProveedor.Text);
                objproveedor.desProveedor = txtnomProveedor.Text;
                objproveedor.codTipoProveedor = Convert.ToInt32(cmbTipoProveedor.SelectedValue);
                cmd.Parameters.AddWithValue("@idproveedor", objproveedor.idProveedor);
                cmd.Parameters.AddWithValue("@nomproveedor", objproveedor.desProveedor);
                cmd.Parameters.AddWithValue("@tipoproveedor", objproveedor.codTipoProveedor);
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        //Método utilizado para crear un proveedor.
        void crearproveedor()
        {
            try
            { 
            establecerConexion();
            cmd = new SqlCommand();
            obtenerparametros();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "SP_AddProveedor";
            
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                }

                else
                {
                    MessageBox.Show("No se pudo agregar el proveedor");
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
            cnx.Close();
            cnx.Dispose();

        }
       
        //Método utilizado para modificar un proveedor.
        void modificarproveedor()
        {
            
            if (txtIdProveedor.Text == string.Empty)
            {
                return;
            }

            establecerConexion();
            cmd = new SqlCommand();
            obtenerparametros();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;  
            cmd.CommandText = "SP_UpdProveedor";
            int cont = cmd.ExecuteNonQuery();
            if (cont == 1)
            {
                MessageBox.Show("Modificacion exitosa");
            }
            else
            {
                MessageBox.Show("Modificacion Fallida");
            }
            cnx.Close();
            cnx.Dispose();


        }

        //Método utilizado para eliminar un proveedor.
        void eliminarproveedor()
        {

            if (txtIdProveedor.Text == string.Empty)
            {
                return;
            }
      
            establecerConexion();
            cmd = new SqlCommand();
            obtenerparametros();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "SP_DelProveedor";
            try
            {
                int cont = cmd.ExecuteNonQuery();
                if (cont == 1)
                {
                    MessageBox.Show("Eliminación exitosa");
                }
                else
                {
                    MessageBox.Show("Eliminación Fallida");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problema al Eliminar los Datos:" + ex.Message);
            }
            
            
            cnx.Close();
            cnx.Dispose();


        }


        #endregion


        public frmProveedores()
        {
            InitializeComponent();
            actualizargrid();
            limpiarControles();
            
        }

        // Eventos utilizados por el formulario.
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            limpiarControles();
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.prograIVDataSet1.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.TipoProveedor' Puede moverla o quitarla según sea necesario.
            this.tipoProveedorTableAdapter1.Fill(this.prograIVDataSet1.TipoProveedor);
            

        }

        private void TxtnomProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            crearproveedor();
            limpiarControles();
            actualizargrid();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            modificarproveedor();
            limpiarControles();
            actualizargrid();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarproveedor();
            limpiarControles();
            actualizargrid();
             
        }

        private void DgvProveedores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtnomProveedor.Text = dgvProveedores.CurrentRow.Cells["desProveedor"].Value.ToString();
            txtIdProveedor.Text = dgvProveedores.CurrentRow.Cells["idProveedor"].Value.ToString();
            cmbTipoProveedor.SelectedValue = dgvProveedores.CurrentRow.Cells["TipoProveedor"].Value.ToString();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
