using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            long longValue = Int64.MaxValue;
            int intValue = (int )longValue;
            Console.WriteLine("(int) {0} ={1}", longValue, intValue);

        }
    }
}
