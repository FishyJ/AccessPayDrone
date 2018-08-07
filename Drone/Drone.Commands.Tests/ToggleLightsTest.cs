using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class ToggleLightsTest
    {
        [TestCase("T", true)]
        [TestCase("t", true)]
        [TestCase("", false)]
        [TestCase("r", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, ToggleLights.InstructionIsForThisComand(instruction));
        }

        [TestCase()]
        public void TestInstructionCreatedCorrectObject()
        {
            ToggleLights tl = new ToggleLights();
            Assert.IsNotNull(tl);
            Assert.IsInstanceOf<ITrigger>(tl);
        }
    }
}
