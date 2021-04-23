using System;
using System.Linq;
using System.Collections.Generic;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<IBuyer> buyers = new List<IBuyer>();

            Dictionary<string, IBuyer> buyersByName = new Dictionary<string, IBuyer>(); 

            for (int i = 0; i <n; i++)
            {
                string[] input = Console.ReadLine().Split();


                if (input.Length == 3)
                {
                string name = input[0];
                int age = int.Parse(input[1]);
                    string group= input[2];
                    //buyers.Add(new Rebel(name, age , group));

                    buyersByName[name] = new Rebel(name, age, group);
                }
                else 
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthDay = input[3];

                    // buyers.Add(new Citizen(name,age,birthDay,id));
                    buyersByName[name] = new Citizen(name, age, birthDay, id);

                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line =="End" )
                {
                    break;
                }
                if (!buyersByName.ContainsKey(line))
                {
                    continue;
                }

                IBuyer buyer = buyersByName[line];
                buyer.BuyFood();

            }

            int result = buyersByName.Values.Sum(x => x.Food);
            Console.WriteLine(result);
        }
    }
}
