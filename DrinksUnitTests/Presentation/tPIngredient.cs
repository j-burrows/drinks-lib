using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Presentation{
    [TestClass]
    public class tPIngredient{
        [TestMethod]
        public void PIngredient_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: an ingredient with null members is constructed.
            PIngredient ingredient = new PIngredient{
                Long_Name = null,
                Short_Name = null
            };

            //Act: The ingredient is formatted.
            ingredient.Format();

            //Assert: The ingredient's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, ingredient.Long_Name);
            Assert.AreEqual(string.Empty, ingredient.Short_Name);
        }
    }
}
