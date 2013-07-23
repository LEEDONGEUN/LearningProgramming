using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY04
{
    class Program
    {
        static long AddList(params long[] v)
           
        {
            
            long total ,i;
            for ( i = 0, total = 0; i < v.Length; i++) ;
            total += v[i];
            return total;
            }
        static void Main()
        {
            long x = AddList(63, 21, 84);
        }
    }


}
