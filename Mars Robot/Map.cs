using Mars_Robot.Interfaces;

namespace Mars_Robot
{
    public class Map : IMap
    {
        public long X { get; set; }
        public long Y { get; set; }

        public Map(long x, long y)
        {
            X = x;
            Y = y;
        }

        public bool ValidMove(long targetX, long targetY)
        {
            if (targetX == 0 || targetX > X)
                return false;
            if (targetY == 0 || targetY > Y)
                return false;

            return true;
        }
    }
}
