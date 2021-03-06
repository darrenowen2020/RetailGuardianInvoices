﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetailGInvoices.Data;

namespace RetailGInvoices.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public PeriodsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: api/Periods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Period>>> GetPeriod()
        {
            return await _context.Period.OrderBy(o => o.EndDate).ToListAsync();
        }

        
        
        [HttpGet("Company/{companyId}")]
        public async Task<ActionResult<IEnumerable<Period>>> GetPeriodCompany(int companyId)
        {
            return await _context.Period.Where(f => f.CompanyId == companyId).OrderBy(o => o.EndDate).ToListAsync();
        }

        [HttpGet("Company/{companyId}/Year/{year}")]
        public async Task<ActionResult<IEnumerable<Period>>> GetPeriodCompany(int companyId,int year)
        {
            return await _context.Period.Where(f => f.YearNo == year && f.CompanyId == companyId).OrderBy(o => o.EndDate).ToListAsync();
        }

        [HttpGet("Year/{year}")]
        public async Task<ActionResult<IEnumerable<Period>>> GetPeriodYear(int year)
        {
            return await _context.Period.Where(f => f.YearNo == year).OrderBy(o => o.EndDate).ToListAsync();
        }
        // GET: api/Periods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Period>> GetPeriod(int id)
        {
            var period = await _context.Period.FindAsync(id);

            if (period == null)
            {
                return NotFound();
            }

            return period;
        }

        // PUT: api/Periods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriod(int id, Period period)
        {
            if (id != period.PeriodId)
            {
                return BadRequest();
            }

            _context.Entry(period).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodExists(id))
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

        // POST: api/Periods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Period>> PostPeriod(Period period)
        {
            _context.Period.Add(period);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PeriodExists(period.PeriodId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPeriod", new { id = period.PeriodKey }, period);
        }

        // DELETE: api/Periods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Period>> DeletePeriod(int id)
        {
            var period = await _context.Period.FindAsync(id);
            if (period == null)
            {
                return NotFound();
            }

            _context.Period.Remove(period);
            await _context.SaveChangesAsync();

            return period;
        }

        private bool PeriodExists(int id)
        {
            return _context.Period.Any(e => e.PeriodId == id);
        }
    }
}
