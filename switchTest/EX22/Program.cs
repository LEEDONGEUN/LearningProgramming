using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX22
{
    class Program
    {
        public void Input(out int n)
        {

            Console.WriteLine();
            Console.Write("몇단을구하고싶습니까?");
            n = int.Parse(Console.ReadLine());
        }

        public void Gugudan(int n)
        {
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {

                Console.Write("{0}*{1}={2}", n, i, n * i);
                Console.WriteLine();

            }

        }
        public static void Main(string[] args)
        {

            int i;
            Program a = new Program();
            a.Input(out i);
            a.Gugudan(i);
        }
    }
}