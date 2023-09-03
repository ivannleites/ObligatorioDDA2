using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Compra
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int IDUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        [ForeignKey("Promocion")]
        public int IDPromocion { get; set; }
        public Promocion Promocion { get; set; }


        [Required]
        public DateTime FechaCompra { get; set; }
    }
}
