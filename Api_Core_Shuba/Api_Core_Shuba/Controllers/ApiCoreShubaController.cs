using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_Core_Shuba.Models;

namespace Api_Core_Shuba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCoreShubaController : ControllerBase
    {
        private readonly Freshers_Training2022Context _context;

        public ApiCoreShubaController(Freshers_Training2022Context context)
        {
            _context = context;
        }

        // GET: api/ApiCoreShuba
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiCoreShuba>>> GetApiCoreShuba()
        {
            return await _context.ApiCoreShuba.ToListAsync();
        }

        // GET: api/ApiCoreShuba/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiCoreShuba>> GetApiCoreShuba(int id)
        {
            var apiCoreShuba = await _context.ApiCoreShuba.FindAsync(id);

            if (apiCoreShuba == null)
            {
                return NotFound();
            }

            return apiCoreShuba;
        }

        // PUT: api/ApiCoreShuba/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApiCoreShuba(int id, ApiCoreShuba apiCoreShuba)
        {
            if (id != apiCoreShuba.Id)
            {
                return BadRequest();
            }

            _context.Entry(apiCoreShuba).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApiCoreShubaExists(id))
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

        // POST: api/ApiCoreShuba
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ApiCoreShuba>> PostApiCoreShuba(ApiCoreShuba apiCoreShuba)
        {
            _context.ApiCoreShuba.Add(apiCoreShuba);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApiCoreShuba", new { id = apiCoreShuba.Id }, apiCoreShuba);
        }

        // DELETE: api/ApiCoreShuba/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiCoreShuba>> DeleteApiCoreShuba(int id)
        {
            var apiCoreShuba = await _context.ApiCoreShuba.FindAsync(id);
            if (apiCoreShuba == null)
            {
                return NotFound();
            }

            _context.ApiCoreShuba.Remove(apiCoreShuba);
            await _context.SaveChangesAsync();

            return apiCoreShuba;
        }

        private bool ApiCoreShubaExists(int id)
        {
            return _context.ApiCoreShuba.Any(e => e.Id == id);
        }
    }
}
