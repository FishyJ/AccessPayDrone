using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class HomeTests
    {
        [TestCase("H", true)]
        [TestCase("h", true)]
        [TestCase("", false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, Home.InstructionIsForThisComand(instruction));
        }
    }
}
