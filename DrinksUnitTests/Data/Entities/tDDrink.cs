using DrinksLib.Data.Entities;
using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Data.Entities{
    [TestClass]
    public class tDDrink{
        [TestMethod]
        public void DDrink_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An drink with a unique key is constructed.
            DDrink drink = new DDrink { Drink_ID = -1 };

            //Act: the key is retrieved.
            int key = drink.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, drink.Drink_ID);
        }

        [TestMethod]
        public void DDrinkWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An drink with malicious sql members is constructed.
            string malicious = "<div></div>";
            DDrink drink = new DDrink{
                Name = malicious,
                Definition = malicious
            };

            //Act: The friended user is scrubbed.
            drink.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, drink.Name);
            Assert.AreNotEqual(malicious, drink.Definition);
        }

        [TestMethod]
        public void DDrinkWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An drink with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DDrink drink = new DDrink{
                Name = malicious,
                Definition = malicious
            };

            //Act: The friended user is scrubbed.
            drink.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, drink.Name);
            Assert.AreNotEqual(malicious, drink.Definition);
        }
    }
}
