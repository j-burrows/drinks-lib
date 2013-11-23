using DrinksLib.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Base{
    [TestClass]
    public class tRating{
        [TestMethod]
        public void Rating_WhenParameterlesslyConstructed_IsInstantiated(){
            //Arrange: A rating pointer is declared.
            Rating rating;

            //Act: The pointer is constructed without parameters.
            rating = new Rating();

            //Assert: The pointer is no longer null.
            Assert.AreNotEqual(null, rating);
        }
    }
}
