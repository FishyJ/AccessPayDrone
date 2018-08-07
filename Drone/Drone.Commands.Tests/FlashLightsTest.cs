using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class FlashLightsTest
    {
        [TestCase("F", true)]
        [TestCase("f", true)]
        [TestCase("", false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, FlashLights.InstructionIsForThisComand(instruction));
        }
    }
}
