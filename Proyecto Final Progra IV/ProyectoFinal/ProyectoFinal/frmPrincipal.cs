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
        public frmPrincipal()
        {
            InitializeComponent();
            listaProveedor = new List<Proveedor>();
            
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
    }
}
