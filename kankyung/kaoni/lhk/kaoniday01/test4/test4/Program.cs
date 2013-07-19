using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", 200, 250, 200+250, 200+250+200+250);
            Console.WriteLine("{3} - {2} - {1} = {0}", 200, 250, 200 + 250, 200 + 250 + 200 + 250);
            Console.WriteLine("\\10의 폭을 가지며, 왼쪽 정렬:\\{0,-10}", 11);
            Console.WriteLine("\t10의 폭을 가지며, 왼쪽 정렬:\t{0,-10}", 11);
            Console.WriteLine("\\10의 폭을 가지며, 오른쪽 정렬\\:{0,10}", 22);
            Console.WriteLine("\t10의 폭을 가지며, 오른쪽 정렬\t:{0,10}", 22);
            Console.WriteLine(@"\\Share Folder\\download");
            Console.WriteLine("@\tShare Folder\tdownload");
            Console.WriteLine("@\u0060Share Folder\u0060download");
        }
    }
}