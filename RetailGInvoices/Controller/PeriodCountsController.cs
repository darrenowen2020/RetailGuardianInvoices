using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetailGInvoices.Data;

namespace RetailGInvoices.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodCountsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public PeriodCountsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/PeriodCounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeriodCount>>> GetPeriodCounts()
        {
            return await _context.PeriodCounts.ToListAsync();
        }

        // GET: api/PeriodCounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PeriodCount>> GetPeriodCount(int id)
        {
            var periodCount = await _context.PeriodCounts.FindAsync(id);

            if (periodCount == null)
            {
                return NotFound();
            }

            return periodCount;
        }

        // PUT: api/PeriodCounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriodCount(int id, PeriodCount periodCount)
        {
            if (id != periodCount.CompanyId)
            {
                return BadRequest();
            }

            _context.Entry(periodCount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodCountExists(id))
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

        // POST: api/PeriodCounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PeriodCount>> PostPeriodCount(PeriodCount periodCount)
        {
            _context.PeriodCounts.Add(periodCount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeriodCount", new { id = periodCount.CompanyId }, periodCount);
        }

        // DELETE: api/PeriodCounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PeriodCount>> DeletePeriodCount(int id)
        {
            var periodCount = await _context.PeriodCounts.FindAsync(id);
            if (periodCount == null)
            {
                return NotFound();
            }

            _context.PeriodCounts.Remove(periodCount);
            await _context.SaveChangesAsync();

            return periodCount;
        }

        private bool PeriodCountExists(int id)
        {
            return _context.PeriodCounts.Any(e => e.CompanyId == id);
        }
    }
}
