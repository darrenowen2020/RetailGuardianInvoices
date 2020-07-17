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
    public class ViewInvoiceGroupsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ViewInvoiceGroupsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/ViewInvoiceGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewInvoiceGroup>>> GetviewInvoiceGroup()
        {
            return await _context.viewInvoiceGroup.ToListAsync();
        }

        [HttpGet("/PayType/{paytype}")]
        public async Task<ActionResult<IEnumerable<ViewInvoiceGroup>>> GetviewInvoiceGroup(int paytype)
        {
            return await _context.viewInvoiceGroup.Where(f => f.InvoicePaymentId == paytype).ToListAsync();
        }
        // GET: api/ViewInvoiceGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewInvoiceGroup>> GetViewInvoiceGroup(int id)
        {
            var viewInvoiceGroup = await _context.viewInvoiceGroup.FindAsync(id);

            if (viewInvoiceGroup == null)
            {
                return NotFound();
            }

            return viewInvoiceGroup;
        }

        // PUT: api/ViewInvoiceGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViewInvoiceGroup(int id, ViewInvoiceGroup viewInvoiceGroup)
        {
            if (id != viewInvoiceGroup.InvoiceHeadingId)
            {
                return BadRequest();
            }

            _context.Entry(viewInvoiceGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViewInvoiceGroupExists(id))
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

        // POST: api/ViewInvoiceGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ViewInvoiceGroup>> PostViewInvoiceGroup(ViewInvoiceGroup viewInvoiceGroup)
        {
            _context.viewInvoiceGroup.Add(viewInvoiceGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViewInvoiceGroup", new { id = viewInvoiceGroup.InvoiceHeadingId }, viewInvoiceGroup);
        }

        // DELETE: api/ViewInvoiceGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ViewInvoiceGroup>> DeleteViewInvoiceGroup(int id)
        {
            var viewInvoiceGroup = await _context.viewInvoiceGroup.FindAsync(id);
            if (viewInvoiceGroup == null)
            {
                return NotFound();
            }

            _context.viewInvoiceGroup.Remove(viewInvoiceGroup);
            await _context.SaveChangesAsync();

            return viewInvoiceGroup;
        }

        private bool ViewInvoiceGroupExists(int id)
        {
            return _context.viewInvoiceGroup.Any(e => e.InvoiceHeadingId == id);
        }
    }
}
