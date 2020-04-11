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
        public static int idbusqueda;
        public frmPrincipal()
        {
            InitializeComponent();
            listaProveedor = new List<Proveedor>();
            listaProducto = new List<Producto>();
            listaFactura = new List<Factura>();
            
            
            
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "frmProveedores")
                    {
                        return;

                    }
                }

                frmProveedores objfrmproveedores = new frmProveedores();
                objfrmproveedores.MdiParent = this;
                objfrmproveedores.Dock = DockStyle.Fill;
                objfrmproveedores.Show();
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
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frmProducto")
                {
                    return;

                }
            }
            frmProducto objfrmproducto = new frmProducto();
            objfrmproducto.MdiParent = this;
            objfrmproducto.Dock = DockStyle.Fill;
            objfrmproducto.Show();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frmFactura")
                {
                    return;

                }
            }
            frmFactura objfrmFactura = new frmFactura();
            objfrmFactura.MdiParent = this;
            objfrmFactura.Dock = DockStyle.Fill;
            objfrmFactura.Show();
        }

        private void TsPersonas_Click(object sender, EventArgs e)
        {
            Personas objpersonas = new Personas();
            objpersonas.MdiParent = this;
            objpersonas.Dock = DockStyle.Fill;
            objpersonas.Show();
        }

        private void TsbUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios objusuarios = new Usuarios();

        }
    }
}
