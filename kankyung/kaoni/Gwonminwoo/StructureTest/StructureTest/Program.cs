using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureTest
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
                Console.WriteLine("{0}",companyEmployee.firstName);
                Console.WriteLine("{0}", companyEmployee.age);


        }
    }
}
