using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        public int ID { get; set; }
        public int IDUsuario { get; set; }
        public int IDPromocion { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
