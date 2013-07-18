using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace KaoniDay01
{
    class Program
    {
        public static int month = 7;
        public static void Main()
        {
            Console.WriteLine(month);
            Console.WriteLine("Hello, World");
            Console.Write(month);
            Console.Write("Hello");
        }
    }
}
*/
/*
namespace HelloVS
{
    class Hello
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0}+{1}+{2}", 100, 130, 100 + 130);
            Console.WriteLine("\ucc28 10의 폭을 가지며, 왼쪽정렬:\"{0,-10}", 99);
            Console.WriteLine("\t\t10의 폭을 가지며, 오른쪽정렬\":{0, 10}", 99);
            Console.WriteLine(@"\\Shared Folder\download");
        }
    }
}
*/
/*
class Program
{
    static void Main()
    {
        int result;
        while ((result = Console.Read()) != 0)
        {
            Console.WriteLine("{0} = {1}", result, (char)result);
        }
    }
}
*/

class Program
{
    public static int a;
    public static int b;
    public static void Main()
    {
        a = Console.Read();
        b = Console.Read();
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}