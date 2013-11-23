using DrinksLib.Data.Entities;
using DrinksLib.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DrinksLibUnitTests.Data.Entities{
    [TestClass]
    public class tDInstruction{
        [TestMethod]
        public void DInstruction_WhenAskedForKey_ReturnsEmail_ID(){
            //Arrange: An instruction with a unique key is constructed.
            DInstruction instruction = new DInstruction { Instruction_ID = -1 };

            //Act: the key is retrieved.
            int key = instruction.key;

            //Assert: the key is the same as the friended user's ID.
            Assert.AreEqual(key, instruction.Instruction_ID);
        }

        [TestMethod]
        public void DInstructionWithHtmlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An instruction with malicious sql members is constructed.
            string malicious = "<div></div>";
            DInstruction instruction = new DInstruction{
                Description = malicious
            };

            //Act: The friended user is scrubbed.
            instruction.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, instruction.Description);
        }

        [TestMethod]
        public void DInstructionWithSqlMembers_WhenScrubbed_BecomesSafe(){
            //Arrange: An instruction with malicious html and sql members is constructed.
            string malicious = "1');DELETE TABLE dbo.example;--";
            DInstruction instruction = new DInstruction{
                Description = malicious
            };

            //Act: The friended user is scrubbed.
            instruction.Scrub();

            //Assert: The friended user has no html in its members.
            Assert.AreNotEqual(malicious, instruction.Description);
        }
    }
}
