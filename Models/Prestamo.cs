using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        [Required]
        public int LibroId { get; set; }
        public Libro Libro { get; set; } = null!;

        [Required]
        public DateTime FechaPrestamo { get; set; }

        [Required]
        public DateTime FechaDevolucion { get; set; }

        [Required, StringLength(20)]
        public string Estado { get; set; } = "Pendiente";

        [StringLength(200)]
        public string? Comentarios { get; set; }

        public DateTime? FechaDevolucionEfectiva { get; set; }
    }
}

