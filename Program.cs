using System;
using System.Collections.Generic;

namespace employeesInCompany
{

// Using C# classes, you need to create custom types to represent an Employee and a Company. 
// Then you will create some employees, hire them into the company and then display 
// a simple report showing the employee names and their titles.
    class Employee
            {
// Create a custom type for Employee. An employee has the following properties.
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string Title { get; set; }
                public DateTime StartDate {get; set; }

            }

    class Company
    {
// Create a custom type for Company. A company has the following properties.

        public DateTime DateFounded { get; }
        public string CompanyName { get; }
        public List<Employee> EmployeesList { get; set; }
        
        public Company( string name, DateTime dateFounded )
        {
            DateFounded = dateFounded;
            CompanyName = name;
            EmployeesList = new List<Employee>();
        }
        
        public void ListEmployees()
        {
            foreach ( Employee Employee in EmployeesList)
            {
                Console.WriteLine($"{Employee.FirstName} {Employee.LastName} works for {CompanyName} as {Employee.Title} since {Employee.StartDate}");
            }
        }

    }        
    class Program
            {
               static void Main(string[] args)
            {
// Create an instance of a company. Name it whatever you like.

        }
    }
}
