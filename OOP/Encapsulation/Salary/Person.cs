using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;          
            this.LastName = lastName;          
            this.Age = age;
            this.Salary = salary;

        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
       
        public int Age { get; private set; }
        public decimal Salary { get;private set; }

        public void IncreaseSalary(decimal parcentage)
        {
           
            if (Age<30)
            {
                parcentage /= 2; 
            }
            Salary = Salary + Salary * parcentage/100;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {Salary:f2}"; 
                
        }
    }
}

