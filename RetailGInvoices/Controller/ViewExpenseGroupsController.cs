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
    public class ViewExpenseGroupsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ViewExpenseGroupsController(SqlDbContext context)
        {
            _context = context;
        }

        [HttpGet("Company/{companyId}")]
        public async Task<ActionResult<IEnumerable<ViewExpenseGroup>>> GetviewExpenseGroupCompany(int companyId)
        {
            return await _context.ViewExpenseGroup.Where(f => f.ExpenseCompanyId == companyId).OrderBy(x => x.HeadingId).ToListAsync();
        }

        [HttpGet("PayType/{paytype}/{companyId}")]
        public async Task<ActionResult<IEnumerable<ViewExpenseGroup>>> GetviewExpenseGroup(int paytype, int companyId)
        {
            return await _context.ViewExpenseGroup.Where(f => (f.ExpensePaymentId == paytype) && (f.ExpenseCompanyId == companyId)).ToListAsync();
        }
        [HttpGet("PayType/{paytype}")]
        public async Task<ActionResult<IEnumerable<ViewExpenseGroup>>> GetviewInvoiceGroup(int paytype)
        {
            return await _context.ViewExpenseGroup.Where(f => f.ExpensePaymentId == paytype).ToListAsync();
        }

        // GET: api/ViewExpenseGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewExpenseGroup>>> GetViewExpenseGroup()
        {
            return await _context.ViewExpenseGroup.ToListAsync();
        }

        // GET: api/ViewExpenseGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewExpenseGroup>> GetViewExpenseGroup(string id)
        {
            var viewExpenseGroup = await _context.ViewExpenseGroup.FindAsync(id);

            if (viewExpenseGroup == null)
            {
                return NotFound();
            }

            return viewExpenseGroup;
        }

        // PUT: api/ViewExpenseGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViewExpenseGroup(string id, ViewExpenseGroup viewExpenseGroup)
        {
            if (id != viewExpenseGroup.ViewGroupID)
            {
                return BadRequest();
            }

            _context.Entry(viewExpenseGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViewExpenseGroupExists(id))
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

        // POST: api/ViewExpenseGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ViewExpenseGroup>> PostViewExpenseGroup(ViewExpenseGroup viewExpenseGroup)
        {
            _context.ViewExpenseGroup.Add(viewExpenseGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ViewExpenseGroupExists(viewExpenseGroup.ViewGroupID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetViewExpenseGroup", new { id = viewExpenseGroup.ViewGroupID }, viewExpenseGroup);
        }

        // DELETE: api/ViewExpenseGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ViewExpenseGroup>> DeleteViewExpenseGroup(string id)
        {
            var viewExpenseGroup = await _context.ViewExpenseGroup.FindAsync(id);
            if (viewExpenseGroup == null)
            {
                return NotFound();
            }

            _context.ViewExpenseGroup.Remove(viewExpenseGroup);
            await _context.SaveChangesAsync();

            return viewExpenseGroup;
        }

        private bool ViewExpenseGroupExists(string id)
        {
            return _context.ViewExpenseGroup.Any(e => e.ViewGroupID == id);
        }
    }
}
