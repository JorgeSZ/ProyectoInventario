using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
   public class Factura
    {
        public int numFactura { get; set; }
        public int idProveedor { get; set; }
        public string fechaFactura { get; set; }
        public int tipoPago { get; set; } 
        public Boolean estado { get; set; }
        public double subTotal { get; set; }

        public double IVA { get; set; }
        public double descuento { get; set; }
        public double totalFactura { get; set; }

        
        public double funcTotal()
        {
            double total = subTotal + IVA - descuento;
            return total;
        }

    }

    
}
