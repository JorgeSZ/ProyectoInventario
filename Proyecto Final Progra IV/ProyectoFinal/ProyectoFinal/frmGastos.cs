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
    public partial class frmGastos : Form
    {
        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        #region Metodos
        //Establece conexión con la BD
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

        //Actualiza el grid del formulario
        public void actualizargrid()
        {

            frmPrincipal.listaGastos.Clear();
            dgvGasto.DataSource = new List<Gasto>();
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "SP_MostrarGasto";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto objgasto = new Gasto();
                objgasto.idGasto = dr.GetInt32(0);
                objgasto.idVendedor = dr.GetInt32(1);
                objgasto.nomVendedor = dr.GetString(2);
                objgasto.Monto = dr.GetDecimal(3);
                objgasto.fecharegistro = dr.GetDateTime(4);
                objgasto.Detalle = dr.GetString(5);

                frmPrincipal.listaGastos.Add(objgasto);
            }

            dgvGasto.DataSource = frmPrincipal.listaGastos;
            cnx.Close();
            cnx.Dispose();




        }

        //limpia los controles del formulario
        void limpiarControles()
        {
            txtMonto.Text = "";
            txtDetalle.Text = string.Empty;
            // cmbTipoProveedor.SelectedIndex = 0;
            txtMonto.Focus();
        }
        //ejecuta el procedimiento necesario para crear un nuevo gasto.
        void crearGasto()   
        {
            try
            {
                establecerConexion();
                cmd = new SqlCommand();
                
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtMonto.Text));
                cmd.Parameters.AddWithValue("@detalle", txtDetalle.Text);
                cmd.Parameters.AddWithValue("@idVendedor", Form1.idUsuario);
                cmd.CommandText = "SP_AddGasto";
                int ins = cmd.ExecuteNonQuery();               
                if (ins>0)
                {

                }

                else
                {
                    MessageBox.Show("No se pudo agregar el Gasto");
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


            cnx.Close();
            cnx.Dispose();

        }
        #endregion
        public frmGastos()
        {
            InitializeComponent();
        }

        private void FrmGastos_Load(object sender, EventArgs e)
        {
            actualizargrid();
            txtMonto.Focus();
            label4.Text = "Nota: Si desea eliminar o modificar un gasto existente," + "\n" + "cree un nuevo gasto con el monto contrario al gasto a eliminar" + "\n" + "y luego ingrese el nuevo gasto a registrar";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            crearGasto();
            actualizargrid();
            limpiarControles();
            

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
