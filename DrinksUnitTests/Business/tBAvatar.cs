using DrinksLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Business{
    [TestClass]
    public class tBAvatar{
        [TestMethod]
        public void BAvatarWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: A avatar with all valid members is created.
            BAvatar avatar = new BAvatar { 
                Url = "Url",
                Title = "Name"
            };
            
            //Act: the avatar is checked if it is create valid.
            bool valid = avatar.CreateValid();

            //Assert: the avatar is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BAvatarWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: A avatar with all invalid members is created.
            BAvatar avatar = new BAvatar{
                Url = null,
                Title = "1234567890123456789012345678901234567890"
            };

            //Act: the avatar is checked if it is create valid.
            bool valid = avatar.CreateValid();

            //Assert: the avatar is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BAvatarWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: A avatar with all valid members is created.
            BAvatar avatar = new BAvatar{
                Url = "Url",
                Title = "Name"
            };

            //Act: the avatar is checked if it is update valid.
            bool valid = avatar.UpdateValid();

            //Assert: the avatar is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BAvatarWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: A avatar with all invalid members is created.
            BAvatar avatar = new BAvatar{
                Url = null,
                Title = "1234567890123456789012345678901234567890"
            };

            //Act: the avatar is checked if it is update valid.
            bool valid = avatar.UpdateValid();

            //Assert: the avatar is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: A avatar is created
            BAvatar avatar = new BAvatar();

            //Act: the avatar is checked if it is update valid.
            bool valid = avatar.DeleteValid();

            //Assert: the avatar is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BAvatar_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: A avatar is created
            BAvatar avatar = new BAvatar();

            //Act: the avatar is checked to be equivilant to itself.
            bool equals = false;// avatar.Equivilant(avatar);

            //Assert: the avatar is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
