using System;
using System.Collections.Generic;
using HiredEmployees;

namespace Companies
{
    public class Company
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public DateTime FoundingDate { get; }

        public void ListEmployees()
        {

            foreach (Employee elm in Employees)
            {

                Console.WriteLine($"{elm.FullName} works for {this.Name} as {elm.Title} since {elm.StartDate}. ");
            }

        }

        public Company(string name, List<Employee> listOfEmployees, DateTime dateFounded)
        {
            Name = name;
            Employees = listOfEmployees;
            FoundingDate = dateFounded;
        }
    }


}