using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Promocion
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(255)]
        public string Condicion { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal Descuento { get; set; }
    }
}
