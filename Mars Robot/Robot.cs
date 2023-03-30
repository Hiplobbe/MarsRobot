using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Robot
{
     public class Robot
    {
        public Direction Direction { get; set; }
        public long X { get; set; }
        public long Y { get; set; }


        public Robot()
        {
            Direction = Direction.North;
            X = 1;
            Y = 1;
        }

        public void MoveForward(long maxX, long maxY)
        {
            switch (this.Direction)
            {
                case Direction.North:
                    if(Y == maxY)
                    {
                        return;
                    }
                    Y++;
                    break;
                case Direction.West:
                    if (X == 1)
                    {
                        return;
                    }
                    X--;
                    break;
                case Direction.South:
                    if (Y == 1)
                    {
                        return;
                    }
                    Y--;
                    break;
                case Direction.East:
                    if (X == maxX)
                    {
                        return;
                    }
                    X++;
                    break;
            }
        }

        public void Turn(char direction)
        {
            switch (direction)
            {
                case 'L':
                    if(Direction == Direction.North)
                    {
                        this.Direction = Direction.West;
                        break;
                    }

                    Direction = Direction - 1;

                    break;

                case 'R':
                    if (Direction == Direction.West)
                    {
                        Direction = Direction.North;
                        break;
                    }

                    Direction = Direction + 1;

                    break;
            }
        }
    }

    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }
}
