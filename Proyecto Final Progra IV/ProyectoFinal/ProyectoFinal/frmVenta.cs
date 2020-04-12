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
    public partial class frmVenta : Form
    {
        List<DetalleVenta> listadetalleVenta;
        List<List<DetalleVenta>> listaVenta;
        DetalleVenta objdetalleventa;
        Producto objProducto = new Producto();
        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        public frmVenta()
        {
            InitializeComponent();
            cmbFiltrar.Text = "Nombre";
            listadetalleVenta = new List<DetalleVenta>();
            listaVenta = new List<List<DetalleVenta>>();
            cargargridBusqueda();
            
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        void cargargridBusqueda()
        {
            frmProducto objfrmproducto = new frmProducto();
            objfrmproducto.mostrarProducto();
            dgvBusqueda.DataSource = frmPrincipal.listaProducto;
        }

        void filtrargrid()
        {
            frmPrincipal.listaProducto.Clear();
            dgvBusqueda.DataSource = new List<Producto>();
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@busqueda",txtBuscar.Text);
            if (cmbFiltrar.Text == "ID")
            {
                cmd.CommandText = "SP_LookProductoID";
            }

            else
            cmd.CommandText = "SP_LookProductoDes";


            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                objProducto = new Producto();
                objProducto.idProducto = dr.GetInt32(0);
                objProducto.desProducto = dr.GetString(1);
                objProducto.codTipoProducto = dr.GetInt32(2);
                objProducto.costo = dr.GetDecimal(3);
                objProducto.porcUtilidad = dr.GetDecimal(4);
                objProducto.codProveedor = dr.GetInt32(5);

                frmPrincipal.listaProducto.Add(objProducto);
            }

            dgvBusqueda.DataSource = frmPrincipal.listaProducto;
            cnx.Close();
            cnx.Dispose();

        }

        void cargargridDetalle()
        {
            dgvVenta.DataSource = new List<DetalleVenta>();
            objdetalleventa = new DetalleVenta();

            Producto aux = (from n in frmPrincipal.listaProducto
                            where n.idProducto == Convert.ToInt32(txtIDProducto.Text)
                            select n).FirstOrDefault();
            try
            {
                objdetalleventa.idProducto = aux.idProducto;
                objdetalleventa.desProducto = aux.desProducto;
                objdetalleventa.precio = objProducto.Precio(Convert.ToDouble(aux.costo), Convert.ToDouble(aux.porcUtilidad));
                if (Convert.ToDouble(txtCantidad.Text) > 0)
                {
                    objdetalleventa.cantidad = Convert.ToDouble(txtCantidad.Text);
                    listadetalleVenta.Add(objdetalleventa);
                }
                else
                    MessageBox.Show("'Cantidad' debe ser un valor mayor a 0");
            }
            catch (Exception)
            {
                MessageBox.Show("El campo 'Cantidad' Solo admite valores numéricos mayores a 0");

            }
            dgvVenta.DataSource = listadetalleVenta;

        }
        #endregion

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrargrid();
        }

        private void DgvBusqueda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIDProducto.Text = dgvBusqueda.CurrentRow.Cells["idProducto"].Value.ToString();
            
            
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            cargargridDetalle();

         
            

        }
    }
}
