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
    public class ExpenseLinesController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public ExpenseLinesController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/ExpenseLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseLine>>> GetExpenseLine()
        {
            return await _context.ExpenseLine.ToListAsync();
        }

        [HttpGet("ExpenseHead/{Id}")]
        public async Task<ActionResult<List<ExpenseLine>>> GetExpenseHeadLines(int Id)
        {
            List<ExpenseLine> expenseLines;

            try
            {
                expenseLines = await _context.ExpenseLine.Where(f => f.ExpenseId == Id).OrderBy(g => g.Line).ToListAsync();
                return expenseLines;
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET: api/ExpenseLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseLine>> GetExpenseLine(int id)
        {
            var expenseLine = await _context.ExpenseLine.FindAsync(id);

            if (expenseLine == null)
            {
                return NotFound();
            }

            return expenseLine;
        }

        // PUT: api/ExpenseLines/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseLine(int id, ExpenseLine expenseLine)
        {
            if (id != expenseLine.Id)
            {
                return BadRequest();
            }

            _context.Entry(expenseLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseLineExists(id))
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

        // POST: api/ExpenseLines
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ExpenseLine>> PostExpenseLine(ExpenseLine expenseLine)
        {
            _context.ExpenseLine.Add(expenseLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpenseLine", new { id = expenseLine.Id }, expenseLine);
        }

        // DELETE: api/ExpenseLines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExpenseLine>> DeleteExpenseLine(int id)
        {
            var expenseLine = await _context.ExpenseLine.FindAsync(id);
            if (expenseLine == null)
            {
                return NotFound();
            }

            _context.ExpenseLine.Remove(expenseLine);
            await _context.SaveChangesAsync();

            return expenseLine;
        }

        [HttpDelete("ExpenseHead/{Id}")]
        public async Task<ActionResult> DeleteExpenseHeadLines(int expenseHeadId)
        {
            try
            {
                ExpenseLine[] expenseLines = await _context.ExpenseLine.Where(f => f.ExpenseId == expenseHeadId).ToArrayAsync();
                _context.ExpenseLine.RemoveRange(expenseLines);

                await _context.SaveChangesAsync();

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        private bool ExpenseLineExists(int id)
        {
            return _context.ExpenseLine.Any(e => e.Id == id);
        }
    }
}
