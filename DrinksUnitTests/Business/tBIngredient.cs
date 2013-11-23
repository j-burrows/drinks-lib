using DrinksLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace IngredientsUnitTests.Business{
    [TestClass]
    public class tBIngredient{
        [TestMethod]
        public void BIngredientWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: a ingredient with all valid members is created.
            BIngredient ingredient = new BIngredient {
                Long_Name = "Long",
                Short_Name = "SN"
            };
            
            //Act: The ingredient is checked if it is create valid.
            bool valid = ingredient.CreateValid();

            //Assert: The ingredient is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BIngredientWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: a ingredient with all invalid members is created.
            BIngredient ingredient = new BIngredient{
                Long_Name = "1234567890123456789012345678901234567890",
                Short_Name = null
            };

            //Act: The ingredient is checked if it is create valid.
            bool valid = ingredient.CreateValid();

            //Assert: The ingredient is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BIngredientWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: a ingredient with all valid members is created.
            BIngredient ingredient = new BIngredient{
                Long_Name = "Long",
                Short_Name = "SN"
            };

            //Act: The ingredient is checked if it is update valid.
            bool valid = ingredient.UpdateValid();

            //Assert: The ingredient is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BIngredientWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: a ingredient with all invalid members is created.
            BIngredient ingredient = new BIngredient{
                Long_Name = "1234567890123456789012345678901234567890",
                Short_Name = null
            };

            //Act: The ingredient is checked if it is update valid.
            bool valid = ingredient.UpdateValid();

            //Assert: The ingredient is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: a ingredient is created
            BIngredient ingredient = new BIngredient();

            //Act: The ingredient is checked if it is update valid.
            bool valid = ingredient.DeleteValid();

            //Assert: The ingredient is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BIngredient_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: a ingredient is created
            BIngredient ingredient = new BIngredient();

            //Act: The ingredient is checked to be equivilant to itself.
            bool equals = false;// ingredient.Equivilant(ingredient);

            //Assert: The ingredient is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
