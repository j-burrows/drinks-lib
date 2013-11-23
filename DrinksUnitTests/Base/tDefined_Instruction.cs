using DrinksLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Base{
    [TestClass]
    public class tDefined_Instruction{
        [TestMethod]
        public void Defined_Instruction_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A defined instruction pointer is declared.
            Defined_Instruction defined_instruction;

            //Act: The pointer is constructed without parameters.
            defined_instruction = new Defined_Instruction();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, defined_instruction);
        }
    }
}
