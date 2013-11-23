using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Presentation{
    [TestClass]
    public class tPRating{
        [TestMethod]
        public void PRating_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: a rating with null members is constructed.
            PRating rating = new PRating{
                Reasons = null
            };

            //Act: The rating is formatted.
            rating.Format();

            //Assert: The rating's null members have been replaced with empty members.
            Assert.AreEqual(string.Empty, rating.Reasons);
        }
    }
}
