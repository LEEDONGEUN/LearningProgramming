using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_22_01
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
	                companyEmployee.firstName = "joe";
	                companyEmployee.age = 23;
                    Console.WriteLine(companyEmployee.firstName +  "는"+ companyEmployee.age + "이다 " );
                }

        }
    }

