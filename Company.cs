using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        
        // Create a constructor method that accepts two arguments:
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            //    1. The name of the company

            CreatedOn = createdOn;
            //    2. The date it was created

            Employees = new List<Employee>();
            //    3. This is setting the value of employees and allows us to put employees created into the List
        }

        public void ListEmployees(Employee employee, Company company)
        {
            Console.WriteLine($"{employee.FullName} works for {company.Name} as a {employee.Title} since {employee.StartDate}.");   
        }    
    }
}
