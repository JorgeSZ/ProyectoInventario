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
            dgvFacturas.Refresh();


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
            dgvFacturas.Refresh();
        }
        

        void obtenerparametros()
        {
            try
            {
                Factura objFactura = new Factura();
                objFactura.numFactura = Convert.ToInt32(txtnumFactura.Text);
                objFactura.idProveedor = Convert.ToInt32(txtidProveedor.Text);
                objFactura.fechaFactura = dtpFecha.Text;
                objFactura.estado = chbEstado.Checked;
                objFactura.tipoPago = Convert.ToInt32(cmbTipoPago.SelectedValue);
                objFactura.subTotal = Convert.ToDouble(txtsubTotal.Text);
                objFactura.IVA = Convert.ToDouble(txtIVA.Text);
                objFactura.descuento = Convert.ToDouble(txtDescuento.Text);
                objFactura.totalFactura = objFactura.funcTotal();
                cmd.Parameters.AddWithValue("numFactura", objFactura.numFactura);
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
                throw;
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

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            crearFactura();
            ActualizarGrid();

        }
    }
}
