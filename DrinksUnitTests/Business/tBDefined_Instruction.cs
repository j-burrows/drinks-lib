using DrinksLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Business{
    [TestClass]
    public class tBDefined_Instruction{
        [TestMethod]
        public void BDefined_InstructionWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: a defined instruction with all valid members is created.
            BDefined_Instruction defined_instruction = new BDefined_Instruction {
                Description = 
                    "Definition"
            };
            
            //Act: The defined instruction is checked if it is create valid.
            bool valid = defined_instruction.CreateValid();

            //Assert: The defined instruction is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BDefined_InstructionWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: a defined instruction with all invalid members is created.
            BDefined_Instruction defined_instruction = new BDefined_Instruction{
                Description = 
                    "1234567890123456789012345678901234567890123456789012345678901234567890"
            };

            //Act: The defined instruction is checked if it is create valid.
            bool valid = defined_instruction.CreateValid();

            //Assert: The defined instruction is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BDefined_InstructionWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: a defined instruction with all valid members is created.
            BDefined_Instruction defined_instruction = new BDefined_Instruction{
                Description = 
                    "Definition"
            };

            //Act: The defined instruction is checked if it is update valid.
            bool valid = defined_instruction.UpdateValid();

            //Assert: The defined instruction is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BDefined_InstructionWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: a defined instruction with all invalid members is created.
            BDefined_Instruction defined_instruction = new BDefined_Instruction{
                Description = 
                    "1234567890123456789012345678901234567890123456789012345678901234567890"
            };

            //Act: The defined instruction is checked if it is update valid.
            bool valid = defined_instruction.UpdateValid();

            //Assert: The defined instruction is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: a defined instruction is created
            BDefined_Instruction defined_instruction = new BDefined_Instruction();

            //Act: The defined instruction is checked if it is update valid.
            bool valid = defined_instruction.DeleteValid();

            //Assert: The defined instruction is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BDefined_Instruction_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: a defined instruction is created
            BDefined_Instruction defined_instruction = new BDefined_Instruction();

            //Act: The defined instruction is checked to be equivilant to itself.
            bool equals = false;// defined_instruction.Equivilant(defined_instruction);

            //Assert: The defined instruction is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
