using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUGUDAN
{
    class Program
    {
        // static void Main(string[] args)
        //{
        //Console.WriteLine("\t구구단 출력하기");
        //Console.WriteLine();
        //for (int t = 1; t < 10; t =+3)
        //{
        //   for (int i = 1; i < 10; i++)
        //    {
        //        for (int j = t; j < (t + 3); j++)
        //            Console.WriteLine("{0} * {1} = {2}\t", j, 1, i * j);
        //        Console.WriteLine();
        //    }
        //   Console.WriteLine();
        //}
        //Console.WriteLine();


        //int a, b;
        //for (a = 1; a < 10; a++)
        //{
        //    for (b = 1; b < 10; b++)
        //    {
        //        Console.WriteLine("{0} * {1} = {2} \t", a, b, a * b);
        //    }
        //}


        public static void Gugudan(int dan)
        {

            Console.WriteLine("\n{0}단입니다.", dan);
            for (int i = 1; i < 10; i++)
            {
                int result = dan * i;
                Console.WriteLine("{0}*{1}={2}", dan, i, result);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            int dan;
            while (true)
            {
                Console.WriteLine("출력할 단을 입력):");
                dan = int.Parse(Console.ReadLine());
                if (dan > 0 && dan < 10)
                {
                    Gugudan(dan);
                }

            }
        }
    }
}

