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
    public class VatRatesController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public VatRatesController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/VatRates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VatRate>>> GetVatRate()
        {
            return await _context.VatRate.ToListAsync();
        }

        // GET: api/VatRates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VatRate>> GetVatRate(int id)
        {
            var vatRate = await _context.VatRate.FindAsync(id);

            if (vatRate == null)
            {
                return NotFound();
            }

            return vatRate;
        }

        // PUT: api/VatRates/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVatRate(int id, VatRate vatRate)
        {
            if (id != vatRate.Id)
            {
                return BadRequest();
            }

            _context.Entry(vatRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VatRateExists(id))
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

        // POST: api/VatRates
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VatRate>> PostVatRate(VatRate vatRate)
        {
            _context.VatRate.Add(vatRate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVatRate", new { id = vatRate.Id }, vatRate);
        }

        // DELETE: api/VatRates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VatRate>> DeleteVatRate(int id)
        {
            var vatRate = await _context.VatRate.FindAsync(id);
            if (vatRate == null)
            {
                return NotFound();
            }

            _context.VatRate.Remove(vatRate);
            await _context.SaveChangesAsync();

            return vatRate;
        }

        private bool VatRateExists(int id)
        {
            return _context.VatRate.Any(e => e.Id == id);
        }
    }
}
