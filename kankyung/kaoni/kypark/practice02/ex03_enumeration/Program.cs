using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_enumeration
{
    enum Color { Red = 10, Green = 100, Blue = 200 }

    class Program
    {
        static void Main(string[] args)
        {
            Color colorPalette = Color.Red;
            Console.WriteLine(colorPalette);
        }
    }
}