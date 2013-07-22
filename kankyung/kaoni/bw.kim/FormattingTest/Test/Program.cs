using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main()
        {
            long longValue = Int64.MaxValue;
//            int intValue = longValue; // 오류!
            int intValue = (int) longValue;
            Console.WriteLine("(int) {0} = {1}", longValue, intValue);
        }
    }
}