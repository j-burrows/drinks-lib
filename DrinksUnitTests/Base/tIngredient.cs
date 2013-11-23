using DrinksLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Base{
    [TestClass]
    public class tIngredient{
        [TestMethod]
        public void Ingredient_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: An ingredient pointer is declared.
            Ingredient ingredient;

            //Act: The pointer is constructed without parameters.
            ingredient = new Ingredient();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, ingredient);
        }
    }
}
