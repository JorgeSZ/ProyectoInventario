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



    public partial class Personas : Form
    {

        SqlConnection cnx; //Declaracion de objetos
        SqlCommand cmd;
        SqlDataReader dr;
        int total;

        public Personas()
        {
            InitializeComponent();
        }


        #region Metodos
        private bool establecerConexion()
        {
            try
            {
                cnx = new SqlConnection();//inicializa
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString; // consulta el conection string del app.config
                cnx.Open(); //abre conexión
                if (cnx.State == ConnectionState.Open)// pregunta si se pudo realizar o abrir la conexión
                {
                    return true;//devuelve true
                }
                else
                {
                    return false; //devuelve false indicando que no pudo conectarse
                }

            }
            catch (Exception)
            {

                return false;
            }
        }


        void consultaPersonas ()
        {
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
            cmd.CommandText = "SP_ConsultaPersona"; // nombre del Stored procedure en la BD
            //dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgPersonas.DataSource = dt;
          
        }


        void crearPersona()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
                cmd.CommandText = ("SP_AddPersona");
                cmd.Parameters.AddWithValue("@idpersona", txtId.Text);// pasa el parametro con el valor de la caja de texto indicada, para ejecutar el SP
                cmd.Parameters.AddWithValue("@nompersona", txtNombre.Text);
                cmd.Parameters.AddWithValue("@ape1persona", txtApe1.Text);
                cmd.Parameters.AddWithValue("@ape2persona", txtApe2.Text);
                cmd.Parameters.AddWithValue("@fechapersona", dtpFecha.Value);
                cmd.ExecuteNonQuery();//ejecuta query
                cnx.Close();//cierra conexión
                cnx.Dispose();
                MessageBox.Show("Insertado correctamente");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        void modificaPersona()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
                cmd.CommandText = ("SP_UpdPersona");
                cmd.Parameters.AddWithValue("@idpersona", txtId.Text);// pasa el parametro con el valor de la caja de texto indicada, para ejecutar el SP
                cmd.Parameters.AddWithValue("@nompersona", txtNombre.Text);
                cmd.Parameters.AddWithValue("@ape1persona", txtApe1.Text);
                cmd.Parameters.AddWithValue("@ape2persona", txtApe2.Text);
                cmd.Parameters.AddWithValue("@fechapersona", dtpFecha.Value);

                
                 total= cmd.ExecuteNonQuery(); //se cuenta la cantidad de lineas afectadas

                if (total > 0)//si es mayor a 0, significa que si se modifico correctamente 
                {
                    cnx.Close();//cierra conexión
                    cnx.Dispose();
                    MessageBox.Show("Modificado correctamente");

                }
                else
                {
                    MessageBox.Show("Ningun registro fue modificado");

                }

                total = 0;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        void eliminaPersona()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
                cmd.CommandText = ("SP_DelPersona");
                cmd.Parameters.AddWithValue("@idpersona", txtId.Text);// pasa el parametro con el valor de la caja de texto indicada, para ejecutar el SP
                total = cmd.ExecuteNonQuery(); //se cuenta la cantidad de lineas afectadas

                if (total > 0) //si es mayor a 0, significa que si se elimino correctamente 
                {
                    cnx.Close();//cierra conexión
                    cnx.Dispose();
                    MessageBox.Show("Eliminado correctamente");
                }
                else
                {

                    MessageBox.Show("Ningun registro fue eliminado");


                }

                total = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        void limpiarControles()
        {
            txtId.Text = string.Empty; //limpia las cajas de texto
            txtNombre.Text = string.Empty;
            txtApe1.Text = string.Empty;
            txtApe2.Text = string.Empty;
           
        }

        #endregion

        private void Personas_Load(object sender, EventArgs e)
        {
            establecerConexion();
            
            consultaPersonas();
            
        }





        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            establecerConexion();
            crearPersona();
            consultaPersonas();
            limpiarControles();
        }

  


        private void DgPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int rowIndex = e.RowIndex;//obtiene la fila que se selecciono
                DataGridViewRow row = dgPersonas.Rows[rowIndex];//actualiza el "row"
                if (row.Cells[1].Value.ToString() == "") //verifica que la celda seleccionada no sea vacia y así no se caiga el programa
                {
                    return;
                }
                else
                {
                    txtId.Text = dgPersonas.CurrentRow.Cells["ID"].Value.ToString(); //pone el valor seleccionado en las cajas de texto 
                    txtNombre.Text = dgPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtApe1.Text = dgPersonas.CurrentRow.Cells["Apellido1"].Value.ToString();
                    txtApe2.Text = dgPersonas.CurrentRow.Cells["Apellido2"].Value.ToString();
                    dtpFecha.Value = Convert.ToDateTime(dgPersonas.CurrentRow.Cells["FechaNacimiento"].Value.ToString());
                }
                
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            establecerConexion();
            modificaPersona();
            consultaPersonas();
            limpiarControles();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            establecerConexion();
            eliminaPersona();
            consultaPersonas();
            limpiarControles();

        }
    }
}
