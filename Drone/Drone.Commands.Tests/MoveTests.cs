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

        [TestCase("M2,4", true,2,4)]
        [TestCase("m2,4", true,2,4)]
        [TestCase("M2.0,4.0", true,2,4)]
        [TestCase("m2.0,4.0", true,2,4)]
        [TestCase("M2.560,4.670", true,2.56,4.67)]
        [TestCase("m2.560,4.670", true,2.56,4.67)]
        [TestCase("M2.560,", false,0,0)]
        [TestCase("m2.560,", false,0,0)]
        [TestCase("M,4.670", false,0,0)]
        [TestCase("m,4.670", false,0,0)]
        [TestCase("", false,0,0)]
        [TestCase("t", false,0,0)]
        public void TestInstructionCreatedCorrectObject(string instruction, bool expectNoneNullObject, double distance, double degrees)
        {
            try
            {
                Move move = new Move(instruction);

                if (expectNoneNullObject)
                {
                    Assert.IsNotNull(move);
                }
            }
            catch (ArgumentException)
            {
                Assert.True(!expectNoneNullObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
