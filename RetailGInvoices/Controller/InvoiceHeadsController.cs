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
    public class InvoiceHeadsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public InvoiceHeadsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceHeads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceHead>>> GetInvoiceHead()
        {
            return await _context.InvoiceHead.ToListAsync();
        }

        // GET: api/InvoiceHeads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceHead>> GetInvoiceHead(int id)
        {
            var invoiceHead = await _context.InvoiceHead.FindAsync(id);

            if (invoiceHead == null)
            {
                return NotFound();
            }

            return invoiceHead;
        }

        // PUT: api/InvoiceHeads/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceHead(int id, InvoiceHead invoiceHead)
        {
            if (id != invoiceHead.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoiceHead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceHeadExists(id))
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

        // POST: api/InvoiceHeads
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvoiceHead>> PostInvoiceHead(InvoiceHead invoiceHead)
        {
            _context.InvoiceHead.Add(invoiceHead);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoiceHead", new { id = invoiceHead.Id }, invoiceHead);
        }

        // DELETE: api/InvoiceHeads/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoiceHead>> DeleteInvoiceHead(int id)
        {
            var invoiceHead = await _context.InvoiceHead.FindAsync(id);
            if (invoiceHead == null)
            {
                return NotFound();
            }

            _context.InvoiceHead.Remove(invoiceHead);
            await _context.SaveChangesAsync();

            return invoiceHead;
        }

        private bool InvoiceHeadExists(int id)
        {
            return _context.InvoiceHead.Any(e => e.Id == id);
        }
    }
}
