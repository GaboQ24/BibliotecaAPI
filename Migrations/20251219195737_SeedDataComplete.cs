using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto_Final.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "Apellidos", "FechaNacimiento", "Nacionalidad", "Nombre" },
                values: new object[,]
                {
                    { 1, "García Márquez", new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombiana", "Gabriel" },
                    { 2, "Vargas Llosa", new DateTime(1936, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peruana", "Mario" },
                    { 3, "Allende", new DateTime(1942, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilena", "Isabel" },
                    { 4, "Borges", new DateTime(1899, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argentina", "Jorge Luis" },
                    { 5, "Fuentes", new DateTime(1928, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexicana", "Carlos" },
                    { 6, "Paz", new DateTime(1914, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexicana", "Octavio" },
                    { 7, "Esquivel", new DateTime(1950, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexicana", "Laura" },
                    { 8, "Neruda", new DateTime(1904, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilena", "Pablo" },
                    { 9, "de Cervantes", new DateTime(1547, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Española", "Miguel" },
                    { 10, "García Lorca", new DateTime(1898, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Española", "Federico" }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Novela" },
                    { 2, "Poesía" },
                    { 3, "Ensayo" },
                    { 4, "Cuento" },
                    { 5, "Teatro" },
                    { 6, "Historia" },
                    { 7, "Biografía" },
                    { 8, "Fantasía" },
                    { 9, "Ciencia ficción" },
                    { 10, "Misterio" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellidos", "Cedula", "Direccion", "Email", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Ramírez", "10101010", "San José", "ana@test.com", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "8888-1111" },
                    { 2, "Gómez", "20202020", "Alajuela", "luis@test.com", new DateTime(1985, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis", "8888-2222" },
                    { 3, "Fernández", "30303030", "Heredia", "maria@test.com", new DateTime(1992, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "María", "8888-3333" },
                    { 4, "Solís", "40404040", "Cartago", "pedro@test.com", new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "8888-4444" },
                    { 5, "Jiménez", "50505050", "Puntarenas", "sofia@test.com", new DateTime(1995, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "8888-5555" },
                    { 6, "Vega", "60606060", "Limón", "carlos@test.com", new DateTime(1983, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "8888-6666" },
                    { 7, "Castro", "70707070", "San Carlos", "elena@test.com", new DateTime(1991, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elena", "8888-7777" },
                    { 8, "Martínez", "80808080", "Liberia", "jose@test.com", new DateTime(1987, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "José", "8888-8888" },
                    { 9, "Rojas", "90909090", "Nicoya", "lucia@test.com", new DateTime(1993, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucía", "8888-9999" },
                    { 10, "Hernández", "10111212", "Quepos", "miguel@test.com", new DateTime(1989, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "8888-0000" }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "Id", "AutorId", "FechaPublicacion", "GeneroId", "NumeroPaginas", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1967, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 417, "Cien años de soledad" },
                    { 2, 2, new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 350, "La ciudad y los perros" },
                    { 3, 3, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 490, "La casa de los espíritus" },
                    { 4, 4, new DateTime(1949, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 180, "El Aleph" },
                    { 5, 5, new DateTime(1958, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 300, "La región más transparente" },
                    { 6, 6, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 250, "El laberinto de la soledad" },
                    { 7, 7, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 250, "Como agua para chocolate" },
                    { 8, 8, new DateTime(1924, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "Veinte poemas de amor" },
                    { 9, 9, new DateTime(1605, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 863, "Don Quijote de la Mancha" },
                    { 10, 10, new DateTime(1928, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 150, "Romancero gitano" }
                });

            migrationBuilder.InsertData(
                table: "Prestamos",
                columns: new[] { "Id", "Comentarios", "Estado", "FechaDevolucion", "FechaDevolucionEfectiva", "FechaPrestamo", "LibroId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Primer préstamo", "Pendiente", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, null, "Pendiente", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, null, "Pendiente", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, null, "Pendiente", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 5, null, "Pendiente", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 6, null, "Pendiente", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { 7, null, "Pendiente", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 7 },
                    { 8, null, "Pendiente", new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8 },
                    { 9, null, "Pendiente", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9 },
                    { 10, null, "Pendiente", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");
        }
    }
}
