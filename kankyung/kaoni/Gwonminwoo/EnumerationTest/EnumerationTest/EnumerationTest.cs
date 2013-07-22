using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTest
{
    class Program
    {
        enum Color { Red=10, Green=100, Blue=200 }
        static void Main(string[] args)
        {
            
            Color colorPalette= Color.Red;
            Console.WriteLine("{0}", colorPalette); //display Red
        }
    }
}
