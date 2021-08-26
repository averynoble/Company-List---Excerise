using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company newCompany = new Company("Loogle", new DateTime (2000, 01, 01));
            
            // Create three employees
            Employee mike = new Employee();
            mike.FirstName = "Michael";
            mike.LastName = "Johnson";
            mike.Title = "Janitor";
            mike.StartDate = new DateTime(2002, 02, 12);

            Employee will = new Employee();
            will.FirstName = "William";
            will.LastName = "Washington";
            will.Title = "Senior Developer";
            will.StartDate = new DateTime(2004, 06, 23);

            Employee chad = new Employee();
            chad.FirstName = "Chaddingham";
            chad.LastName = "Buckley";
            chad.Title = "Senior Developer";
            chad.StartDate = new DateTime(2005, 03, 12);
        
            // Assign the employees to the company
            newCompany.Employees.Add(mike);
            newCompany.Employees.Add(will);
            newCompany.Employees.Add(chad);

            /*
                Iterate the company's employee list and generate the 
                simple report shown above
            */
            
            foreach (Employee employee in newCompany.Employees)
            {
                newCompany.ListEmployees(employee, newCompany);
            }

        }
    }
}
