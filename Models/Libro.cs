using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Titulo { get; set; } = null!;

        [Range(1, 2000)]
        public int NumeroPaginas { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; }

        [Required]
        public int AutorId { get; set; }
        public Autor Autor { get; set; } = null!;

        [Required]
        public int GeneroId { get; set; }
        public Genero Genero { get; set; } = null!;

        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}

