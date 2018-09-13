using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    public class Company
    {
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        //READONLY
        public readonly string nameOfPerson;
        public readonly int Wages;
        public readonly DateTime CompanyYear;
        public readonly string CompanyName;


        //constructor is a method
        public Company(string personName, int personWages, DateTime yearCreated, string nameOfCompany)
        {
            nameOfPerson = personName;
            Wages = personWages;
            CompanyYear = yearCreated;
            CompanyName = nameOfCompany;
        }

        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        List<string> employeeFirstName = new List<string>(); 


        // Create a method that allows external code to add an employee

        public void AddEmployee(string firstName)
        {
            employeeFirstName.Add(firstName);
        }

        // Create a method that allows external code to remove an employee

        public void RemoveEmployee(string firstName)
        {
            employeeFirstName.Remove(firstName);
        }

        public List<string> GetEmployeeList()
        {
            return employeeFirstName;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime companyYear = new DateTime(2018, 8, 29);
            Company SamsClub = new Company("Julie", 300, companyYear, "Sams Club");
            SamsClub.AddEmployee("Lola");
            List<string> listOfEmployeeFirstNames = SamsClub.GetEmployeeList();

            foreach (string name in listOfEmployeeFirstNames)
            {
                Console.WriteLine(name);
                Console.Read();
            }
        }
    }
}
