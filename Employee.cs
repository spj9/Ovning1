using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    public class Employee
    {
            public string name;
            public string salary;

            public Employee(string inputName, string inputSalary) 
            { 
                name = inputName;
                salary = inputSalary;   
            }
        public void DisplayRegisteredEmployee()
        {
            Console.WriteLine("Namn: " + name + "\t Lön: " + salary);
        }
    }


}
