using DrinksLib.Data.Entities;
using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Data.Entities{
    [TestClass]
    public class tDRating{
        [TestMethod]
        public void DRating_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An instruction with a unique key is constructed.
            DRating instruction = new DRating { Rating_ID = -1 };

            //Act: the key is retrieved.
            int key = instruction.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, instruction.Rating_ID);
        }

        [TestMethod]
        public void DRatingWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An instruction with malicious sql members is constructed.
            string malicious = "<div></div>";
            DRating instruction = new DRating{
                Reasons = malicious
            };

            //Act: The friended user is scrubbed.
            instruction.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, instruction.Reasons);
        }

        [TestMethod]
        public void DRatingWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An instruction with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DRating instruction = new DRating{
                Reasons = malicious
            };

            //Act: The friended user is scrubbed.
            instruction.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, instruction.Reasons);
        }
    }
}
