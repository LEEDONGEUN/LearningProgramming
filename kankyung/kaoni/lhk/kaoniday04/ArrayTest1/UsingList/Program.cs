using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8] {80, 77, 65, 90, 57, 32, 99, 50};

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;

            foreach (int score in scores)
                sum = sum + score;

            int average = sum / scores.Length;

            Console.WriteLine("Average Score :{0}", average);
        }
    }
}
