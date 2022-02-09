using System;
using System.Collections.Generic;

namespace CSP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe Smith", "100 Main Street", "Bostan", "MA", "011010");

            Console.WriteLine(joe.ToString());

            joe.Insurance = new InsuranceInfo() { PolicyID = "123", PolicyName = "Life" };
            Console.WriteLine(joe.ToString());

            Manager dave = new Manager("Dave Jones", "200 center Street", "Boston", "MA", "0101010");
            Console.WriteLine(dave.ToString());

            Console.WriteLine(joe.DoWork("Programming"));
            Console.WriteLine(dave.DoWork());

            Employee steve = new Manager("Steve Smith", "200 center Street", "Boston", "MA", "0101010", 75000);
            Console.WriteLine(steve.ToString());
            Console.WriteLine(steve.DoWork("Programming"));
            Console.WriteLine("----------");


            List<Employee> employees = new List<Employee>();
            employees.Add(joe);
            employees.Add(steve);
            employees.Add(dave);

            foreach (var emp in employees)
            {
                Console.WriteLine(emp.DoWork());
            }
        }
    }
}
