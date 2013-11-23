using DrinksLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Base{
    [TestClass]
    public class tDrink{
        [TestMethod]
        public void Drink_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A drink pointer is declared.
            Drink drink;

            //Act: The pointer is constructed without parameters.
            drink = new Drink();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, drink);
        }
    }
}
