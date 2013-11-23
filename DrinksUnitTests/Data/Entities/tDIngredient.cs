using DrinksLib.Data.Entities;
using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace IngredientsUnitTests.Data.Entities{
    [TestClass]
    public class tDIngredient{
        [TestMethod]
        public void DIngredient_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An ingredient with a unique key is constructed.
            DIngredient ingredient = new DIngredient { Ingredient_ID = -1 };

            //Act: the key is retrieved.
            int key = ingredient.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, ingredient.Ingredient_ID);
        }

        [TestMethod]
        public void DIngredientWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An ingredient with malicious sql members is constructed.
            string malicious = "<div></div>";
            DIngredient ingredient = new DIngredient{
                Long_Name = malicious
            };

            //Act: The friended user is scrubbed.
            ingredient.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, ingredient.Long_Name);
        }

        [TestMethod]
        public void DIngredientWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An ingredient with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DIngredient ingredient = new DIngredient{
                Long_Name = malicious
            };

            //Act: The friended user is scrubbed.
            ingredient.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, ingredient.Long_Name);
        }
    }
}
