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
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "frmProductos")
                    {
                        return;

                    }
                }

                frmProveedores objfrmproveedores = new frmProveedores();
                objfrmproveedores.MdiParent = this;
                objfrmproveedores.Show();
            }
        }
    }
}
