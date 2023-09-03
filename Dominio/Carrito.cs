using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Carrito
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int IDUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        [ForeignKey("Producto")]
        public int IDProducto { get; set; }
        public Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }
    }
}
