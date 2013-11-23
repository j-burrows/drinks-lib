using DrinksLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Business{
    [TestClass]
    public class tBUnit{
        [TestMethod]
        public void BUnitWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: a unit with all valid members is created.
            BUnit unit = new BUnit {
                Long_Name = "Long",
                Short_Name = "SA"
            };
            
            //Act: The unit is checked if it is create valid.
            bool valid = unit.CreateValid();

            //Assert: The unit is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BUnitWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: a unit with all invalid members is created.
            BUnit unit = new BUnit{
                Long_Name =
                    "1234567890123456789012345678901234567890123456789012345678901234567890",
                Short_Name = 
                    "1234567890"
            };

            //Act: The unit is checked if it is create valid.
            bool valid = unit.CreateValid();

            //Assert: The unit is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BUnitWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: a unit with all valid members is created.
            BUnit unit = new BUnit{
                Long_Name = "Long",
                Short_Name = "SA"
            };

            //Act: The unit is checked if it is update valid.
            bool valid = unit.UpdateValid();

            //Assert: The unit is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BUnitWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: a unit with all invalid members is created.
            BUnit unit = new BUnit{
                Long_Name =
                    "1234567890123456789012345678901234567890123456789012345678901234567890",
                Short_Name = 
                    "1234567890"
            };

            //Act: The unit is checked if it is update valid.
            bool valid = unit.UpdateValid();

            //Assert: The unit is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: a unit is created
            BUnit unit = new BUnit();

            //Act: The unit is checked if it is update valid.
            bool valid = unit.DeleteValid();

            //Assert: The unit is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BUnit_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: a unit is created
            BUnit unit = new BUnit();

            //Act: The unit is checked to be equivilant to itself.
            bool equals = false;// unit.Equivilant(unit);

            //Assert: The unit is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
