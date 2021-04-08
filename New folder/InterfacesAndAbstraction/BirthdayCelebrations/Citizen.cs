using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IBirthable
    {
        //public Citizen(string name, int age, string birthdate)
        //{
        //    Name = name;
        //    Age = age;
        //    Birthdate = birthdate;
        //}

        public Citizen(string id, string name, int age, string birthdate)
        {
            Id = Id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }
    }
}
