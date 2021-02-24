using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static int GetDifference(string firstDate, string secondDate)
        {
            //DateTime dateOne = new DateTime();

            DateTime firsttDate = DateTime.Parse(firstDate);
            DateTime secondtDate = DateTime.Parse(secondDate);

            TimeSpan diff = firsttDate - secondtDate;
            return Math.Abs(diff.Days);

        }
    }
}
