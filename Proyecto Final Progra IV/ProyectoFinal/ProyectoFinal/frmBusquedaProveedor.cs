﻿using System;
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
    public partial class  frmBusquedaProveedor : Form 
    {
        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;

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

        void cargargrid()
        {
            frmProveedores objfrmproveedores = new frmProveedores();
            objfrmproveedores.actualizargrid();    
            dgvBusqueda.DataSource = frmPrincipal.listaProveedor;
        }

        void filtrargrid()
        {
            frmPrincipal.listaProveedor.Clear();
            dgvBusqueda.DataSource = new List<Proveedor>();
            establecerConexion();
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddWithValue("@busqueda",txtnomProveedor.Text);
            cmd.CommandText = "SP_LookProveedor";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Proveedor objProveedor = new Proveedor();
                objProveedor.idProveedor = dr.GetInt32(0);
                objProveedor.desProveedor = dr.GetString(1);
                objProveedor.codTipoProveedor = dr.GetInt32(2);

                frmPrincipal.listaProveedor.Add(objProveedor);
            }

            dgvBusqueda.DataSource = frmPrincipal.listaProveedor;
            cnx.Close();
            cnx.Dispose();

        }
        public frmBusquedaProveedor()
        {
            InitializeComponent();
            cargargrid();

        }

        private void TxtnomProveedor_TextChanged(object sender, EventArgs e)
        {
            
                //var aux = frmPrincipal.listaProveedor.ToList();


                //List<Proveedor> auxiliar= (from n in aux
                //where n.desProveedor.StartsWith("'" + txtnomProveedor.Text + "'")
                //select new Proveedor()
                //{
                //    idProveedor = n.idProveedor,
                //    desProveedor = n.desProveedor,
                //    codTipoProveedor = n.codTipoProveedor
                //}).ToList();


                //dgvBusqueda.DataSource = auxiliar;

                filtrargrid();
        }

        private void DgvBusqueda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            frmPrincipal.idbusqueda = Convert.ToInt32(dgvBusqueda.CurrentRow.Cells["colidProveedor"].Value.ToString());
            this.Close();
            
        }
    }
}