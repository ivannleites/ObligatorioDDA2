using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required]
        [MaxLength(255)]
        public string Contrasena { get; set; }

        [Required]
        [MaxLength(50)]
        public string Rol { get; set; }

        [MaxLength(255)]
        public string DireccionEntrega { get; set; }
    }
}