using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay03
{
    class Gugudan
    {
        static void Main(string[] args)
        {
            int dan;
            Console.Write("당신이 원하는 단은? ");
            dan = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan*i);
            }
            
        }
    }
}
