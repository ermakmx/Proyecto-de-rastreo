using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modelos;

namespace bakend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeolugController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GeolugController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Geolug
        [HttpGet]
        public async Task<ActionResult<IEnumerable<geolug>>> Getgeolugares()
        {
            return await _context.geolugares.ToListAsync();
        }

        // GET: api/Geolug/5
        [HttpGet("{id}")]
        public async Task<ActionResult<geolug>> Getgeolug(int id)
        {
            var geolug = await _context.geolugares.FindAsync(id);

            if (geolug == null)
            {
                return NotFound();
            }

            return geolug;
        }

        // PUT: api/Geolug/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putgeolug(int id, geolug geolug)
        {
            if (id != geolug.GLId)
            {
                return BadRequest();
            }

            _context.Entry(geolug).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!geolugExists(id))
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

        // POST: api/Geolug
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<geolug>> Postgeolug(geolug geolug)
        {
            _context.geolugares.Add(geolug);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getgeolug", new { id = geolug.GLId }, geolug);
        }

        // DELETE: api/Geolug/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletegeolug(int id)
        {
            var geolug = await _context.geolugares.FindAsync(id);
            if (geolug == null)
            {
                return NotFound();
            }

            _context.geolugares.Remove(geolug);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool geolugExists(int id)
        {
            return _context.geolugares.Any(e => e.GLId == id);
        }
    }
}
