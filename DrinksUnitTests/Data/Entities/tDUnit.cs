using DrinksLib.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Data.Entities{
    [TestClass]
    public class tDUnit{
        [TestMethod]
        public void DUnit_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An unit with a unique key is constructed.
            DUnit unit = new DUnit { Unit_ID = -1 };

            //Act: the key is retrieved.
            int key = unit.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, unit.Unit_ID);
        }

        [TestMethod]
        public void DUnitWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An unit with malicious sql members is constructed.
            string malicious = "<div>";
            DUnit unit = new DUnit{
                Long_Name = malicious
            };

            //Act: The friended user is scrubbed.
            unit.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, unit.Long_Name);
        }

        [TestMethod]
        public void DUnitWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An unit with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DUnit unit = new DUnit{
                Long_Name = malicious
            };

            //Act: The friended user is scrubbed.
            unit.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, unit.Long_Name);
        }
    }
}
