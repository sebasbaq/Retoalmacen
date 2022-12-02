using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retoalmacen;
using Retoalmacen.Datos;

namespace Retoalmacen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoTypesController : ControllerBase
    {
        private readonly DatosContext _context;

        public ProductoTypesController(DatosContext context)
        {
            _context = context;
        }

        // GET: api/ProductoTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoType>>> GetProductoTypes()
        {
            return await _context.ProductoTypes.ToListAsync();
        }

        // GET: api/ProductoTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoType>> GetProductoType(int id)
        {
            var productoType = await _context.ProductoTypes.FindAsync(id);

            if (productoType == null)
            {
                return NotFound();
            }

            return productoType;
        }

        // PUT: api/ProductoTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductoType(int id, ProductoType productoType)
        {
            if (id != productoType.Id)
            {
                return BadRequest();
            }

            _context.Entry(productoType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductoTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductoType>> PostProductoType(ProductoType productoType)
        {
            _context.ProductoTypes.Add(productoType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductoType", new { id = productoType.Id }, productoType);
        }

        // DELETE: api/ProductoTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductoType(int id)
        {
            var productoType = await _context.ProductoTypes.FindAsync(id);
            if (productoType == null)
            {
                return NotFound();
            }

            _context.ProductoTypes.Remove(productoType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductoTypeExists(int id)
        {
            return _context.ProductoTypes.Any(e => e.Id == id);
        }
    }
}
