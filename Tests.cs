using System;
using Xunit;
using BloodDonations.Models;

namespace BloodDonations
{
    /// <summary>Class <c>Test_All_Fields_Of_DonationCandidate_Model</c>
    /// The class for testing the data going into the database</summary>
    public class Test_All_Fields_Of_DonationCandidate_Model
    {

        [Fact]
        public void Test_DonationCandidateModel()
        {

            // Instance of the DonationCandidate model to be tested
            DonationCandidate candidate = new DonationCandidate();

            // Assigning values to various fields of the model
            candidate.id = 1;
            candidate.fullName = "Emmanuel";
            candidate.mobile = "+36708383747";
            candidate.age = 25;
            candidate.bloodGroup = "O-";
            candidate.address = "Szanto";

            // Assert to check for equality between assigned values and those store in the database
            Assert.Equal(1, candidate.id);
            Assert.Equal("Emmanuel", candidate.fullName);
            Assert.Equal("+36708383747", candidate.mobile);
            Assert.Equal(25, candidate.age);
            Assert.Equal("O-", candidate.bloodGroup);
            Assert.Equal("Szanto", candidate.address);

        }

    }
}
