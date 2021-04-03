using System;
using System.Collections.Generic;
using System.Text;



namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary = 460)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;

        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Tova ne e ime");
                }
                this.firstName = value;
            }

        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Tova ne posledno ime");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Ne moje takava zaplata");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal parcentage)
        {

            if (Age < 30)
            {
                parcentage /= 2;
            }
            Salary = Salary + Salary * parcentage / 100;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {Salary:f2}";

        }
    }
}
