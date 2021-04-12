using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (line != "End")
            {
                string[] parts = line.Split();

                if (parts.Length == 3)
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];

                    //IIdentifiable citizen = new Citizen(id, name, age);
                    identifiables.Add(new Citizen(id,name,age));
                }

                else if (parts.Length == 2)
                {
                    string model = parts[0];
                    string id = parts[1];

                   identifiables.Add(new Robot(id, model));
                    
                }
                line = Console.ReadLine();
            }
            string filterId = Console.ReadLine();

            List<IIdentifiable> filtered = identifiables.Where(i => i.Id.EndsWith(filterId)).ToList();

            foreach (var identifiable in filtered)
            {
                Console.WriteLine(identifiable.Id);
            }
        }
    }
}
