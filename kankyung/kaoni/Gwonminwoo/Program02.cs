using System; // System Library 사용
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hello  // class 이름을 Hello로 정함
{
   
    public static void Main() // Main() Maind 의 method  Main은 entry point(최초로 실행하는 명령이 저장되어있는 어드레스) 
    {
        int a = Console.Read(); // Read는 한글자만 나타낼때 쓰인다 .
        int b = Console.Read();
        Console.WriteLine(a); //a 대해 나타내라
        Console.WriteLine(b);// b 대해 나타내라 
        }
}
//a,b를 넣으면 a-> 97 b->98 인데 그렇게 나타나는 이유는 a의 유니코드 61  b의 유니코드 62(16진수) 10진수로 바꾸면 (97,98)