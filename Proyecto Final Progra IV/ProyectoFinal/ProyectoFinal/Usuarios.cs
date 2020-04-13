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
    public partial class Usuarios : Form
    {

        SqlConnection cnx; //Declaracion de objetos
        SqlCommand cmd;
        int total;


        public Usuarios()
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


        void consultaUsuarios()
        {
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
            cmd.CommandText = "SP_ConsultaUsuario"; // nombre del Stored procedure en la BD
            //dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgUsuarios.DataSource = dt;
          
        }

   


        void crearUsuarios()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
                cmd.CommandText = ("SP_AddUsuario");
                //cmd.Parameters.AddWithValue("@idusuario", txtId.Text);// pasa el parametro con el valor de la caja de texto indicada, para ejecutar el SP
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contrasenna", txtContrasenna.Text);
                cmd.Parameters.AddWithValue("@idpersona", txtIdPersona.Text);
              
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


        void modificaUsuario()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
                cmd.CommandText = ("SP_UpdUsuario");
                cmd.Parameters.AddWithValue("@idusuario", dgUsuarios.CurrentRow.Cells["ID_Usuario"].Value.ToString());
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contrasenna", txtContrasenna.Text);
                cmd.Parameters.AddWithValue("@idpersona", txtIdPersona.Text);


                total = cmd.ExecuteNonQuery(); //se cuenta la cantidad de lineas afectadas

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
        void eliminaUsuario()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;// establece el tipo como stored procedure
                cmd.CommandText = ("SP_DelUsuario");
                cmd.Parameters.AddWithValue("@idusuario", dgUsuarios.CurrentRow.Cells["ID_Usuario"].Value.ToString());// pasa el parametro con el valor de la caja de texto indicada, para ejecutar el SP
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
            txtUsuario.Text = string.Empty; //limpia las cajas de texto
            txtContrasenna.Text = string.Empty;
            txtIdPersona.Text = string.Empty;
            txtUsuario.Focus();
        }








        #endregion

        private void Usuarios_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            establecerConexion();

            consultaUsuarios();
            

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            establecerConexion();
            crearUsuarios();
            consultaUsuarios();
            limpiarControles();


        }

        private void DgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int rowIndex = e.RowIndex;//obtiene la fila que se selecciono
                DataGridViewRow row = dgUsuarios.Rows[rowIndex];//actualiza el "row"
                if (row.Cells[1].Value.ToString() == "") //verifica que la celda seleccionada no sea vacia y así no se caiga el programa
                {
                    return;
                }
                else
                {
                    //txtId.Text = dgPersonas.CurrentRow.Cells["ID"].Value.ToString(); //pone el valor seleccionado en las cajas de texto 
                    txtUsuario.Text = dgUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                    txtContrasenna.Text = dgUsuarios.CurrentRow.Cells["Contrasenna"].Value.ToString();
                    txtIdPersona.Text = dgUsuarios.CurrentRow.Cells["ID_Persona"].Value.ToString();
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            establecerConexion();
            modificaUsuario();
            consultaUsuarios();
            limpiarControles();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            establecerConexion();
            eliminaUsuario();
            consultaUsuarios();
            limpiarControles();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
