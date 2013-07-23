using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Program
    {
        struct Employee
        {
            public string firstName;
            public int age;
        }

        public static void Main()
        {
            Employee companyEmployee;
            companyEmployee.firstName = "Joe";
            companyEmployee.age = 25;

        }
    }
}
