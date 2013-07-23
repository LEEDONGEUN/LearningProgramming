using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (int numbers in list)
            {
                Console.Write("{0} ", numbers);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            list.RemoveAt(2);

            foreach (int numbers in list)
            {
                Console.Write("{0} ", numbers);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            list.Add(20);
            foreach (int numbers in list)
            {
                Console.Write("{0} ", numbers);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            list.Insert(1, 28);
            foreach (int numbers in list)
            {
                Console.Write("{0} ", numbers);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            list.Sort();
            foreach (int numbers in list)
            {
                Console.Write("{0} ", numbers);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
        }
    }
}
