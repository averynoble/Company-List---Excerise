using System;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        // Defining and getting the FirstName prop and setting it

        public string LastName { get; set; }
        // Defining and getting the LastName prop and setting it

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string Title { get; set; }
        // Defining and getting the Title prop and setting it

        public DateTime StartDate { get; set; }
        // Defining and getting employee StartDate and setting it
    }
}