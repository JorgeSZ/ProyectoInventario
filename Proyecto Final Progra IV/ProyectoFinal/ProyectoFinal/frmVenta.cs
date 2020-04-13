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
        //Declara las variables a utilizar.
        List<DetalleVenta> listadetalleVenta;
        List<List<DetalleVenta>> listaVenta;
        DetalleVenta objdetalleventa;
        Producto objProducto = new Producto();
        List<Inventario> cantstock;

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

        //permite obtener el inventario
        private void obtenerinventario() {
            //obtengo el inventario mediante el método actualizar grid de frminventario,que permite cargar la lista almacenada en frmprincipal.
            frmInventario objinventario = new frmInventario();
            objinventario.actualizargrid();

            //declaro la variable cantstock para no modificar la lista que sirve de Datasource en frmInventario.
            cantstock = new List<Inventario>(); 
            cantstock=frmPrincipal.listaInventario;

        }

        //permite establecer conexión con la BD
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


        //permite cargar el grid de búsqueda.
        void cargargridBusqueda()
        {
            //Al ser un grid de productos, se ejecuta el método mostrarproducto de frmproducto que carga la listaproducto y esta última la utilizamos de datasource.
            frmProducto objfrmproducto = new frmProducto();
            objfrmproducto.mostrarProducto();
            dgvBusqueda.DataSource = frmPrincipal.listaProducto;
        }

        //nos permite filtrar el grid de Productos por nombre o por id
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

        //permite cargar el grid de DetalleVenta.
        void cargargridDetalle()
        {
            dgvVenta.DataSource = new List<DetalleVenta>();
            dgvVenta.DataSource = listadetalleVenta;

        }

        //permite agregar un detalle localmente (no en bd) al grid DetallVenta.
        void agregarDetalle()
        {
            objdetalleventa = new DetalleVenta();
            Producto aux = (from n in frmPrincipal.listaProducto
                            where n.idProducto == Convert.ToInt32(txtIDProducto.Text)
                            select n).FirstOrDefault();
            Inventario auxinv = (from n in this.cantstock
                                 where n.idProducto == aux.idProducto
                                 select n).FirstOrDefault();
            try
            {

                if (Convert.ToDouble(txtCantidad.Text) > 0)
                { if (auxinv.cantProducto - Convert.ToDouble(txtCantidad.Text) >= 0)
                    { auxinv.cantProducto = auxinv.cantProducto - Convert.ToDouble(txtCantidad.Text);
                        cantstock.Add(auxinv);

                        objdetalleventa.idProducto = aux.idProducto;
                        objdetalleventa.desProducto = aux.desProducto;
                        objdetalleventa.cantidad = Convert.ToDouble(txtCantidad.Text);
                        objdetalleventa.precio = objProducto.Precio(Convert.ToDouble(aux.costo), Convert.ToDouble(aux.porcUtilidad)) * objdetalleventa.cantidad;
                        listadetalleVenta.Add(objdetalleventa);
                        lblTotal.Text = (Convert.ToDouble(lblTotal.Text) + objdetalleventa.precio).ToString();
                    }
                    else {
                        MessageBox.Show("No quedan suficientes productos en stock. Cantidad disponible: " + auxinv.cantProducto);
                                 }
                }
                else
                    MessageBox.Show("'Cantidad' debe ser un valor mayor a 0");
            }
            catch (Exception)
            {
                MessageBox.Show("El campo 'Cantidad' Solo admite valores numéricos mayores a 0");

            }
        }

        //permite eliminar un detalle localmente.
        void eliminarDetalle()
        { 
            DetalleVenta aux = (from n in this.listadetalleVenta
                                where n.idProducto  == Convert.ToInt32(dgvVenta.CurrentRow.Cells["colidProducto"].Value.ToString()) && n.cantidad == Convert.ToDouble(dgvVenta.CurrentRow.Cells["colcantidad"].Value.ToString())
                                select n).FirstOrDefault();
            if (aux != null)
            {
                Inventario auxinv = (from n in this.cantstock
                                     where n.idProducto == aux.idProducto
                                     select n).FirstOrDefault();
                auxinv.cantProducto = auxinv.cantProducto + aux.cantidad;
                listadetalleVenta.Remove(aux);
                lblTotal.Text = (Convert.ToDouble(lblTotal.Text) - objdetalleventa.precio).ToString();
            }
            else
                MessageBox.Show("No quedan más elementos por eliminar");
            
            
        }

        //agrega la venta y sus detalles a la BD
        void agregarventa()
        {
            try
            {
                establecerConexion();
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
                cmd.Parameters.AddWithValue("@idVendedor", Form1.idUsuario);
                cmd.Parameters.Add("@IdVenta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SP_AddVenta";
                int ins =cmd.ExecuteNonQuery();
                if (ins > 0)
                {
                    int idventa = Convert.ToInt32(cmd.Parameters["@IdVenta"].Value);
                    cmd.Parameters.Clear();
                    foreach (DetalleVenta item in listadetalleVenta)
                    {
                        cmd.Parameters.AddWithValue("@idProducto", item.idProducto);
                        cmd.Parameters.AddWithValue("@ventaid", idventa);
                        cmd.Parameters.AddWithValue("@cantidad", item.cantidad);
                        cmd.Parameters.AddWithValue("@precio", item.precio);
                        cmd.CommandText = "SP_AddDetalle";
                        ins = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }

                    
                    if (ins > 0)
                    {
                        MessageBox.Show("Guardado correctamente");
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DBCC CHECKIDENT (DetalleVenta, RESEED, 0)";
                        cmd.ExecuteNonQuery();

                    }
                    else
                        MessageBox.Show("No se pudo guardar la Venta");

                }
                else
                    MessageBox.Show("No se pudo guardar la Venta");

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

           

            cnx.Close();
                cnx.Dispose();

            
            

        }

        //limpia el grid de detalle.
        void limpiargridDetalle()
        {
            obtenerinventario();
            listadetalleVenta.Clear();
            cargargridDetalle();
            lblTotal.Text = "0";
            txtCantidad.Clear();
        }

        //permite limpiar los campos del formulario
        void limpiarcampos()
        {
            txtBuscar.Text = "";
            txtCantidad.Text = "";
            txtIDProducto.Text = "";
            txtBuscar.Focus();
        }
        #endregion


        //lista de eventos utilizados en el formulario.
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            obtenerinventario();
            lblTotal.Text = "0";
            txtBuscar.Focus();
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
            agregarDetalle();
            cargargridDetalle();
            limpiarcampos();
                     
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarDetalle();
            cargargridDetalle();
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiargridDetalle();
            limpiarcampos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (listadetalleVenta != null)
            {
                agregarventa();
                limpiargridDetalle();
                limpiarcampos();

            }
            else
                MessageBox.Show("No se puede guardar pues el detalle está vacío");


            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
