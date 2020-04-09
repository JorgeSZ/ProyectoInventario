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
    public partial class frmFactura : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        public frmFactura()
        {
            InitializeComponent();
            ActualizarGrid();


        }

        #region
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

        void ActualizarGrid()
        {
            frmPrincipal.listaFactura.Clear();
            dgvFacturas.DataSource = new List<Factura>();
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "Select * from Factura";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Factura objFactura = new Factura();
                objFactura.numFactura = dr.GetInt32(0);
                objFactura.idProveedor = dr.GetInt32(1);
                objFactura.fechaFactura = dr.GetDateTime(2).ToString();
                objFactura.tipoPago = dr.GetInt32(3);
                objFactura.estado = dr.GetBoolean(4);
                objFactura.subTotal = Convert.ToDouble(dr.GetDecimal(5));
                objFactura.IVA = Convert.ToDouble(dr.GetDecimal(6));
                objFactura.descuento = Convert.ToDouble(dr.GetDecimal(7));
                objFactura.totalFactura = objFactura.funcTotal();


                frmPrincipal.listaFactura.Add(objFactura);
            }

            dgvFacturas.DataSource = frmPrincipal.listaFactura;
            cnx.Close();
            cnx.Dispose();
        }

        void limpiarControles()
        {
            txtidProveedor.Text = "";
            txtnumFactura.Text = string.Empty;
            cmbTipoPago.SelectedIndex = 0;
            txtsubTotal.Text = "";
            txtIVA.Text = "";
            txtDescuento.Text = "";
            chbEstado.Checked = false;
            //dtpFecha.Value = DateTime.Today;
        }

        void obtenerparametros()
        {
            try
            {
                Factura objFactura = new Factura();
                objFactura.numFactura = Convert.ToInt32(txtnumFactura.Text);
                objFactura.idProveedor = Convert.ToInt32(txtidProveedor.Text);
                objFactura.tipoPago = Convert.ToInt32(cmbTipoPago.SelectedValue);
                objFactura.subTotal = Convert.ToDouble(txtsubTotal.Text);
                objFactura.IVA = Convert.ToDouble(txtIVA.Text);
                objFactura.descuento = Convert.ToDouble(txtDescuento.Text);
                objFactura.totalFactura = objFactura.funcTotal();
                objFactura.fechaFactura = dtpFecha.Text;
                objFactura.estado = chbEstado.Checked;
              
                cmd.Parameters.AddWithValue("@numFactura", objFactura.numFactura);
                cmd.Parameters.AddWithValue("@idproveedor", objFactura.idProveedor);
                cmd.Parameters.AddWithValue("@fechafactura", objFactura.fechaFactura);
                cmd.Parameters.AddWithValue("@estado", objFactura.estado);
                cmd.Parameters.AddWithValue("@tipopago", objFactura.tipoPago);
                cmd.Parameters.AddWithValue("@subtotal", objFactura.subTotal);
                cmd.Parameters.AddWithValue("@iva", objFactura.IVA);
                cmd.Parameters.AddWithValue("@descuento", objFactura.descuento);
                cmd.Parameters.AddWithValue("@total", objFactura.totalFactura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
                
            }


        }

        void crearFactura()
        {
            try
            {
                establecerConexion();
                cmd = new SqlCommand();
                obtenerparametros();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SP_AddFactura";

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                }

                else
                {
                    MessageBox.Show("No se pudo agregar la Factura");
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }


            cnx.Close();
            cnx.Dispose();

        }

        void modificarFactura()
        {

            if (txtnumFactura.Text == string.Empty || txtidProveedor.Text == string.Empty) 
            {
                return;
            }

            establecerConexion();
            cmd = new SqlCommand();
            obtenerparametros();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "SP_UpdFactura";
            int cont = cmd.ExecuteNonQuery();
            if (cont == 1)
            {
                MessageBox.Show("Modificacion exitosa");
            }
            else
            {
                MessageBox.Show("Modificacion Fallida");
            }
            cnx.Close();
            cnx.Dispose();


        }
        void eliminarFactura()
        {

            if (txtnumFactura.Text == string.Empty || txtidProveedor.Text == string.Empty)
            {
                return;
            }

            establecerConexion();
            cmd = new SqlCommand();
            Factura objFactura = new Factura();
            objFactura.numFactura = Convert.ToInt32(txtnumFactura.Text);
            objFactura.idProveedor = Convert.ToInt32(txtidProveedor.Text);
            cmd.Parameters.AddWithValue("@numFactura", objFactura.numFactura);
            cmd.Parameters.AddWithValue("@idproveedor", objFactura.idProveedor);
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.CommandText = "SP_DelFactura";
            int cont = cmd.ExecuteNonQuery();
            if (cont == 1)
            {
                MessageBox.Show("Eliminación exitosa");
            }
            else
            {
                MessageBox.Show("Eliminación Fallida");
            }
            cnx.Close();
            cnx.Dispose();


        }

        #endregion

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet.tipoPago' Puede moverla o quitarla según sea necesario.
            this.tipoPagoTableAdapter.Fill(this.prograIVDataSet.tipoPago);
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.prograIVDataSet.Factura);
            limpiarControles();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            crearFactura();
            ActualizarGrid();
            limpiarControles();
       
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            modificarFactura();
            ActualizarGrid();
            limpiarControles();
        }


        private void DgvFacturas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtnumFactura.Text = dgvFacturas.CurrentRow.Cells["colnumFactura"].Value.ToString();
            txtidProveedor.Text= dgvFacturas.CurrentRow.Cells["colidProveedor"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells["colFechaFactura"].Value.ToString());
            cmbTipoPago.SelectedValue = dgvFacturas.CurrentRow.Cells["colTipoPago"].Value.ToString();
            chbEstado.Checked = Convert.ToBoolean(dgvFacturas.CurrentRow.Cells["colEstado"].Value);
            txtsubTotal.Text = (dgvFacturas.CurrentRow.Cells["colSubTotal"].Value.ToString());
            txtIVA.Text = dgvFacturas.CurrentRow.Cells["colIVA"].Value.ToString();
            txtDescuento.Text= dgvFacturas.CurrentRow.Cells["colDescuento"].Value.ToString();


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarFactura();
            ActualizarGrid();
            limpiarControles();
        }
    }
}
