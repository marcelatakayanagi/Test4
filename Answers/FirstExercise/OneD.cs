using System;
using System.Collections.Generic;
using System.Text;

namespace Answers.FirstExercise
{
    public static class OneD
    {

        public static DateTime NextWorkDay(this DateTime origin)
        {
            var nextWorkDay = DateTime.Now;
            if ((nextWorkDay.DayOfWeek == DayOfWeek.Saturday)) 
            {
                nextWorkDay.AddDays(2);
            }

            if ((nextWorkDay.DayOfWeek == DayOfWeek.Sunday)) 
            {
                nextWorkDay.AddDays(1);
            }

            return nextWorkDay;
        }

    }
}
