namespace Proyecto_Final.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public ICollection<Libro> Libros { get; set; } = new List<Libro>();
    }
}
