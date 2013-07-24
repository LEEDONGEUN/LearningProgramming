using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXG04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dc = new Dictionary<string, string>();

            dc["하나"] = "one";
            dc["둘"] = "two";
            dc["셋"] = "three";
            dc["넷"] = "four";
            dc["다섯"] = "five";

            Console.WriteLine(dc["하나"]);
            Console.WriteLine(dc["둘"]);
            Console.WriteLine(dc["셋"]);
            Console.WriteLine(dc["넷"]); 
            Console.WriteLine(dc["다섯"]);
        }
    }
}
