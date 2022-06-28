using System;
using System.Collections.Generic;
using System.Text;

namespace ReizTechHomework.ClockTask
{
    class MainProgram
    {
        public static void Run()
        {
            Console.WriteLine("Input hours (0 - 12)");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input minutes (0 - 59)");
            int minutes = Convert.ToInt32(Console.ReadLine());

            var clock = new AnalogueClock(hours, minutes);

            double degreesBetween = Math.Abs(clock.HoursToDegrees() - clock.MinutesToDegrees());
            degreesBetween = Math.Min(degreesBetween, 360 - degreesBetween);

            Console.WriteLine($"Degrees between hours arrow and minutes arrow: {degreesBetween}");
        }
    }
}
