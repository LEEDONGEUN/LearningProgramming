using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_Types
{
    class Program
    {
        enum Color { Red = 10 , Green = 100, Blue = 200}

        static void Main(string[] args)
        {
            
            Color colorPalette = Color.Red;
            Console.WriteLine(colorPalette);
            //Color colorPalette1 = Color.Green;
            //Console.WriteLine("{1}", colorPalette1);
            
        }

    }
}
