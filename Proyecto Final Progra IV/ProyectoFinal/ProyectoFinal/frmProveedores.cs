using System;
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

        #region "Metodos"
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
        void actualizargrid()
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

        void limpiarControles()
        {
            txtIdProveedor.Text = "";
            txtnomProveedor.Text = string.Empty;
            cmbTipoProveedor.SelectedIndex = 0;
            txtIdProveedor.Focus();
        }

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
            int cont = cmd.ExecuteNonQuery();
            if (cont == 1)
            {
                MessageBox.Show("Eliminación exitosa");
            }
            else
            {
                MessageBox.Show("Eliminación Fallida");
            }
            cnx.Close();
            cnx.Dispose();


        }


        #endregion


        public frmProveedores()
        {
            InitializeComponent();
            actualizargrid();
            
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
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
    }
}
