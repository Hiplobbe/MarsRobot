using Mars_Robot;

class Program
{
    private static long X { get; set; }
    private static long Y { get; set; }

    static void Main(string[] args)
    {
        string[] size = args[0].Split('x');
        X = Convert.ToInt64(size[0]);
        Y = Convert.ToInt64(size[1]);

        Robot robot = new Robot();

        char[] directions =
            args[1].ToCharArray();

        foreach (char dirr in directions)
        {
            if(dirr == 'F')
            {
                robot.MoveForward(X, Y);
            }
            else
            {
                robot.Turn(dirr);
            }
        }

        Console.WriteLine(robot.X + " " + robot.Y + " " + robot.Direction.ToString());
        Console.ReadLine();
    }
}