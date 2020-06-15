using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodDonations.Models;

namespace BloodDonations.Controllers
{

    /// <summary>Class <c>DonationCandidateController</c> controller with all the API
    /// endpoints.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DonationCandidateController : ControllerBase
    {
        private readonly DonationDbContext _context;

        public DonationCandidateController(DonationDbContext context)
        {
            _context = context;
        }

        // GET: api/DonationCandidate
        /// <summary> method <c> GetDonationCandidates </c> handles fetching all the data in the database</summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonationCandidate>>> GetDonationCandidates()
        {
            return await _context.DonationCandidates.ToListAsync();
        }

        // GET: api/DonationCandidate/5
        /// <summary> method <c> GetDonationCandidate</c> handles fetching a specific data in the database</summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<DonationCandidate>> GetDonationCandidate(int id)
        {
            var donationCandidate = await _context.DonationCandidates.FindAsync(id);

            if (donationCandidate == null)
            {
                return NotFound();
            }

            return donationCandidate;
        }

        // PUT: api/DonationCandidate/5
        /// <summary> method <c> PutDonationCandidate</c> handles updating or editing information of
        /// a specific instance in the database</summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonationCandidate(int id, DonationCandidate donationCandidate)
        {
            donationCandidate.id = id;

            _context.Entry(donationCandidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonationCandidateExists(id))
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

        // POST: api/DonationCandidate
        /// <summary> method <c> PostDonationCandidate</c> handles creating a new instance in the database</summary>
        [HttpPost]
        public async Task<ActionResult<DonationCandidate>> PostDonationCandidate(DonationCandidate donationCandidate)
        {
            _context.DonationCandidates.Add(donationCandidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonationCandidate", new { id = donationCandidate.id }, donationCandidate);
        }

        // DELETE: api/DonationCandidate/5
        /// <summary> method <c> PostDonationCandidate</c> handles deleting an instance in the database</summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<DonationCandidate>> DeleteDonationCandidate(int id)
        {
            var donationCandidate = await _context.DonationCandidates.FindAsync(id);
            if (donationCandidate == null)
            {
                return NotFound();
            }

            _context.DonationCandidates.Remove(donationCandidate);
            await _context.SaveChangesAsync();

            return donationCandidate;
        }

        private bool DonationCandidateExists(int id)
        {
            return _context.DonationCandidates.Any(e => e.id == id);
        }
    }
}
