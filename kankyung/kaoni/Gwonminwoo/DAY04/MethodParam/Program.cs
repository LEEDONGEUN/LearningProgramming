using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExample
{
    class Program
    {
            int ret1= Add(1,2,3,4,5);
     static int [] iarr = new int[5] {1,2,3,4,5};
            int ret2 = Add(iarr);
        
        static int Add(int a, int b)
        {
            int[] iarr = { a, b };
            return a + b;
        }
        static string Add(string a, string b)
        {
                   
            return String.Concat(a,b);
                    }
        static int Add(int a, int b, int c)
        {
            return a + b +c;
        }
        /*static int Add(int n1 ,int n2)
        {
                  }*/
        static int Add (params int [ ] intArr)
        {
            int retvlaue = 0;
            foreach (int item in intArr )
            {
                retvlaue =retvlaue + item;
            }
            return retvlaue;  
         }
            
        static void Main(string[] args)
        {
             int [ ] Re ={2,3,4};
            Console.WriteLine(Add(1, 2) + Add(1, 2, 3)+Add(Re));
        }
    }
}