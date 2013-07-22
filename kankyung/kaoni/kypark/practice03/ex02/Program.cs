using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    enum Suit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds,
        Joker
    }
    class Program
    {
        static void Main(string[] args)
        {
            Suit trumps = Suit.Hearts;
            string color;
            switch (trumps)
            {
                case Suit.Clubs:
                case Suit.Hearts:
                    color = "Black";
                    break;
                case Suit.Spades:
                case Suit.Diamonds:
                    color = "Red";
                    break;
                default:
                    color = "Error";
                    break;
            }
            Console.WriteLine(color);
        }
    }
}
