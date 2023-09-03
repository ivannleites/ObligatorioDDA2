using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Color
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreColor { get; set; }
    }
}
