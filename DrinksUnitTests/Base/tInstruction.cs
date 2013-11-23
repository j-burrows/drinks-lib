using DrinksLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Base{
    [TestClass]
    public class tInstruction{
        [TestMethod]
        public void Instruction_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: An intruction pointer is declared.
            Instruction intruction;

            //Act: The pointer is constructed without parameters.
            intruction = new Instruction();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, intruction);
        }
    }
}
