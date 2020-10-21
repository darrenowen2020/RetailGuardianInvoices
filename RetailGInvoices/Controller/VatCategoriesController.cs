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
    public class VatCategoriesController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public VatCategoriesController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/VatCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VatCategory>>> GetVatCategory()
        {
            return await _context.VatCategory.ToListAsync();
        }

        // GET: api/VatCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VatCategory>> GetVatCategory(int id)
        {
            var vatCategory = await _context.VatCategory.FindAsync(id);

            if (vatCategory == null)
            {
                return NotFound();
            }

            return vatCategory;
        }

        // PUT: api/VatCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVatCategory(int id, VatCategory vatCategory)
        {
            if (id != vatCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(vatCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VatCategoryExists(id))
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

        // POST: api/VatCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VatCategory>> PostVatCategory(VatCategory vatCategory)
        {
            _context.VatCategory.Add(vatCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVatCategory", new { id = vatCategory.Id }, vatCategory);
        }

        // DELETE: api/VatCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VatCategory>> DeleteVatCategory(int id)
        {
            var vatCategory = await _context.VatCategory.FindAsync(id);
            if (vatCategory == null)
            {
                return NotFound();
            }

            _context.VatCategory.Remove(vatCategory);
            await _context.SaveChangesAsync();

            return vatCategory;
        }

        private bool VatCategoryExists(int id)
        {
            return _context.VatCategory.Any(e => e.Id == id);
        }
    }
}
