using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] parts = command.Split();

                if (parts[0] == nameof(Citizen))
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdate = parts[4];

                    birthables.Add(new Citizen(id, name, age, birthdate));
                }
                else if (parts[0] ==nameof(Pet))
                {
                    string name = parts[1];
                    string birthdate = parts[2];

                    birthables.Add(new Pet(name, birthdate));
                }
            }

            string filter = Console.ReadLine();

            List<IBirthable> filtered = birthables.Where(x => x.Birthdate.EndsWith(filter)).ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
