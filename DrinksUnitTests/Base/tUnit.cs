using DrinksLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Base{
    [TestClass]
    public class tUnit{
        [TestMethod]
        public void Unit_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A unit pointer is declared.
            Unit unit;

            //Act: The pointer is constructed without parameters.
            unit = new Unit();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, unit);
        }
    }
}
