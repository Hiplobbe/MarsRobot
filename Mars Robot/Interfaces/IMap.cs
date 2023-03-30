using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Robot.Interfaces
{
    public interface IMap
    {
        public long X { get; set; }
        public long Y { get; set; }

        public bool ValidMove(long x, long y);
    }
}
