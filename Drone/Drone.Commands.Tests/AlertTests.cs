using System;
using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class AlertTests
    {
        [TestCase("",false,0)]
        [TestCase("A4.5",true,4.5)]
        [TestCase("a2.3",true,2.3)]
        [TestCase("t2.3",false,0)]
        public void TestAlert(string instruction, bool expectToBeValid, double seconds)
        {
            try
            {
                Alert a = new Alert(instruction);

                if (expectToBeValid)
                {
                    Assert.IsNotNull(a);
                    Assert.AreEqual(seconds, a.RemainingSeconds, 0.01, "Seconds");
                }
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(!expectToBeValid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestCase(2.56)]
        public void TestAlert(double seconds)
        {
            Alert a = new Alert(seconds);

            Assert.IsNotNull(a);
            Assert.AreEqual(seconds,a.RemainingSeconds,0.01,"Seconds");
        }
    }
}
