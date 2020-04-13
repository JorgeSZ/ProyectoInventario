using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
    public class Inventario
    { 

        public int idProducto { get; set; }
        public string desProducto { get; set; }
        public double cantProducto { get; set; }
        public DateTime fechaModificacion { get; set; }

        
    }
}
