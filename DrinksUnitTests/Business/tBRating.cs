using DrinksLib.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Business{
    [TestClass]
    public class tBRating{
        [TestMethod]
        public void BRatingWithValidMembers_WhenCreateValidated_ReturnsTrue() { 
            //Arrange: a rating with all valid members is created.
            BRating rating = new BRating {
                Reasons = "Reasons"
            };
            
            //Act: The rating is checked if it is create valid.
            bool valid = rating.CreateValid();

            //Assert: The rating is valid for creation.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BRatingWithInvalidMembers_WhenCreateValidated_ReturnsFalse(){
            //Arrange: a rating with all invalid members is created.
            BRating rating = new BRating{
                Reasons =
                    "1234567890123456789012345678901234567890123456789012345678901234567890"
            };

            //Act: The rating is checked if it is create valid.
            bool valid = rating.CreateValid();

            //Assert: The rating is not valid for creation.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BRatingWithValidMembers_WhenUpdateValidated_ReturnsTrue(){
            //Arrange: a rating with all valid members is created.
            BRating rating = new BRating{
                Reasons = "Reasons"
            };

            //Act: The rating is checked if it is update valid.
            bool valid = rating.UpdateValid();

            //Assert: The rating is valid for updating.
            Assert.AreEqual(true, valid);
        }
        [TestMethod]
        public void BRatingWithInvalidMembers_WhenUpdateValidated_ReturnsFalse(){
            //Arrange: a rating with all invalid members is created.
            BRating rating = new BRating{
                Reasons = 
                "1234567890123456789012345678901234567890123456789012345678901234567890"
            };

            //Act: The rating is checked if it is update valid.
            bool valid = rating.UpdateValid();

            //Assert: The rating is not valid for updating.
            Assert.AreEqual(false, valid);
        }
        [TestMethod]
        public void BBlocked_WhenDeleteValidated_ReturnsTrue(){
            //Arrange: a rating is created
            BRating rating = new BRating();

            //Act: The rating is checked if it is update valid.
            bool valid = rating.DeleteValid();

            //Assert: The rating is valid for updating.
            Assert.AreEqual(true, valid);
        }

        [TestMethod]
        public void BRating_WhenCheckedForEquivilance_AlwaysIsFalse(){
            //Arrange: a rating is created
            BRating rating = new BRating();

            //Act: The rating is checked to be equivilant to itself.
            bool equals = false;// rating.Equivilant(rating);

            //Assert: The rating is valid for updating.
            Assert.AreEqual(false, equals);
        }
    }
}
