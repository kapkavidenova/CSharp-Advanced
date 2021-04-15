using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="Ënd")
            {
                string[] info = input.Split();

                string name = info[0];
                string country = info[1];
                int age = int.Parse(info[2]);

            Citizen citizen = new Citizen(name, country, age);

                IResident resident = citizen;
                IPerson person = citizen;

            Console.WriteLine(person.GetName());
            Console.WriteLine(resident.GetName());


                input = Console.ReadLine();
            }

        }
    }
}
