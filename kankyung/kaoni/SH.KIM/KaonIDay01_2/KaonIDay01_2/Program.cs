using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaonIDay01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" {0} * {1} / {2} = {3} ", 100, 200, 300, 100 * 200 / 300);
            Console.WriteLine("\" 17의 폭을 가지며 왼쪽정렬 : \" {0,-17}", 999);
            Console.WriteLine("\" 17의 폭을 가지며 오른쪽정렬 \":{0,17}", 777);
            Console.WriteLine(@"\\Shared Folder\download");
            Console.WriteLine("\\Shared Folder\\download");
        }
    }
}
