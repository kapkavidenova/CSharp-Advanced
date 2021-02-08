using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            int numberGrades = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberGrades; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                decimal grade = decimal.Parse(info[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<decimal>();
                }
                grades[name].Add(grade);
            }

            foreach (var item in grades)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }

        }
    }
}
