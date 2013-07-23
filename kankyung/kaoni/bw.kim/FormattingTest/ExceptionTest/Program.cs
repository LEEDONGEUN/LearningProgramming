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
                //args[0]에 인자값이 들어올 경우 Console.WriteLine()이 실행되므로 try되어 catch문을 실행하지 않는다.
                //args[0]에 인자값이 없을 경우 예외처리인 catch문으로 넘어가게 된다.
                //catch문으로 넘어가 Console.WriteLine()을 수행한다.
                Console.WriteLine(args[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception at > {0}", e.StackTrace);
            }
        }
//결과값 : 
//           위치: ExceptionTest.Program.Main(String[] args) 파일 d:\hk\LearningProgrammin
//g\kankyung\kaoni\bw.kim\FormattingTest\ExceptionTest\Program.cs:줄 15

    }
}
