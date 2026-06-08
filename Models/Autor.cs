using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; } = null!;

        [Required, StringLength(50)]
        public string Apellidos { get; set; } = null!;

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required, StringLength(50)]
        public string Nacionalidad { get; set; } = null!;

        public ICollection<Libro> Libros { get; set; } = new List<Libro>();
    }
}

