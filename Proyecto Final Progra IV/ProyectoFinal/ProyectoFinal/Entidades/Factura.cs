using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
   public class Factura
    {
        int numFactura { get; set; }
        int idProveedor { get; set; }
        string fechaFactura { get; set; }
        int tipoPago { get; set; } 
        string fechaVencimiento { get; set; }
         double subTotal { get; set; }

        double IVA { get; set; }
        double descuento { get; set; }
        double totalFactura { get; set; }

        
        public double funcTotal(double sub, double iva, double desc)
        {
            return sub + iva + desc;
        }

    }

    
}
