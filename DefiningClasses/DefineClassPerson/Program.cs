//using DefiningClasses;
using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Pesho";
            person.Age = 20;

            Person secondPerson = new Person();
            secondPerson.Name = "Gosho";
            secondPerson.Age = 18;

            Person thirdPerson = new Person();
            thirdPerson.Name = "Stamat";
            thirdPerson.Age = 43;

            Console.WriteLine($"{ person.Name} - { person.Age}");
            Console.WriteLine($"{ secondPerson.Name} - {secondPerson.Age}");
            Console.WriteLine($"{  thirdPerson.Name} - {  thirdPerson.Age}");
        }
    }
}
