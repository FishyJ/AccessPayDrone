using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException() {}

        public InvalidCommandException(string message) : base(message) {}

        public InvalidCommandException(string message, Exception innerException) : base(message, innerException) {}

        protected InvalidCommandException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
