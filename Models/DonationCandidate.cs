using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonations.Models
{
    /// <summary>Class <c>DonationCandidate</c> The model for the candidate donating blood </summary>
    public class DonationCandidate
    {
        // The primary key attribute which is also id of the candidate donating blood
        [Key]
        public int id { get; set; }


        // The fullName of the candidate donating blood
        [Column(TypeName = "nvarchar(100)")]
        public string fullName { get; set; }


        // The mobile number of the candidate donating blood
        [Column(TypeName = "nvarchar(16)")]
        public string mobile { get; set; }


        // The email address of the candidate donating blood
        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }


        // The age of the candidate donating blood
        public int age { get; set; }


        // The bloodGroup of the candidate donating blood
        [Column(TypeName = "nvarchar(3)")]
        public string bloodGroup { get; set; }


        // The address of the candidate donating blood
        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }







    }
}
