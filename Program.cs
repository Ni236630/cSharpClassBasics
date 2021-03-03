using System;
using System.Collections.Generic;
using HiredEmployees;
using Companies;
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {   

            // creating list for company
            List<Employee> listOfEmployees = new List<Employee>(); 
            
            //creating a company
            Company codeWorld = new Company("Code World", listOfEmployees,  new DateTime());
           
            //creating employees

            Employee amber = new Employee("Amber", "Colins", "Lead Designer", new DateTime());
            Employee nick = new Employee("nick", "douso", "Junior Programmer", new DateTime());
            Employee ron = new Employee("ron", "howie", "Lead Programmer", new DateTime());

               

            codeWorld.Employees.Add(amber);
            codeWorld.Employees.Add(nick);
            codeWorld.Employees.Add(ron);
    
            codeWorld.ListEmployees();
        }
    }
}
