using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int intvalue = 123;
            //long longvalue = intvalue;
            //Console.WriteLine("(long) {0} = {1}", intvalue, longvalue);
            long longvalue = Int64.MaxValue;
            int intvalue = (int)longvalue;
            Console.WriteLine("(int) {0} = {1}", longvalue, intvalue);
            //try
            //{

            //}
            //catch (Exception e)
            //{

            //    throw;
            //}
            //finally
            //{

            //}
        }
    }
}
