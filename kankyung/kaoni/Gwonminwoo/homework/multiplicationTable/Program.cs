using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("당신이 원하는 단은?");
            string Dan = Console.ReadLine(); 

                   {
                    int Y = int.Parse(Dan);
                    for (int i = 1; i <= 9; ++i)
                    {
                        if (int.Parse(Dan) < 10 || int.Parse(Dan) > 1)
                            return;
                        Console.WriteLine("{0} X {1} = {2}", Y, i, Y * i);
                    }
                }
                
        }
    }

}