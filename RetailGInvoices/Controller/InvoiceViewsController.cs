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
    public class InvoiceViewsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public InvoiceViewsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceViews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceView>>> GetInvoiceView()
        {
            return await _context.InvoiceView.OrderByDescending(x => x.InvoiceEditDate).ToListAsync();
            
        }

        // GET: api/InvoiceViews/Year
        [HttpGet("Year/{year}/{companyId}")]
        public async Task<ActionResult<IEnumerable<InvoiceView>>> GetInvoiceViewYearCompany(int year, int companyId)
        {
            return await _context.InvoiceView.Where(y => (y.PeriodYearNo == year) && y.InvoiceCompanyId == companyId).OrderByDescending(x => x.InvoiceEditDate).ToListAsync();
        }

        // GET: api/InvoiceViews/Year
        [HttpGet("Year/{year}")]
        public async Task<ActionResult<IEnumerable<InvoiceView>>> GetInvoiceViewYear(int year)
        {
            return await _context.InvoiceView.Where(y => y.PeriodYearNo == year).OrderByDescending(x => x.InvoiceEditDate).ToListAsync();
        }

        // GET: api/InvoiceViews/Paid
        [HttpGet("Paid/{paid}")]
        public async Task<ActionResult<IEnumerable<InvoiceView>>> GetInvoiceViewPaid(bool paid)
        {
            return await _context.InvoiceView.Where(y => y.InvoicePaid == paid && y.InvoicePaymentReconcile == true).ToListAsync();
        }
        // GET: api/InvoiceViews/Paid/Period
        [HttpGet("Paid/{paid}/{period}/{companyId}")]
        public async Task<ActionResult<IEnumerable<InvoiceView>>> GetInvoiceViewPaidPeriod(bool paid, string period, int companyId)
        {
            return await _context.InvoiceView.Where(y => (y.InvoicePaid == paid && y.InvoicePaymentReconcile == true) && (y.InvoicePeriod == period) && (y.InvoiceCompanyId == companyId)).ToListAsync();
        }

        // GET: api/InvoiceViews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceView>> GetInvoiceView(int id)
        {
            var invoiceView = await _context.InvoiceView.FindAsync(id);
            if (invoiceView == null)
            {
                return NotFound();
            }

            return invoiceView;
        }
        
        // PUT: api/InvoiceViews/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceView(int id, InvoiceView invoiceView)
        {
            if (id != invoiceView.InvoiceId)
            {
                return BadRequest();
            }

            _context.Entry(invoiceView).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceViewExists(id))
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

        // POST: api/InvoiceViews
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InvoiceView>> PostInvoiceView(InvoiceView invoiceView)
        {
            _context.InvoiceView.Add(invoiceView);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoiceView", new { id = invoiceView.InvoiceId }, invoiceView);
        }

        // DELETE: api/InvoiceViews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoiceView>> DeleteInvoiceView(int id)
        {
            var invoiceView = await _context.InvoiceView.FindAsync(id);
            if (invoiceView == null)
            {
                return NotFound();
            }

            _context.InvoiceView.Remove(invoiceView);
            await _context.SaveChangesAsync();

            return invoiceView;
        }

        private bool InvoiceViewExists(int id)
        {
            return _context.InvoiceView.Any(e => e.InvoiceId == id);
        }
    }
}
