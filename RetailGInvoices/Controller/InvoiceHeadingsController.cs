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
    public class InvoiceHeadingsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public InvoiceHeadingsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceHeadings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceHeading>>> GetInvoiceHeading()
        {
            return await _context.InvoiceHeading.OrderBy(f => f.Description).ToListAsync();
        }

        // GET: api/InvoiceHeadings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceHeading>> GetInvoiceHeading(int id)
        {
            var invoiceHeading = await _context.InvoiceHeading.FindAsync(id);

            if (invoiceHeading == null)
            {
                return NotFound();
            }

            return invoiceHeading;
        }

        // PUT: api/InvoiceHeadings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceHeading(int id, InvoiceHeading invoiceHeading)
        {
            if (id != invoiceHeading.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoiceHeading).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceHeadingExists(id))
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

        // POST: api/InvoiceHeadings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvoiceHeading>> PostInvoiceHeading(InvoiceHeading invoiceHeading)
        {
            _context.InvoiceHeading.Add(invoiceHeading);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoiceHeading", new { id = invoiceHeading.Id }, invoiceHeading);
        }

        // DELETE: api/InvoiceHeadings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoiceHeading>> DeleteInvoiceHeading(int id)
        {
            var invoiceHeading = await _context.InvoiceHeading.FindAsync(id);
            if (invoiceHeading == null)
            {
                return NotFound();
            }

            _context.InvoiceHeading.Remove(invoiceHeading);
            await _context.SaveChangesAsync();

            return invoiceHeading;
        }

        private bool InvoiceHeadingExists(int id)
        {
            return _context.InvoiceHeading.Any(e => e.Id == id);
        }
    }
}
