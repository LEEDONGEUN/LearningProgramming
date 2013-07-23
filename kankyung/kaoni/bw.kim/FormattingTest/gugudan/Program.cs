using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gugudan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("몇 단이 알고 싶으신지 입력하세요(1~9) :  ");
            int value = int.Parse(Console.ReadLine());
            for(int i = 0 ; i < 9; i++ )
            {
                Console.WriteLine("{0} * {1}  :  {2}", value, (i+1), (value * (i + 1)));
            }
        }
    }
}
