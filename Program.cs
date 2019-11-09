using System;

namespace consturctor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Mohamed", 20, false);
            Employee e2 = new Employee();
            Console.WriteLine(e1.name);
            Console.WriteLine(e1.age);
            Console.WriteLine(e1.agree);
        }
    }
}
