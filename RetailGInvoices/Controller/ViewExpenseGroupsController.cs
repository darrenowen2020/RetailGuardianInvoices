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
            return await _context.ViewExpenseGroup.Where(f => f.ExpenseCompanyId == companyId).OrderBy(x => x.ExpensePaymentId).ToListAsync();
        }

        [HttpGet("PayType/{paytype}/{companyId}")]
        public async Task<ActionResult<IEnumerable<ViewExpenseGroup>>> GetviewExpenseGroup(int paytype, int companyId)
        {
            List<ViewExpenseGroup> vg = await _context.ViewExpenseGroup.Where(f => (f.ExpensePaymentId == paytype) && (f.ExpenseCompanyId == companyId)).ToListAsync();
            return vg;
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

      
    }
}
