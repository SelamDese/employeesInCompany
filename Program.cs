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
        Company NSS = new Company("NSS", DateTime.Now);
// Create three employees
        Employee Selam = new Employee(){
            FirstName = "selam",
            LastName = "dese",
            Title = "student",
            StartDate = new DateTime(2018, 11, 12),
        };
        Employee Andy = new Employee(){
            FirstName = "Andy",
            LastName = "Collins",
            Title = "Instractor",
            StartDate = new DateTime(2019, 01, 12),
        };
        Employee Milli = new Employee(){
            FirstName = "Milli",
            LastName = "Tarek",
            Title = "student",
            StartDate = new DateTime(2019, 03, 12),
        };
// Assign the employees to the company
        NSS.EmployeesList.Add(Selam);
        NSS.EmployeesList.Add(Andy);
        NSS.EmployeesList.Add(Milli);
/*
    Iterate the company's employee list and generate the
    simple report shown above
*/
        // NSS.ListEmployees();
        }
    }
}
