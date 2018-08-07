using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class StartTests
    {
        [TestCase("S", true)]
        [TestCase("s", true)]
        [TestCase("", false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, Start.InstructionIsForThisComand(instruction));
        }
    }
}
