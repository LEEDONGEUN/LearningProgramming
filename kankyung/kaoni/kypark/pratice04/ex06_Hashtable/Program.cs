using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex06_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1~5 숫자를 입력하세요, 그만할려면 Quit 치셈");
            Hashtable ht = new Hashtable();
            ht["1"] = "one";
            ht["2"] = "two";
            ht["3"] = "three";
            ht["4"] = "four";
            ht["5"] = "five";
            for (int i = 0; i >= 0; i++)
            {
                string str = Console.ReadLine();
                if (str == "1" || str == "2" || str == "3" || str == "4" || str == "5")
                {
                    Console.Write("입력한 숫자 : " + ht[str]);
                    Console.WriteLine();
                }
                else if (str == "Quit")
                {
                    i = -2;
                }
                else
                {
                    Console.WriteLine("1~5 숫자를 입력하세용");
                }
            }
        }
    }
}
