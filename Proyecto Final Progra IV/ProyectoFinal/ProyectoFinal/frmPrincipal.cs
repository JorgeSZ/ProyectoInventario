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

namespace ProyectoFinal
{
    public partial class frmPrincipal : Form
    {
        
        public static List<Proveedor> listaProveedor;
        public static List<Producto> listaProducto;
        public static List<Factura> listaFactura;
        public static List<Inventario> listaInventario;
        


        public static int idbusqueda;
        public frmPrincipal()
        {
            InitializeComponent();
            listaProveedor = new List<Proveedor>();
            listaProducto = new List<Producto>();
            listaFactura = new List<Factura>();
            listaInventario = new List<Inventario>();
            




        }

        Boolean PestannaAbierta(string frm)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name ==frm)
                {
                    return  true ;
                    break;   
                }
            }
            return false;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            frmProveedores objfrmproveedores = new frmProveedores();
            if (PestannaAbierta(objfrmproveedores.Name)!=true)
            {
                
                objfrmproveedores.MdiParent = this;
                objfrmproveedores.Dock = DockStyle.Fill;
                objfrmproveedores.Show();
            }

            else
            {
                MessageBox.Show("Este Formulario ya se encuentra Abierto");
            }
 
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.TipoProveedor' Puede moverla o quitarla según sea necesario.
            //this.tipoProveedorTableAdapter.Fill(this.prograIVDataSet1.TipoProveedor);
            // TODO: esta línea de código carga datos en la tabla 'prograIVDataSet1.TipoProducto' Puede moverla o quitarla según sea necesario.
            //this.tipoProductoTableAdapter.Fill(this.prograIVDataSet1.TipoProducto);

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            frmProducto objfrmproducto = new frmProducto();
            if (PestannaAbierta(objfrmproducto.Name) != true)
            {
                objfrmproducto.MdiParent = this;
                objfrmproducto.Dock = DockStyle.Fill;
                objfrmproducto.Show();

            }
            else
            {
                MessageBox.Show("Este Formulario ya se encuentra Abierto");
            }


        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            frmFactura objfrmFactura = new frmFactura();
            if (PestannaAbierta(objfrmFactura.Name) != true)
            {
                objfrmFactura.MdiParent = this;
                objfrmFactura.Dock = DockStyle.Fill;
                objfrmFactura.Show();

            }
            else
            {
                MessageBox.Show("Este Formulario ya se encuentra Abierto");
            }
            
           
        }

        private void TsPersonas_Click(object sender, EventArgs e)
        {
            Personas objpersonas = new Personas();
            if (PestannaAbierta(objpersonas.Name) != true)
            {
                objpersonas.MdiParent = this;
                objpersonas.Dock = DockStyle.Fill;
                objpersonas.Show();

            }
            else
            {
                MessageBox.Show("Este Formulario ya se encuentra Abierto");
            }
            
            
        }

        private void TsbUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios objusuarios = new Usuarios();
            if (PestannaAbierta(objusuarios.Name) != true)
            {
                objusuarios.MdiParent = this;
                objusuarios.Dock = DockStyle.Fill;
                objusuarios.Show();


            }
            else
            {
                MessageBox.Show("Este Formulario ya se encuentra Abierto");
            }

        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmInventario objinventario = new frmInventario();
            if (PestannaAbierta(objinventario.Name) != true)
            {
                objinventario.MdiParent = this;
                objinventario.Dock = DockStyle.Fill;
                objinventario.Show();

            }
            else
            {
                MessageBox.Show("Este Formulario ya se encuentra Abierto");
            }
            
        }

        private void TsbVenta_Click(object sender, EventArgs e)
        {
            frmVenta objVenta = new frmVenta();
            if (PestannaAbierta(objVenta.Name) != true)
            {
                objVenta.MdiParent = this;
                objVenta.Dock = DockStyle.Fill;
                objVenta.Show();

            }
            else
            {
                MessageBox.Show("Este Formulario ya se encuentra Abierto");
            }

        
        

        }
    }
}
