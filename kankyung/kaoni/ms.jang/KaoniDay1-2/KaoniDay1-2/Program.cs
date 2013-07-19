using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay1_2
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello, c#";

            Console.Write(greeting);

            int a = Console.Read();
            int b = Console.Read();
            int c = Console.Read();
            int d = Console.Read();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);



            string greeting2 = Console.ReadLine();
            string greeting3 = Console.ReadLine();
            string greeting4 = Console.ReadLine();
         

            Console.WriteLine(greeting2);
            Console.WriteLine(greeting3);
            Console.WriteLine(greeting4);
            
            Console.WriteLine("{0}+{1}={2}", 200, 100, 200 + 100);
            Console.WriteLine("{0}+{1}={2}", 100, 400, 100 + 400);

            Console.WriteLine("\"10의 폭을 가지며, 왼쪽정렬:\"{0,-10}", 99);
            Console.WriteLine("\"10의 폭을 가지며, 오른쪽 정렬\":{0,10}", 99);


            Console.WriteLine("\ucc25");
            Console.WriteLine("\ucc11");
            Console.WriteLine("\t\t\t\t\t\ucc10\ucc10\ucc10\ucc10");

            Console.WriteLine(@"\\SharedFolder\download");
        }
    }
}
