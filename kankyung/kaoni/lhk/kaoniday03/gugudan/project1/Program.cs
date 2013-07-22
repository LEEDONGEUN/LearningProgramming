using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dan, result;

            Console.WriteLine("당신이 원하는 단은? :");
            dan = int.Parse(Console.ReadLine());

            if (dan == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 2; j <= 9; j++)
                    {
                        result = j * i;
                        Console.WriteLine("{0} * {1} = {2}\t", j, i, result);
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                for (int i = 1; i <= 9; i++)
                {
                    result = dan * i;
                    Console.WriteLine("{0} * {1} = {2}", dan, i, result);
                }
            }
        }
    }
}
