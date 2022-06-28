using System;
using System.Collections.Generic;
using System.Text;

namespace ReizTechHomework.ClockTask
{
    class AnalogueClock
    {

        public readonly int Hours;
        public readonly int Minutes;

        public AnalogueClock(int hours, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Validate();
        }

        private void Validate()
        {
            // range is between 00:01 and 12:00
            if (this.Hours < 0)
            {
                throw new ApplicationException("Hours cannot be negative");
            }
            else if (this.Hours > 12)
            {
                throw new ApplicationException("Analogue clock does not have more than 12 hours. Hours can be between 0 and 12");
            }
            else if (this.Minutes < 0)
            {
                throw new ApplicationException("Minutes cannot be negative");
            }
            else if (this.Minutes > 59)
            {
                throw new ApplicationException("Analogue clock does not support beyond 60 minutes. Minutes can be between 0 and 59.");
            }

            int time = this.Hours * 100 + this.Minutes;
            if (time > 1200)
            {
                throw new ApplicationException("Analogue clock cannot go beyond 12 hours");
            }
            else if (time < 0001)
            {
                throw new ApplicationException("Analogue clock does not support 00:00 and below. Change 00:00 to 12:00");
            }
        }

        public double MinutesToDegrees()
        {
            return (double) this.Minutes / 60 * 360;
        }

        public double HoursToDegrees()
        {
            double baseDegrees = (double) this.Hours / 12 * 360;
            double oneTickDegrees = 1.0 / 12 * 360;
            double partialDegrees = this.MinutesToDegrees() / 360 * oneTickDegrees;
            return baseDegrees + partialDegrees;
        }

    }
}
