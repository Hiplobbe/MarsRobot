using Mars_Robot;
using NUnit.Framework;

namespace RobotTest
{
    public class RobotTest
    {
        [TestCase(5, 5, "RFFFFFF", "5 1 East")]
        [TestCase(5, 5, "LFFFF", "1 1 West")]
        [TestCase(5, 5, "FFRRFF", "1 1 South")]
        [TestCase(5, 5, "FFRFLFLF", "1 4 West")]
        [TestCase(5, 5, "FFFFFRFFFFF", "5 5 East")]
        [TestCase(30, 30, "FFRFLFLF", "1 4 West")]
        public void MarsTestRuns(long maxX, long maxY, string directions, string result)
        {
            Map map = new Map(maxX, maxY);
            Robot robot = new Robot(map);

            robot.RunInstructions(directions.ToCharArray());

            Assert.AreEqual(robot.ReturnCoordinates(), result);
        }
    }
}
