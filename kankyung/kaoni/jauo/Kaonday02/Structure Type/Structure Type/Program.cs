using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Type
{
    class Program
    {
        public struct Employee
        {
            public string firstName;
            public int age;
        }
        
        static void Main(string[] args)
        {
            Employee companyEmployee;
            companyEmployee.firstName = "Joe";
            companyEmployee.age = 23;
            Console.WriteLine(companyEmployee);
                
        }
    }
}
