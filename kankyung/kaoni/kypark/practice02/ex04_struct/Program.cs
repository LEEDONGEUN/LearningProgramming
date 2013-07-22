using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_struct
{
    class Employee
    {
        public string firstName;
        public string phone;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee companyEmployee;
            companyEmployee.firstName = "joe";
            companyEmployee.age = 23;
            companyEmployee.phone = "011-1111-1111";
            Console.WriteLine(companyEmployee.firstName);
            Console.WriteLine(companyEmployee.age);
            Console.WriteLine(companyEmployee.phone);
            Console.WriteLine();
            companyEmployee.firstName = "jane";
            Console.WriteLine(companyEmployee.firstName);
            Console.WriteLine(companyEmployee.age);
            Console.WriteLine(companyEmployee.phone);
        }
    }
}