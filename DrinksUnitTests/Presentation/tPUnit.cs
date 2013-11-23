using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Presentation{
    [TestClass]
    public class tPUnit{
        [TestMethod]
        public void PUnit_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: a unit with null members is constructed.
            PUnit unit = new PUnit { 
                Long_Name = null, 
                Short_Name = null 
            };

            //Act: The unit is formatted.
            unit.Format();

            //Assert: The unit's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, unit.Long_Name);
            Assert.AreEqual(string.Empty, unit.Short_Name);
        }
    }
}
