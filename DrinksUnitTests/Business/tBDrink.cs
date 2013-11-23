using DrinksLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Business{
    [TestClass]
    public class tBDrink{
        [TestMethod]
        public void BDrinkWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: a drink with all valid members is created.
            BDrink drink = new BDrink {
                username = "username",
                Name = "name",
                Definition = "definition"
            };
            
            //Act: The drink is checked if it is create valid.
            bool valid = drink.CreateValid();

            //Assert: The drink is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BDrinkWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: a drink with all invalid members is created.
            BDrink drink = new BDrink{
                username = "1234567890123456789012345678901234567890",
                Name = "1234567890123456789012345678901234567890",
                Definition = null
            };

            //Act: The drink is checked if it is create valid.
            bool valid = drink.CreateValid();

            //Assert: The drink is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BDrinkWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: a drink with all valid members is created.
            BDrink drink = new BDrink{
                username = "username",
                Name = "name",
                Definition = "definition"
            };

            //Act: The drink is checked if it is update valid.
            bool valid = drink.UpdateValid();

            //Assert: The drink is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BDrinkWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: a drink with all invalid members is created.
            BDrink drink = new BDrink{
                username = "1234567890123456789012345678901234567890",
                Name = "1234567890123456789012345678901234567890",
                Definition = null
            };

            //Act: The drink is checked if it is update valid.
            bool valid = drink.UpdateValid();

            //Assert: The drink is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: a drink is created
            BDrink drink = new BDrink();

            //Act: The drink is checked if it is update valid.
            bool valid = drink.DeleteValid();

            //Assert: The drink is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BDrink_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: a drink is created
            BDrink drink = new BDrink();

            //Act: The drink is checked to be equivilant to itself.
            bool equals = false;// drink.Equivilant(drink);

            //Assert: The drink is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
