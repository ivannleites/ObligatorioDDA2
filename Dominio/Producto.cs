using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }

        [Required]
        [Range(0, 9999999999.99)]
        public decimal Precio { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [ForeignKey("Marca")]
        public int IDMarca { get; set; }
        public Marca Marca { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        public int IDCategoria { get; set; }
        public Categoria Categoria { get; set; }

        [Required]
        [ForeignKey("Color")]
        public int IDColor { get; set; }
        public Color Color { get; set; }
    }
}
