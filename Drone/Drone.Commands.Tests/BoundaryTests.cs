using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class BoundaryTests
    {
        [TestCase("B2,4", true)]
        [TestCase("b2,4", true)]
        [TestCase("B2.0,4.0", true)]
        [TestCase("b2.0,4.0", true)]
        [TestCase("B2.560,4.670", true)]
        [TestCase("b2.560,4.670", true)]
        [TestCase("B2.560,", false)]
        [TestCase("b2.560,", false)]
        [TestCase("B,4.670", false)]
        [TestCase("b,4.670", false)]
        [TestCase("", false)]
        [TestCase("t", false)]
        public void TestInstruction(string instruction, bool expectedToBeValid)
        {
            Assert.AreEqual(expectedToBeValid, Boundary.InstructionIsForThisComand(instruction));
        }

        [TestCase("B2,4", true, 2, 4)]
        [TestCase("b2,4", true,2,4)]
        [TestCase("B2.0,4.0", true,2,4)]
        [TestCase("b2.0,4.0", true,2,4)]
        [TestCase("B2.560,4.670", true, 2.560, 4.670)]
        [TestCase("b2.560,4.670", true, 2.560, 4.670)]
        [TestCase("B2.560,", false,0,0)]
        [TestCase("b2.560,", false,0,0)]
        [TestCase("B,4.670", false,0,0)]
        [TestCase("b,4.670", false,0,0)]
        [TestCase("", false,0,0)]
        [TestCase("t", false,0,0)]
        public void TestPoint(string instruction, bool expectedToBeValid, double x, double y)
        {
            try
            {
                //Act & Assign
                Boundary b = new Boundary(instruction);

                //Assert
                if (expectedToBeValid)
                {
                    Assert.AreEqual(x, b.Point.X, 0.01, "X");
                    Assert.AreEqual(y, b.Point.Y, 0.01, "Y");
                }
                else
                {
                    Assert.IsNull(b.Point);
                }
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(!expectedToBeValid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
