using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(args[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception at > {0}", e.StackTrace);
            }
        }
    }
}
