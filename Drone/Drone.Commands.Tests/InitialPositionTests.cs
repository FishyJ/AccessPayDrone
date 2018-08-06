using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class InitialPositionTests
    {
        [TestCase("P2,4", true)]
        [TestCase("p2,4", true)]
        [TestCase("P2.0,4.0", true)]
        [TestCase("p2.0,4.0", true)]
        [TestCase("P2.560,4.670", true)]
        [TestCase("p2.560,4.670", true)]
        [TestCase("P2.560,", false)]
        [TestCase("p2.560,", false)]
        [TestCase("P,4.670", false)]
        [TestCase("p,4.670", false)]
        [TestCase("", false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, InitialPosition.InstructionIsForThisComand(instruction));
        }

        [TestCase("P2,4", true, 2, 4)]
        [TestCase("p2,4", true, 2, 4)]
        [TestCase("P2.0,4.0", true, 2, 4)]
        [TestCase("p2.0,4.0", true, 2, 4)]
        [TestCase("P2.560,4.670", true, 2.560, 4.670)]
        [TestCase("p2.560,4.670", true, 2.560, 4.670)]
        [TestCase("P2.560,", false, 0, 0)]
        [TestCase("p2.560,", false, 0, 0)]
        [TestCase("P,4.670", false, 0, 0)]
        [TestCase("p,4.670", false, 0, 0)]
        [TestCase("", false, 0, 0)]
        [TestCase("t", false, 0, 0)]
        public void TestPoint(string instruction, bool expectedToBeValid, double x, double y)
        {
            //Act & Assign
            InitialPosition ip = new InitialPosition(instruction);

            //Assert
            if (expectedToBeValid)
            {
                Assert.AreEqual(x, ip.Point.X, 0.01, "X");
                Assert.AreEqual(y, ip.Point.Y, 0.01, "Y");
            }
            else { Assert.IsNull(ip.Point); }
        }

    }
}
