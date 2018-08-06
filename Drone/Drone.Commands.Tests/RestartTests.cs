using Drone.Commands;
using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class RestartTests
    {
        [TestCase("R",true)]
        [TestCase("r",true)]
        [TestCase("",false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid,Restart.InstructionIsForThisComand(instruction));
        }
    }
}
