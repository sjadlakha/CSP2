using System;
namespace CSP2
{
    public class Employee
    {
        public string Name { get; set; }
        public AddressInfo Address { get; set; } // Composition
        public InsuranceInfo Insurance { get; set; } // Aggregation
        public double Salary { get; set; }

        // Constructor overloading
        public Employee(string name, string street, string city, string state, string postalcode):
            this(name, street, city, state, postalcode, 50000)
        {
        }

        public Employee(string name, string street, string city, string state, string postalcode, double salary)
        {
            Name = name;
            Salary = salary;
            Address = new AddressInfo()
            {
                Street = street,
                City = city,
                State = state,
                PostalCode = postalcode
            };
        }

        public virtual string DoWork()
        {
            return "Employee doing work!";
        }public virtual string DoWork(string workType)
        {
            return "Employee doing "+ workType;
        }

        public override string ToString()
        {
            string retVal = Name + " " +
                Address.Street + " " +
                Address.City + " " +
                Address.State + " " +
                Address.PostalCode + " " +
                "Salary: " + Salary ;

            if (Insurance != null)
            {
                retVal += " " +
                    Insurance.PolicyName + " " +
                    Insurance.PolicyID;
            }

            return retVal;
        }
    }
}
