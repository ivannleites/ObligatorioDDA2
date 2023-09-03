using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Categoria
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreCategoria { get; set; }
    }
}
