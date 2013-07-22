using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTest
{
    enum Suit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }

    class Program
    {
        static void Main(string[] args)
        {
            Suit trumps = Suit.Hearts;
            String color;
            switch (trumps)
            {
                case Suit.Clubs:
                case Suit.Spades:
                    color = "Black";
                    break;
                case Suit.Hearts:
                case Suit.Diamonds:
                    color = "Red";
                    break;
                default:
                    color = "ERROR";
                    break;
            }
            Console.WriteLine(color);

        }
    }
}
