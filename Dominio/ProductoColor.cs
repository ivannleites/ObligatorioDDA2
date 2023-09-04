using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio.Domain
{
    public class ProductoColor
    {
        [Key]
        [Column(Order = 1)]
        public int ProductoID { get; set; }

        [ForeignKey("ProductoID")]
        public Producto Producto { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ColorID { get; set; }

        [ForeignKey("ColorID")]
        public Color Color { get; set; }
    }
}
