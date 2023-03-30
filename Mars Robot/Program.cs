using Mars_Robot;

class Program
{
    static void Main(string[] args)
    {
        string[] size = args[0].Split('x');
        var x = Convert.ToInt64(size[0]);
        var y = Convert.ToInt64(size[1]);

        Map map = new Map(x, y);

        Robot robot = new Robot(map);

        char[] directions =
            args[1].ToCharArray();        

        Console.WriteLine(robot.ReturnCoordinates());
        Console.ReadLine();
    }
}