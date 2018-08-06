using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Drone.Commands.Tests
{
    public class FactoryTests
    {
        [TestCase("invalid", typeof(Start), false)]
        [TestCase("s", typeof(Start),true)]
        [TestCase("S", typeof(Start), true)]
        [TestCase("b3,4", typeof(Boundary), true)]
        [TestCase("B3,4", typeof(Boundary), true)]
        [TestCase("p3,4", typeof(InitialPosition), true)]
        [TestCase("P3,4", typeof(InitialPosition), true)]
        [TestCase("r", typeof(Restart), true)]
        [TestCase("R", typeof(Restart), true)]
        [TestCase("d", typeof(Shutdown), true)]
        [TestCase("D", typeof(Shutdown), true)]
        [TestCase("t", typeof(ToggleLights), true)]
        [TestCase("T", typeof(ToggleLights), true)]
        [TestCase("a2.5", typeof(Alert), true)]
        [TestCase("A2,5", typeof(Alert), true)]
        [TestCase("h", typeof(Home), true)]
        [TestCase("H", typeof(Home), true)]
        [TestCase("m3,4", typeof(Move), true)]
        [TestCase("M3,4", typeof(Move), true)]
        public void FactoryReturnsCorrectObject(string instruction, Type type,bool expectValidObject)
        {
            object o = Factory.CreateCommand(instruction);
            if (expectValidObject)
            {
                Assert.IsNotNull(o);
                Assert.IsInstanceOf<BaseCommand>(o,"Is BaseCommand");
                Assert.IsInstanceOf(type,o,"Is correct type.");
            }
            else
            {
                Assert.IsNull(o);
            }
        }
    }
}
