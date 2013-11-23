using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Presentation{
    [TestClass]
    public class tPDefined_Instruction{
        [TestMethod]
        public void PDefined_Instruction_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: a defined instruction with null members is constructed.
            PDefined_Instruction defined_instruction = new PDefined_Instruction {
                Description = null
            };

            //Act: The defined instruction is formatted.
            defined_instruction.Format();

            //Assert: The blocked user's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, defined_instruction.Description);
        }
    }
}
