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

        private void crearproducto()
        {
            try
            { 
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@idproveedor", txtIdProveedor.Text);
            cmd.Parameters.AddWithValue("@nomproveedor", txtnomProveedor.Text);
            cmd.Parameters.AddWithValue("@tipoproveedor", cmbTipoProveedor.SelectedIndex);
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
    



        void limpiarControles()
        {
            txtIdProveedor.Text = "";
            txtnomProveedor.Text = string.Empty;
            cmbTipoProveedor.SelectedIndex = 0;
        }

        //void consultarProductos()
        //{
        //    frmPrincipal.listaProveedor.Clear();

        //    //dgDatosProducto.DataSource = new List<Producto>();
        //    establecerConexion();
        //    cmd = new SqlCommand();
        //    cmd.Connection = cnx;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandTimeout = 0;
        //    cmd.CommandText = "Select * from Productos";
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Producto objProducto = new Producto();
        //        objProducto.idProducto = dr.GetInt32(0);
        //        objProducto.desProducto = dr.GetString(1);
        //        objProducto.codTipo = dr.GetInt32(2);
        //        objProducto.costoProd = dr.GetDecimal(3);
        //        objProducto.porcUtilidad = dr.GetDecimal(4);
        //        frmPrincipal.listaProductos.Add(objProducto);
        //    }

        //    dgDatosProducto.DataSource = frmPrincipal.listaProductos;
        //    cnx.Close();
        //    cnx.Dispose();



        //}

        #endregion
        public frmProveedores()
        {
            InitializeComponent();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            crearproducto();
        }
    }
}
