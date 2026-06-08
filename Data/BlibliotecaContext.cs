
using Microsoft.EntityFrameworkCore;
using Proyecto_Final.Models;

namespace Proyecto_Final.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Autores
            modelBuilder.Entity<Autor>().HasData(
                new Autor { Id = 1, Nombre = "Gabriel", Apellidos = "García Márquez", FechaNacimiento = new DateTime(1927, 3, 6), Nacionalidad = "Colombiana" },
                new Autor { Id = 2, Nombre = "Mario", Apellidos = "Vargas Llosa", FechaNacimiento = new DateTime(1936, 3, 28), Nacionalidad = "Peruana" },
                new Autor { Id = 3, Nombre = "Isabel", Apellidos = "Allende", FechaNacimiento = new DateTime(1942, 8, 2), Nacionalidad = "Chilena" },
                new Autor { Id = 4, Nombre = "Jorge Luis", Apellidos = "Borges", FechaNacimiento = new DateTime(1899, 8, 24), Nacionalidad = "Argentina" },
                new Autor { Id = 5, Nombre = "Carlos", Apellidos = "Fuentes", FechaNacimiento = new DateTime(1928, 11, 11), Nacionalidad = "Mexicana" },
                new Autor { Id = 6, Nombre = "Octavio", Apellidos = "Paz", FechaNacimiento = new DateTime(1914, 3, 31), Nacionalidad = "Mexicana" },
                new Autor { Id = 7, Nombre = "Laura", Apellidos = "Esquivel", FechaNacimiento = new DateTime(1950, 9, 30), Nacionalidad = "Mexicana" },
                new Autor { Id = 8, Nombre = "Pablo", Apellidos = "Neruda", FechaNacimiento = new DateTime(1904, 7, 12), Nacionalidad = "Chilena" },
                new Autor { Id = 9, Nombre = "Miguel", Apellidos = "de Cervantes", FechaNacimiento = new DateTime(1547, 9, 29), Nacionalidad = "Española" },
                new Autor { Id = 10, Nombre = "Federico", Apellidos = "García Lorca", FechaNacimiento = new DateTime(1898, 6, 5), Nacionalidad = "Española" }
            );



            // Géneros
            modelBuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Nombre = "Novela" },
                new Genero { Id = 2, Nombre = "Poesía" },
                new Genero { Id = 3, Nombre = "Ensayo" },
                new Genero { Id = 4, Nombre = "Cuento" },
                new Genero { Id = 5, Nombre = "Teatro" },
                new Genero { Id = 6, Nombre = "Historia" },
                new Genero { Id = 7, Nombre = "Biografía" },
                new Genero { Id = 8, Nombre = "Fantasía" },
                new Genero { Id = 9, Nombre = "Ciencia ficción" },
                new Genero { Id = 10, Nombre = "Misterio" }
            );


            // Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Ana", Apellidos = "Ramírez", Cedula = "10101010", Email = "ana@test.com", Telefono = "8888-1111", Direccion = "San José", FechaNacimiento = new DateTime(1990, 5, 12) },
                new Usuario { Id = 2, Nombre = "Luis", Apellidos = "Gómez", Cedula = "20202020", Email = "luis@test.com", Telefono = "8888-2222", Direccion = "Alajuela", FechaNacimiento = new DateTime(1985, 7, 23) },
                new Usuario { Id = 3, Nombre = "María", Apellidos = "Fernández", Cedula = "30303030", Email = "maria@test.com", Telefono = "8888-3333", Direccion = "Heredia", FechaNacimiento = new DateTime(1992, 1, 15) },
                new Usuario { Id = 4, Nombre = "Pedro", Apellidos = "Solís", Cedula = "40404040", Email = "pedro@test.com", Telefono = "8888-4444", Direccion = "Cartago", FechaNacimiento = new DateTime(1988, 11, 5) },
                new Usuario { Id = 5, Nombre = "Sofía", Apellidos = "Jiménez", Cedula = "50505050", Email = "sofia@test.com", Telefono = "8888-5555", Direccion = "Puntarenas", FechaNacimiento = new DateTime(1995, 9, 9) },
                new Usuario { Id = 6, Nombre = "Carlos", Apellidos = "Vega", Cedula = "60606060", Email = "carlos@test.com", Telefono = "8888-6666", Direccion = "Limón", FechaNacimiento = new DateTime(1983, 4, 18) },
                new Usuario { Id = 7, Nombre = "Elena", Apellidos = "Castro", Cedula = "70707070", Email = "elena@test.com", Telefono = "8888-7777", Direccion = "San Carlos", FechaNacimiento = new DateTime(1991, 12, 25) },
                new Usuario { Id = 8, Nombre = "José", Apellidos = "Martínez", Cedula = "80808080", Email = "jose@test.com", Telefono = "8888-8888", Direccion = "Liberia", FechaNacimiento = new DateTime(1987, 6, 30) },
                new Usuario { Id = 9, Nombre = "Lucía", Apellidos = "Rojas", Cedula = "90909090", Email = "lucia@test.com", Telefono = "8888-9999", Direccion = "Nicoya", FechaNacimiento = new DateTime(1993, 3, 14) },
                new Usuario { Id = 10, Nombre = "Miguel", Apellidos = "Hernández", Cedula = "10111212", Email = "miguel@test.com", Telefono = "8888-0000", Direccion = "Quepos", FechaNacimiento = new DateTime(1989, 8, 20) }
            );


            // Libros
            modelBuilder.Entity<Libro>().HasData(
                new Libro { Id = 1, Titulo = "Cien años de soledad", NumeroPaginas = 417, FechaPublicacion = new DateTime(1967, 5, 30), AutorId = 1, GeneroId = 1 },
                new Libro { Id = 2, Titulo = "La ciudad y los perros", NumeroPaginas = 350, FechaPublicacion = new DateTime(1963, 1, 1), AutorId = 2, GeneroId = 1 },
                new Libro { Id = 3, Titulo = "La casa de los espíritus", NumeroPaginas = 490, FechaPublicacion = new DateTime(1982, 1, 1), AutorId = 3, GeneroId = 1 },
                new Libro { Id = 4, Titulo = "El Aleph", NumeroPaginas = 180, FechaPublicacion = new DateTime(1949, 1, 1), AutorId = 4, GeneroId = 4 },
                new Libro { Id = 5, Titulo = "La región más transparente", NumeroPaginas = 300, FechaPublicacion = new DateTime(1958, 1, 1), AutorId = 5, GeneroId = 1 },
                new Libro { Id = 6, Titulo = "El laberinto de la soledad", NumeroPaginas = 250, FechaPublicacion = new DateTime(1950, 1, 1), AutorId = 6, GeneroId = 3 },
                new Libro { Id = 7, Titulo = "Como agua para chocolate", NumeroPaginas = 250, FechaPublicacion = new DateTime(1989, 1, 1), AutorId = 7, GeneroId = 1 },
                new Libro { Id = 8, Titulo = "Veinte poemas de amor", NumeroPaginas = 100, FechaPublicacion = new DateTime(1924, 1, 1), AutorId = 8, GeneroId = 2 },
                new Libro { Id = 9, Titulo = "Don Quijote de la Mancha", NumeroPaginas = 863, FechaPublicacion = new DateTime(1605, 1, 1), AutorId = 9, GeneroId = 1 },
                new Libro { Id = 10, Titulo = "Romancero gitano", NumeroPaginas = 150, FechaPublicacion = new DateTime(1928, 1, 1), AutorId = 10, GeneroId = 2 }
            );


            // Prestamos
            modelBuilder.Entity<Prestamo>().HasData(
                new Prestamo { Id = 1, UsuarioId = 1, LibroId = 1, FechaPrestamo = new DateTime(2025, 1, 10), FechaDevolucion = new DateTime(2025, 1, 20), Estado = "Pendiente", Comentarios = "Primer préstamo" },
                new Prestamo { Id = 2, UsuarioId = 2, LibroId = 2, FechaPrestamo = new DateTime(2025, 1, 11), FechaDevolucion = new DateTime(2025, 1, 21), Estado = "Pendiente" },
                new Prestamo { Id = 3, UsuarioId = 3, LibroId = 3, FechaPrestamo = new DateTime(2025, 1, 12), FechaDevolucion = new DateTime(2025, 1, 22), Estado = "Pendiente" },
                new Prestamo { Id = 4, UsuarioId = 4, LibroId = 4, FechaPrestamo = new DateTime(2025, 1, 13), FechaDevolucion = new DateTime(2025, 1, 23), Estado = "Pendiente" },
                new Prestamo { Id = 5, UsuarioId = 5, LibroId = 5, FechaPrestamo = new DateTime(2025, 1, 14), FechaDevolucion = new DateTime(2025, 1, 24), Estado = "Pendiente" },
                new Prestamo { Id = 6, UsuarioId = 6, LibroId = 6, FechaPrestamo = new DateTime(2025, 1, 15), FechaDevolucion = new DateTime(2025, 1, 25), Estado = "Pendiente" },
                new Prestamo { Id = 7, UsuarioId = 7, LibroId = 7, FechaPrestamo = new DateTime(2025, 1, 16), FechaDevolucion = new DateTime(2025, 1, 26), Estado = "Pendiente" },
                new Prestamo { Id = 8, UsuarioId = 8, LibroId = 8, FechaPrestamo = new DateTime(2025, 1, 17), FechaDevolucion = new DateTime(2025, 1, 27), Estado = "Pendiente" },
                new Prestamo { Id = 9, UsuarioId = 9, LibroId = 9, FechaPrestamo = new DateTime(2025, 1, 18), FechaDevolucion = new DateTime(2025, 1, 28), Estado = "Pendiente" },
                new Prestamo { Id = 10, UsuarioId = 10, LibroId = 10, FechaPrestamo = new DateTime(2025, 1, 19), FechaDevolucion = new DateTime(2025, 1, 29), Estado = "Pendiente" }
            );

        }
    }
}
