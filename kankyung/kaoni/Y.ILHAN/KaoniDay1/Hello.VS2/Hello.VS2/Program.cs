using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.VS2
{
    class Hello2

    {
        public static int month = 6;

        static void Main()
        
        {
         String greeting = "Hello.World";
         Console.WriteLine(greeting);
         Console.WriteLine(month.ToString());

         int a = Console.Read();
         int b = Console.Read();
         int c = Console.Read();
         int d = Console.Read();
         Console.WriteLine(a);
         Console.WriteLine(b);
         Console.WriteLine(c);
         Console.WriteLine(d);
         String only1 = Console.ReadLine();
         String only2 = Console.ReadLine();
         String only3 = Console.ReadLine();
         String only4 = Console.ReadLine();
         Console.WriteLine(only1);
         Console.WriteLine(only2);
         Console.WriteLine(only3);
         Console.WriteLine(only4);

         Console.WriteLine("{0}+{1}={2}", 555, 777, 555 + 777);
         Console.WriteLine("\"10의폭을 가지며,왼쪽정렬:\"{0,-5}", 99);
         Console.WriteLine("\t\t\t\"10의폭을 가지며,오른쪽정렬\":{0,7}", 99);
         Console.WriteLine(@"\\SharedFolder\download");



        
        }
    }
}
