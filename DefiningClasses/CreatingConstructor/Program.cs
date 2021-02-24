using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Ana", 20);
            Console.WriteLine(personOne.Name + " " + "-" + personOne.Age);
        }
    }
}
