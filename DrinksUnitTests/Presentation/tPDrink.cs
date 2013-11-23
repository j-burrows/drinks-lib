using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Presentation{
    [TestClass]
    public class tPDrink{
        [TestMethod]
        public void PDrink_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: a defined instruction with null members is constructed.
            PDrink drink = new PDrink{
                username = null,
                Name = null,
                Definition = null
            };

            //Act: The drink is formatted.
            drink.Format();

            //Assert: The drink's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, drink.username);
            Assert.AreEqual(string.Empty, drink.Name);
            Assert.AreEqual(string.Empty, drink.Definition);
        }
    }
}
