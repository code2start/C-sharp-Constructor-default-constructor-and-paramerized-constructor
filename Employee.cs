using System;

namespace consturctor1
{
    public class Employee
    {
        public string name;
        public int age;
        public bool agree;

        public Employee(string name, int age, bool agree)
        {
            //Console.WriteLine("Object Created...");
            this.name = name;
            this.age = age;
            this.agree = agree;
        }
        public Employee()
        {

        }

    }
}