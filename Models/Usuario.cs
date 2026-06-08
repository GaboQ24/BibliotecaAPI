using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; } = null!;

        [Required, StringLength(50)]
        public string Apellidos { get; set; } = null!;

        [Required, StringLength(20)]
        public string Cedula { get; set; } = null!;

        [Required, EmailAddress]
        public string Email { get; set; } = null!;

        [Required, Phone]
        public string Telefono { get; set; } = null!;

        [Required, StringLength(100)]
        public string Direccion { get; set; } = null!;

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}

