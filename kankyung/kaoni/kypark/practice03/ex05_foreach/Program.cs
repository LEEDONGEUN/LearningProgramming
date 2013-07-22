using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex05_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
