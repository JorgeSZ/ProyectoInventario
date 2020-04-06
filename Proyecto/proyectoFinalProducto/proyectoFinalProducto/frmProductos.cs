using System;
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
using proyectoFinalProducto.Entidades;



namespace proyectoFinalProducto
{
    public partial class frmProductos : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dr;

       // public static List<TipoProductos> listaTiposProducto;

        

        #region "Metodos"

        
        

        private bool establecerConexion()
        {
            try
            {
                
                cnx = new SqlConnection();
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["conexionInventario"].ConnectionString;  //Add Reference configuration
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


         void crearProducto()
         {
             establecerConexion();
             cmd = new SqlCommand();
             SqlParameter prm = new SqlParameter();
             cmd.Connection = cnx;
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.CommandText = "Insertar_Producto";
             cmd.Parameters.Add("@Id", SqlDbType.Int).Value = txtIdProducto.Text;
             cmd.Parameters.Add("@descripcionprod", SqlDbType.VarChar, 50).Value = txtDescripcion.Text;
             cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = cmbTipo.SelectedValue;
             cmd.Parameters.Add("@Cost", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtCosto.Text);
             cmd.Parameters.Add("@Utilidad ", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtUtilidad.Text);
             cmd.Parameters.Add("@proveedor", SqlDbType.VarChar, 50).Value = txtCodproveedor.Text;
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



        #endregion


        public frmProductos()
        {
            InitializeComponent();
        //    listaTiposProducto = new List<TipoProductos>();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearProducto();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyecto_InventarioDataSet.Tipo_Producto' table. You can move, or remove it, as needed.
            this.tipo_ProductoTableAdapter.Fill(this.proyecto_InventarioDataSet.Tipo_Producto);

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   cmbTipo.DataSource = new List<TipoProductos>();
           // cmbTipo.DataSource = listaTiposProducto;
        }
    }
}
