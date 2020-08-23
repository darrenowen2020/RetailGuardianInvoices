using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetailGExpenses.Data;
using RetailGInvoices.Data;

namespace RetailGInvoices.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ExpensesController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/Expenses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> GetExpense()
        {
            return await _context.Expense.ToListAsync();
        }

        // GET: api/Expenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {
            var expense = await _context.Expense.FindAsync(id);

            if (expense == null)
            {
                return NotFound();
            }

            return expense;
        }

        // PUT: api/Expenses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(int id, Expense expense)
        {
            if (id != expense.ID)
            {
                return BadRequest();
            }

            _context.Entry(expense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseExists(id))
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

        // POST: api/Expenses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Expense>> PostExpense(Expense expense)
        {
            _context.Expense.Add(expense);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpense", new { id = expense.ID }, expense);
        }

        // DELETE: api/Expenses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Expense>> DeleteExpense(int id)
        {
            var expense = await _context.Expense.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            _context.Expense.Remove(expense);
            await _context.SaveChangesAsync();

            return expense;
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expense.Any(e => e.ID == id);
        }
    }
}
