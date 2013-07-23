using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_22_03
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //정상적인코드
            }
            catch (Exception)
            {

                throw; //에러가나면 여기서 잡는다.
            }
            finally
            {
                //catch 까지 수행 하고 수행 안한것 들을 수행 
            }
         
           


        }
    }
}
