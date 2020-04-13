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
    public partial class Form1 : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        public static int idUsuario { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
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




        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Login()
        {

            //establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Login";
            cmd.Parameters.AddWithValue("@us", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@pass", txtContrasenna.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idUsuario = dr.GetInt32(0);
                frmPrincipal form2 = new frmPrincipal();
                MessageBox.Show("Inicio correcto");
                this.Hide();
                form2.ShowDialog();
                this.Close();

            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            


        }

        private void validaCampos()
        {
            if(txtUsuario.Text == "")
            {
                lblErrorUsuario.Show();


            }
            else
            {
                lblErrorUsuario.Hide();


            }
            if(txtContrasenna.Text =="")
            {

                lblErrorContrasenna.Show();
            }
            else
            {
                lblErrorContrasenna.Hide();

            }

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            validaCampos();
            establecerConexion();
            Login();

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtContrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnIngresar_Click(sender, e);
            }
        }
    }
    #endregion
}
