﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {

        public Citizen(string name, int age, string id, string birtdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birtdate;

        }
        public string Name { get; private set; }

        public int Age { get ; private set ; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

       
    }
}
