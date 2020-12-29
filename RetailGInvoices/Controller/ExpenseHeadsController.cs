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
    public class ExpenseHeadsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ExpenseHeadsController(SqlDbContext context)
        {
            _context = context;
        }
        
        // GET: api/ExpenseHeads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseHead>>> GetExpenseHead()
        {
            return await _context.ExpenseHead.ToListAsync();
        }

        // GET: api/ExpenseHeads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseHead>> GetExpenseHead(int id)
        {
            var expenseHead = await _context.ExpenseHead.FindAsync(id);

            if (expenseHead == null)
            {
                return NotFound();
            }

            return expenseHead;
        }

        // PUT: api/ExpenseHeads/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseHead(int id, ExpenseHead expenseHead)
        {
            if (id != expenseHead.Id)
            {
                return BadRequest();
            }

            _context.Entry(expenseHead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseHeadExists(id))
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

        // POST: api/ExpenseHeads
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ExpenseHead>> PostExpenseHead(ExpenseHead expenseHead)
        {
            _context.ExpenseHead.Add(expenseHead);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return CreatedAtAction("GetExpenseHead", new { id = expenseHead.Id }, expenseHead);
        }

        // DELETE: api/ExpenseHeads/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExpenseHead>> DeleteExpenseHead(int id)
        {
            var expenseHead = await _context.ExpenseHead.FindAsync(id);
            if (expenseHead == null)
            {
                return NotFound();
            }

            _context.ExpenseHead.Remove(expenseHead);
            await _context.SaveChangesAsync();

            return expenseHead;
        }

        private bool ExpenseHeadExists(int id)
        {
            return _context.ExpenseHead.Any(e => e.Id == id);
        }
    }
}
