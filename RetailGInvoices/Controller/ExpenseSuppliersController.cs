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
    public class ExpenseSuppliersController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ExpenseSuppliersController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/ExpenseSuppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseSupplier>>> GetExpenseSupplier()
        {
            return await _context.ExpenseSupplier.OrderBy(f => f.Name).ToListAsync();
        }

        // GET: api/ExpenseSuppliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseSupplier>> GetExpenseSupplier(int id)
        {
            var expenseSupplier = await _context.ExpenseSupplier.FindAsync(id);

            if (expenseSupplier == null)
            {
                return NotFound();
            }

            return expenseSupplier;
        }

        // PUT: api/ExpenseSuppliers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseSupplier(int id, ExpenseSupplier expenseSupplier)
        {
            if (id != expenseSupplier.Id)
            {
                return BadRequest();
            }

            _context.Entry(expenseSupplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseSupplierExists(id))
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

        // POST: api/ExpenseSuppliers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ExpenseSupplier>> PostExpenseSupplier(ExpenseSupplier expenseSupplier)
        {
            _context.ExpenseSupplier.Add(expenseSupplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpenseSupplier", new { id = expenseSupplier.Id }, expenseSupplier);
        }

        // DELETE: api/ExpenseSuppliers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExpenseSupplier>> DeleteExpenseSupplier(int id)
        {
            var expenseSupplier = await _context.ExpenseSupplier.FindAsync(id);
            if (expenseSupplier == null)
            {
                return NotFound();
            }

            _context.ExpenseSupplier.Remove(expenseSupplier);
            await _context.SaveChangesAsync();

            return expenseSupplier;
        }

        private bool ExpenseSupplierExists(int id)
        {
            return _context.ExpenseSupplier.Any(e => e.Id == id);
        }
    }
}
