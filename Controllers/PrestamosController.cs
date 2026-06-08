using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final.Data;
using Proyecto_Final.Models;

namespace Proyecto_Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrestamosController : ControllerBase
    {
        private readonly BibliotecaContext _context;

        public PrestamosController(BibliotecaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prestamo>>> GetPrestamos()
        {
            return await _context.Prestamos
                .Include(p => p.Usuario)
                .Include(p => p.Libro)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Prestamo>> GetPrestamo(int id)
        {
            var prestamo = await _context.Prestamos
                .Include(p => p.Usuario)
                .Include(p => p.Libro)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (prestamo == null) return NotFound();
            return prestamo;
        }

        [HttpPost]
        public async Task<ActionResult<Prestamo>> PostPrestamo(Prestamo prestamo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (prestamo.FechaDevolucion < prestamo.FechaPrestamo)
                return BadRequest("La fecha de devolución no puede ser anterior a la fecha de préstamo.");

            try
            {
                _context.Prestamos.Add(prestamo);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetPrestamo), new { id = prestamo.Id }, prestamo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al crear préstamo", detalle = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrestamo(int id, Prestamo prestamo)
        {
            if (id != prestamo.Id)
                return BadRequest("El ID de la URL no coincide con el del objeto.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (prestamo.FechaDevolucion < prestamo.FechaPrestamo)
                return BadRequest("La fecha de devolución no puede ser anterior a la fecha de préstamo.");

            try
            {
                _context.Entry(prestamo).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al actualizar préstamo", detalle = ex.Message });
            }
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrestamo(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null) return NotFound();
            _context.Prestamos.Remove(prestamo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
