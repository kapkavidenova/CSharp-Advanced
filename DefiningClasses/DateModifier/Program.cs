using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firsttDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDifference(firsttDate, secondDate);
            Console.WriteLine(days);
        }
    }
}
