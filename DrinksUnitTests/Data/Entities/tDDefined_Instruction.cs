using DrinksLib.Data.Entities;
using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Data.Entities{
    [TestClass]
    public class tDDefined_Instruction{
        [TestMethod]
        public void DDefined_Instruction_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An avatar with a unique key is constructed.
            DDefined_Instruction avatar = new DDefined_Instruction { Defined_Instruction_ID = -1 };

            //Act: the key is retrieved.
            int key = avatar.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, avatar.Defined_Instruction_ID);
        }

        [TestMethod]
        public void DDefined_InstructionWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An avatar with malicious sql members is constructed.
            string malicious = "<div></div>";
            DDefined_Instruction avatar = new DDefined_Instruction{
                Description = malicious
            };

            //Act: The friended user is scrubbed.
            avatar.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, avatar.Description);
        }

        [TestMethod]
        public void DDefined_InstructionWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An avatar with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DDefined_Instruction avatar = new DDefined_Instruction{
                Description = malicious
            };

            //Act: The friended user is scrubbed.
            avatar.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, avatar.Description);
        }
    }
}
