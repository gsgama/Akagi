using System;
using Xunit;

namespace Akagi.UnitTests
{
    public class SetCouseCommandTests
    {
        [Fact]
        public void SetShipCourse()
        {
            var ship = new Ship();
            new SetCourseCommand(ship, 270).Execute();
            Assert.Equal(270, ship.Course);
        }
    }

    public class Ship
    {
        public int Course { get; set; }
    }

    public class SetCourseCommand
    {
        public SetCourseCommand(Ship target, int newCourse)
        {
            Target = target ?? throw new ArgumentNullException(nameof(target));
            NewCourse = newCourse;
        }

        public Ship Target { get; }
        public int NewCourse { get; }

        public void Execute()
        {
            Target.Course = NewCourse;
        }
    }
}
