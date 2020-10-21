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
    public class ExpenseViewsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ExpenseViewsController(SqlDbContext context)
        {
            _context = context;
        }

        [HttpGet("Year/{year}/{companyId}")]
        public async Task<ActionResult<IEnumerable<ExpenseView>>> GetExpenseViewYearCompany(int year, int companyId)
        {
            return await _context.ExpenseView.Where(y => (y.PeriodYearNo == year) && y.ExpenseCompanyId == companyId).OrderByDescending(x => x.ExpenseEditDate).ToListAsync();
        }

        // GET: api/ExpenseViews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseView>>> GetExpenseView()
        {
            return await _context.ExpenseView.ToListAsync();
        }

        // GET: api/ExpenseViews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseView>> GetExpenseView(int id)
        {
            var expenseView = await _context.ExpenseView.FindAsync(id);

            if (expenseView == null)
            {
                return NotFound();
            }

            return expenseView;
        }

        // PUT: api/ExpenseViews/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseView(int id, ExpenseView expenseView)
        {
            if (id != expenseView.ExpenseId)
            {
                return BadRequest();
            }

            _context.Entry(expenseView).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseViewExists(id))
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

        // POST: api/ExpenseViews
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ExpenseView>> PostExpenseView(ExpenseView expenseView)
        {
            _context.ExpenseView.Add(expenseView);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpenseView", new { id = expenseView.ExpenseId }, expenseView);
        }

        // DELETE: api/ExpenseViews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExpenseView>> DeleteExpenseView(int id)
        {
            var expenseView = await _context.ExpenseView.FindAsync(id);
            if (expenseView == null)
            {
                return NotFound();
            }

            _context.ExpenseView.Remove(expenseView);
            await _context.SaveChangesAsync();

            return expenseView;
        }

        private bool ExpenseViewExists(int id)
        {
            return _context.ExpenseView.Any(e => e.ExpenseId == id);
        }
    }
}
