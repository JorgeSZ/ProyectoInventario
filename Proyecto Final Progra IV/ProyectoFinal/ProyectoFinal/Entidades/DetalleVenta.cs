using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
   public class DetalleVenta
    {
        public int idProducto { get; set; }
        public string desProducto { get; set; }
        public double cantidad { get; set; }

        public double precio { get; set; }

    }
}
