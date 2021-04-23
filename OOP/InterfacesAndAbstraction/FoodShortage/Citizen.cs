using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IPerson, IBirthdable, IIdentifiable
    {

        public Citizen(string name, int age, string birthDay, string id)
        {
            this.Name = name;
            this.Age = age;
            this.BirthDay = birthDay;
            this.Id = id;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string BirthDay { get; private set; }

        public string Id { get; private set; }


        public int Food { get; private set; }



        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
