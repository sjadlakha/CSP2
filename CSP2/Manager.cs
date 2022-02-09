using System;
namespace CSP2
{
    public class Manager: Employee
    {
// Constructor overloading
        public Manager(string name, string street, string city, string state, string postalcode, double salary) :
            base(name, street, city, state, postalcode, salary)
        {
        }
        public Manager(string name, string street, string city, string state, string postalcode) :
            this(name, street, city, state, postalcode, 60000)
        {
        }

        public override string DoWork()
        {
            return "Manager is doing work!";
        }

        public override string DoWork(string workType)
        {
            return "Supervising " + workType;
        }
    }
}
