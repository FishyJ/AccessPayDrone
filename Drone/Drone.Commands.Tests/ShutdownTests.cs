using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class ShutdownTests
    {
        [TestCase("D", true)]
        [TestCase("d", true)]
        [TestCase("", false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, Shutdown.InstructionIsForThisComand(instruction));
        }
    }
}
