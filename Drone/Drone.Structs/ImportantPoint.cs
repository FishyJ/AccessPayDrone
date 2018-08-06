using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Structs
{
    internal class ImportantPoint
    {
        public PointD Point { get; }

        private ImportantPoint() {} // Hide the default constructor.

        public ImportantPoint(PointD point) => Point = point;
    }
}
