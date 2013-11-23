using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Presentation{
    [TestClass]
    public class tPInstruction{
        [TestMethod]
        public void PInstruction_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: a rating with null members is constructed.
            PInstruction instruction = new PInstruction{
                Description = null
            };

            //Act: The instruction is formatted.
            instruction.Format();

            //Assert: The instruction's null members have been replaced with empty members.
            Assert.AreEqual(string.Empty, instruction.Description);
        }
    }
}
