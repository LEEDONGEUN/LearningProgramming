using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                int dan = number * i;
                Console.WriteLine("{0} X {1} = {2}", number, i, dan);
            }
        }
    }
}
