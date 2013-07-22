using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_Types
{
    class Program
    {
        enum Color { Red, Green , Blue }

        static void Main(string[] args)
        {
            
            Color colorPalette = Color.Red;
            Console.WriteLine(colorPalette);
            Color colorPalette1 = Color.Green;
            Console.WriteLine( colorPalette1);
            Color colorPalette2 = Color.Blue;
            Console.WriteLine(colorPalette2);
            
        }

    }
}
