using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
    public class Gasto
    {
        public int idGasto { get; set; }
        public int idVendedor { get; set; }
        public string nomVendedor { get; set; }
        public DateTime fecharegistro {get;set;}

        public decimal Monto { get; set; }
        public string Detalle { get; set; }


    }
}
