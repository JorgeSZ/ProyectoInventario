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
    public partial class frmInventario : Form
    {
        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        public frmInventario()
        {
            InitializeComponent();
        }
        #region Metodos

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
        public void actualizargrid()
        {

            frmPrincipal.listaProveedor.Clear();
            dgvInventario.DataSource = new List<Inventario>();
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "SP_CargarInventario";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Inventario objInventario = new Inventario();
                objInventario.idProducto = dr.GetInt32(0);
                objInventario.desProducto = dr.GetString(1);
                objInventario.cantProducto = Convert.ToDouble(dr.GetDecimal(2));
                objInventario.fechaModificacion = dr.GetDateTime(3);

                frmPrincipal.listaInventario.Add(objInventario);
            }

            dgvInventario.DataSource = frmPrincipal.listaInventario;
            cnx.Close();
            cnx.Dispose();




        }

        #endregion
        private void Inventario_Load(object sender, EventArgs e)
        {
            actualizargrid();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
