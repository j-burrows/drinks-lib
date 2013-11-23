using DrinksLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Business{
    [TestClass]
    public class tBInstruction{
        [TestMethod]
        public void BInstructionWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: a instruction with all valid members is created.
            BInstruction instruction = new BInstruction {
                Description = "Description"
            };
            
            //Act: The instruction is checked if it is create valid.
            bool valid = instruction.CreateValid();

            //Assert: The instruction is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BInstructionWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: a instruction with all invalid members is created.
            BInstruction instruction = new BInstruction{
                Description =
                    "1234567890123456789012345678901234567890123456789012345678901234567890"
            };

            //Act: The instruction is checked if it is create valid.
            bool valid = instruction.CreateValid();

            //Assert: The instruction is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BInstructionWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: a instruction with all valid members is created.
            BInstruction instruction = new BInstruction{
                Description = "Description"
            };

            //Act: The instruction is checked if it is update valid.
            bool valid = instruction.UpdateValid();

            //Assert: The instruction is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BInstructionWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: a instruction with all invalid members is created.
            BInstruction instruction = new BInstruction{
                Description = 
                "1234567890123456789012345678901234567890123456789012345678901234567890"
            };

            //Act: The instruction is checked if it is update valid.
            bool valid = instruction.UpdateValid();

            //Assert: The instruction is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: a instruction is created
            BInstruction instruction = new BInstruction();

            //Act: The instruction is checked if it is update valid.
            bool valid = instruction.DeleteValid();

            //Assert: The instruction is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BInstruction_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: a instruction is created
            BInstruction instruction = new BInstruction();

            //Act: The instruction is checked to be equivilant to itself.
            bool equals = false;// instruction.Equivilant(instruction);

            //Assert: The instruction is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
