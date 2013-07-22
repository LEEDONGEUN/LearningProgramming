using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_22_homework
{
    class Program
    {

        static void Main(string[] args)
        {
           Console.WriteLine("입력할 단을 입력 : ");
           
           int dan = int.Parse(Console.ReadLine());

           if (dan == 0)
           {
               for (int i = 1; i <= 9; i++)
               {
                   for (int j = 1; j <= 9; j++)
                   {
                       int result = i * j;
                       Console.WriteLine("{0} * {1} = {2}", i, j, result);
                   }

                   Console.WriteLine();
               }
           }
           else
           {
               for (int i = 0; i <= 9; i++)
               {
                   int result = dan * i;

                   Console.WriteLine("{0} * {1} = {2} ", dan, i, result);
               }

           }

        }
    }
}
