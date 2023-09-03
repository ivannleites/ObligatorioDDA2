using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Promocion
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public decimal Descuento { get; set; }
    }
}
