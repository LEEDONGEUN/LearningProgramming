using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVS
{
    class Hello
    {
        public static int month = 7;

        static void Main()
        {
     
            Console.WriteLine("입력하는 문장입니다.");
            Console.WriteLine(month);


            Console.WriteLine("================================================================================");


            Console.WriteLine("아무글이나 입력하세요");

            string th = Console.ReadLine();
            Console.WriteLine(th + "   이란 글자를 입력하셨군요");
            Console.WriteLine();
            Console.WriteLine("아무글이나 입력하세요 아스키코드로 표시될겁니다.");
            string tt = Console.Read().ToString();
            Console.WriteLine(tt);

            Console.WriteLine("================================================================================");

            Console.WriteLine("문자열");
            Console.WriteLine("{ 괄호를 포함한 문자열}");
            Console.WriteLine("{0}", 1);
            Console.WriteLine("{0}+{1} = {2}", 100, 130, 200 + 130);
            Console.WriteLine("{0}+{1} = {2}", 100, 130, 400 + 130);
            Console.WriteLine("{0}+{1} = {2}", 100, 130, 400);
            Console.WriteLine("{0}+{1}+{2}", 100, 130, 200 + 130);
            Console.WriteLine("\"10의 폭을 가지며, 왼쪽 정렬 :\"{0,-10}", 55);
            Console.WriteLine("\"10의 폭을 가지며, 왼쪽 정렬 :\"{0,10}", 55);
            Console.WriteLine("10의 폭을 가지며, 오른쪽 정렬 :{0,-10}", 99);
            Console.WriteLine("\"10의 폭을 가지며, 오른쪽 정렬\":{0,10}", 99);
            Console.WriteLine(@"\\Shared Folder\download");
            Console.WriteLine("\\Shared Folder\\download");

        }
    }
}
