using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                elements.Add(element);
            }

            Box<string> box = new Box<string>(elements);

            string elementToCompare = Console.ReadLine();

            int countElements = box.CountGreaterElement(elements,elementToCompare);

            Console.WriteLine(countElements);


        }
    }
}
