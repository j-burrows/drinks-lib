using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Presentation{
    [TestClass]
    public class tPAvatar{
        [TestMethod]
        public void PAvatar_WithNullMembers_WhenFormatted_HasEmptyMembers(){
            //Arrange: an avatar with null members is constructed.
            PAvatar avatar = new PAvatar { 
                Title = null, 
                Url = null 
            };

            //Act: The blocked user is formatted.
            avatar.Format();

            //Assert: The blocked user's null members are replaced with empty members.
            Assert.AreEqual(string.Empty, avatar.Title);
            Assert.AreEqual(string.Empty, avatar.Url);
        }
    }
}
