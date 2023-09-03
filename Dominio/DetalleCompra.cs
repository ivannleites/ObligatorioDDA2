using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DetalleCompra
    {
        [Key, Column(Order = 0), ForeignKey("Compra")]
        public int IDCompra { get; set; }
        public Compra Compra { get; set; }

        [Key, Column(Order = 1), ForeignKey("Producto")]
        public int IDProducto { get; set; }
        public Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }
    }
}
