using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_struct
{
    struct Employee
    {
        public string firstName;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee companyEmployee;
            companyEmployee.firstName = "joe";
            companyEmployee.age = 23;
            Console.WriteLine(companyEmployee.firstName);
            Console.WriteLine(companyEmployee.age);
        }
    }
}