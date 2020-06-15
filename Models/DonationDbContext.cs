using System;
using Microsoft.EntityFrameworkCore;

namespace BloodDonations.Models
{
    /// <summary>Class <c>DonationDbContext</c> This class inherits from
    /// the DbContext class, it sets a property on the model class</summary>
    public class DonationDbContext: DbContext
    {
        public DonationDbContext(DbContextOptions<DonationDbContext> options):base(options)
        {

        }
        // Create a property for the model class DonationCandidates
        public DbSet<DonationCandidate> DonationCandidates { get; set; }
    }
}
