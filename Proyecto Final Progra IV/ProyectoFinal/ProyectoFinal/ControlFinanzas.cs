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

namespace ProyectoFinal
{
    public partial class ControlFinanzas : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;

        public ControlFinanzas()
        {
            InitializeComponent();
        }

        

        private void ControlFinanzas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
           // this.ControlFinanzas.Fill(this.prograIVDataSet1.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.TipoProveedor' Puede moverla o quitarla según sea necesario.
           // this.tipoProveedorTableAdapter1.Fill(this.prograIVDataSet1.TipoProveedor);
        }

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


        
        private void obtenerParametros()
        {

            cmd.Parameters.AddWithValue("@valRegistro", txtRegistro.Text);
            cmd.Parameters.AddWithValue("@valIngreso", txtIngreso.Text);
            cmd.Parameters.AddWithValue("@valGasto", txtGasto.Text);
            cmd.Parameters.AddWithValue("@valAhorro", txtAhorro.Text);
            cmd.Parameters.AddWithValue("@valDetalle", txtDetalle.Text);

        }

        private void crearRegistro()


        
        {
            try
            {
                establecerConexion();
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                obtenerParametros();
                cmd.CommandText = "SP_AddRegistro";


                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                }

                else
                {
                    MessageBox.Show("No se pudo agregar el registro");
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


            cnx.Close();
            cnx.Dispose();

        }


        private void updateRegistro()
        {
            try
            {
                establecerConexion();
                cmd = new SqlCommand();
                obtenerParametros();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SP_ActualizarRegistro";
                int cont = cmd.ExecuteNonQuery();
                if (cont == 1)
                {
                    MessageBox.Show("Acualizacion Exitosa");
                } 
                else
                {
                    MessageBox.Show("Actualizacion Fallida");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            cnx.Close();
            cnx.Dispose();





        }


        private void eliminarRegistro()
        {
            try
            {
                establecerConexion();
                cmd = new SqlCommand();
                //obtenerParametros();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SP_eliminarRegistro";
                int cont = cmd.ExecuteNonQuery();
                if (cont == 1)
                {
                    MessageBox.Show("Eliminacion Exitosa");
                }
                else
                {
                    MessageBox.Show("Eliminacion Fallida");
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
            txtRegistro.Text = "";
            txtIngreso.Text = string.Empty;
            txtGasto.Text = string.Empty;
            txtAhorro.Text = string.Empty;
            txtDetalle.Text = string.Empty;
            

        }
    }
}
