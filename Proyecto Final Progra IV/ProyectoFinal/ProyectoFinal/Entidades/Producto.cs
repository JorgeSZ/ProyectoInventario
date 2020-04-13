using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string desProducto { get; set; }

        public int codTipoProducto { get; set; }

        public decimal costo { get; set; }

        public decimal porcUtilidad { get; set; }

        public decimal codProveedor { get; set; }

        public double Precio(double pcosto, double putilidad)
        {
            double vprecio = pcosto + pcosto * (putilidad / 100);
                return vprecio;
        }
    }

  
}
