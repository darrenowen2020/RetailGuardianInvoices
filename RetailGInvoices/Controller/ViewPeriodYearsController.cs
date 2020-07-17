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
    public class ViewPeriodYearsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ViewPeriodYearsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/ViewPeriodYears
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewPeriodYears>>> GetViewPeriodYears()
        {
            return await _context.ViewPeriodYears.OrderByDescending(x => x.YearNo).ToListAsync();
        }

        // GET: api/ViewPeriodYears/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewPeriodYears>> GetViewPeriodYears(int id)
        {
            var viewPeriodYears = await _context.ViewPeriodYears.FindAsync(id);

            if (viewPeriodYears == null)
            {
                return NotFound();
            }

            return viewPeriodYears;
        }

        // PUT: api/ViewPeriodYears/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViewPeriodYears(int id, ViewPeriodYears viewPeriodYears)
        {
            if (id != viewPeriodYears.YearNo)
            {
                return BadRequest();
            }

            _context.Entry(viewPeriodYears).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViewPeriodYearsExists(id))
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

        // POST: api/ViewPeriodYears
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ViewPeriodYears>> PostViewPeriodYears(ViewPeriodYears viewPeriodYears)
        {
            _context.ViewPeriodYears.Add(viewPeriodYears);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViewPeriodYears", new { id = viewPeriodYears.YearNo }, viewPeriodYears);
        }

        // DELETE: api/ViewPeriodYears/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ViewPeriodYears>> DeleteViewPeriodYears(int id)
        {
            var viewPeriodYears = await _context.ViewPeriodYears.FindAsync(id);
            if (viewPeriodYears == null)
            {
                return NotFound();
            }

            _context.ViewPeriodYears.Remove(viewPeriodYears);
            await _context.SaveChangesAsync();

            return viewPeriodYears;
        }

        private bool ViewPeriodYearsExists(int id)
        {
            return _context.ViewPeriodYears.Any(e => e.YearNo == id);
        }
    }
}
