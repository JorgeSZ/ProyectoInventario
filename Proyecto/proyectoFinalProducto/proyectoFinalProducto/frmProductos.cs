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


        #region "Metodos"

        private bool establecerConexion()
        {
            try
            {
                cnx = new SqlConnection();
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["conexionInventario"].ConnectionString;
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
            cmd.CommandText = "Insert_Prod";
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = txtIdProducto.Text;
            cmd.Parameters.Add("@Prod", SqlDbType.VarChar, 50).Value = txtProducto.Text;
            cmd.Parameters.Add("@Tip", SqlDbType.Int).Value = cmbTipoProducto.SelectedValue;
            cmd.Parameters.Add("@Cost", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtCosto.Text);
            cmd.Parameters.Add("@Uti", SqlDbType.Decimal, 2).Value = Convert.ToDecimal(txtUtilidad.Text);
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
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
