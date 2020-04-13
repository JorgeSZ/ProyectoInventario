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
        //Declara las variables globales utilizadas.
        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        double auminventario;
        double disinventario;
        int id;
        public frmInventario()
        {
            InitializeComponent();
            actualizargrid();
        }

        //Grupo de métodos utilizados.
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

            frmPrincipal.listaInventario.Clear();
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

        // Permite hacer una modificación manual del inventario.
        public void modificarinventario()
        {
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UpdInventario";
            try
            {
                id = Convert.ToInt32(txtidProducto.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("El campo 'ID' solo puede tener valores enteros");
                
            }
            cmd.Parameters.AddWithValue("@idproducto", id);
            cmd.Parameters.AddWithValue("@cantproductos", this.totalproducto());
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Modificación exitosa");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Dato no modificado: " + ex.Message);
            }
            cnx.Close();
            cnx.Dispose();

        }
    

        //obtiene el total a agregar en el inventario.
        double totalproducto()
        {
            try
            {
                auminventario = Convert.ToInt32(txtaddProducto.Text);
                disinventario = Convert.ToInt32(txtminProducto.Text);
                
            }

            catch(Exception)
            {
                MessageBox.Show("Por favor verifique los valores ingresados");
            }
            return auminventario - disinventario;
            
        }

        //limpia los controles de la pantalla.
        void limpiarPantalla()
        {
            txtidProducto.Text = "";
            txtaddProducto.Text = "";
            txtminProducto.Text = "";
            txtidProducto.Focus();
        }
        #endregion
        private void Inventario_Load(object sender, EventArgs e)
        {
            txtidProducto.Focus();
               
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            modificarinventario();
            actualizargrid();
            limpiarPantalla();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
