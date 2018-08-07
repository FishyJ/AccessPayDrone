using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class CommandList
    {
        public List<BaseCommand> List { get; set; }

        public CommandList()
        {
            List = new List<BaseCommand>();
        }
    }
}
