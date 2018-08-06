using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class MoveTests
    {
        [TestCase("M2,4", true)]
        [TestCase("m2,4", true)]
        [TestCase("M2.0,4.0", true)]
        [TestCase("m2.0,4.0", true)]
        [TestCase("M2.560,4.670", true)]
        [TestCase("m2.560,4.670", true)]
        [TestCase("M2.560,", false)]
        [TestCase("m2.560,", false)]
        [TestCase("M,4.670", false)]
        [TestCase("m,4.670", false)]
        [TestCase("", false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, Move.InstructionIsForThisComand(instruction));
        }
    }
}
