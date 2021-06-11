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
    public class EntSalController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntSalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EntSal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ent_sal>>> GetEntradasSalidas()
        {
            return await _context.EntradasSalidas.ToListAsync();
        }

        // GET: api/EntSal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ent_sal>> Getent_sal(int id)
        {
            var ent_sal = await _context.EntradasSalidas.FindAsync(id);

            if (ent_sal == null)
            {
                return NotFound();
            }

            return ent_sal;
        }

        // PUT: api/EntSal/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putent_sal(int id, ent_sal ent_sal)
        {
            if (id != ent_sal.EntSalId)
            {
                return BadRequest();
            }

            _context.Entry(ent_sal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ent_salExists(id))
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

        // POST: api/EntSal
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ent_sal>> Postent_sal(ent_sal ent_sal)
        {
            _context.EntradasSalidas.Add(ent_sal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getent_sal", new { id = ent_sal.EntSalId }, ent_sal);
        }

        // DELETE: api/EntSal/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteent_sal(int id)
        {
            var ent_sal = await _context.EntradasSalidas.FindAsync(id);
            if (ent_sal == null)
            {
                return NotFound();
            }

            _context.EntradasSalidas.Remove(ent_sal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ent_salExists(int id)
        {
            return _context.EntradasSalidas.Any(e => e.EntSalId == id);
        }
    }
}
