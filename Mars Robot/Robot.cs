using Mars_Robot.Interfaces;

namespace Mars_Robot
{
     public class Robot : IRobot
    {
        public IMap Map { get; set; }
        public Direction Direction { get; set; }
        public long X { get; set; }
        public long Y { get; set; }


        public Robot(IMap map)
        {
            Map = map;
            Direction = Direction.North;
            X = 1;
            Y = 1;
        }

        public void RunInstructions(char[] instructions)
        {
            foreach (char dirr in instructions)
            {
                if (dirr == 'F')
                {
                    MoveForward();
                }
                else
                {
                    Turn(dirr);
                }
            }
        }

        public string ReturnCoordinates()
        {
            return X + " " + Y + " " + Direction.ToString();
        }

        private void MoveForward()
        {
            switch (Direction)
            {
                case Direction.North:
                    if(Map.ValidMove(X, Y + 1))
                    {
                        Y++;
                    }                    
                    break;
                case Direction.West:
                    if (Map.ValidMove(X - 1, Y))
                    {
                        X--;
                    }                   
                    break;
                case Direction.South:
                    if (Map.ValidMove(X, Y - 1))
                    {
                        Y--;
                    }
                    break;
                case Direction.East:
                    if (Map.ValidMove(X + 1, Y))
                    {
                        X++;
                    }
                    break;
            }
        }

        private void Turn(char direction)
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
