using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Robot.Interfaces
{
    public interface IRobot
    {
        public IMap Map { get; set; }
        public Direction Direction { get; set; }
        public long X { get; set; }
        public long Y { get; set; }

        void RunInstructions(char[] instructions);
        string ReturnCoordinates();
    }
}
