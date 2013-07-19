using System; // System Library 사용
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hello  // class 이름을 Hello로 정함
{
    public static int month = 7;
    public static void Main() // Main() Maind 의 method  Main은 entry point(최초로 실행하는 명령이 저장되어있는 어드레스) 
    {
        Console.WriteLine("Hello, world"); //Console class의 WriteLine method "" 직접 나타내라
        Console.WriteLine(month); // month 에 해당한것을 나타내라 
    }
}
