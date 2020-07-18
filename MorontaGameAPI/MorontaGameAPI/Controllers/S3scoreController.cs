using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MorontaGameAPI.Models;

namespace MorontaGameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class S3scoreController : ControllerBase
    {
        private readonly isc210_201920203Context _context;

        public S3scoreController(isc210_201920203Context context)
        {
            _context = context;
        }

        // GET: api/S3scoreController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.S3scoreController>>> GetS3scoreController()
        {
            return await _context.S3scoreController.ToListAsync();
        }

        // GET: api/S3scoreController/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.S3scoreController>> GetS3scoreController(int id)
        {
            var s3scoreController = await _context.S3scoreController.FindAsync(id);

            if (s3scoreController == null)
            {
                return NotFound();
            }

            return s3scoreController;
        }

        // PUT: api/S3scoreController/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutS3scoreController(int id, Models.S3scoreController s3scoreController)
        {
            if (id != s3scoreController.Id)
            {
                return BadRequest();
            }

            _context.Entry(s3scoreController).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!S3scoreControllerExists(id))
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

        // POST: api/S3scoreController
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Models.S3scoreController>> PostS3scoreController(Models.S3scoreController s3scoreController)
        {
            _context.S3scoreController.Add(s3scoreController);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetS3scoreController", new { id = s3scoreController.Id }, s3scoreController);
        }

        // DELETE: api/S3scoreController/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Models.S3scoreController>> DeleteS3scoreController(int id)
        {
            var s3scoreController = await _context.S3scoreController.FindAsync(id);
            if (s3scoreController == null)
            {
                return NotFound();
            }

            _context.S3scoreController.Remove(s3scoreController);
            await _context.SaveChangesAsync();

            return s3scoreController;
        }

        private bool S3scoreControllerExists(int id)
        {
            return _context.S3scoreController.Any(e => e.Id == id);
        }
    }
}
