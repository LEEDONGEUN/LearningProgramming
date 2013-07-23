using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace methodTest
{
    class ExampleClass
    {
        static void ExampleMethod()
        {
            Console.WriteLine("ExampleMethod");
        }
        static void Main(string[] args)
        {
            ExampleClass.ExampleMethod();*/
/* namespace methodTest
{
    class ExampleClass
    {
        static void ExampleMethod(string msg)
        {
            Console.WriteLine("msg");
           
        }
        static void Main(string[] args)
        {
            string msgRead = Console.ReadLine();
            ExampleClass.ExampleMethod(msgRead);

         }*/
// Number+100 :XXXX( string를 int 변환)
/*namespace methodTest
{
    class ExampleClass
    {
        static void ExampleMethod(int number)
        {
            Console.WriteLine("Number + 100:{0}", (number + 100));

        }
        static void Main(string[] args)
        {
            string msgRead = Console.ReadLine();
            //int a = int.parse(msgRead); or
            int a = Convert.ToInt32(msgRead);
            ExampleClass.ExampleMethod(a);
      static void ExampleMethod(int number)
        {
            Console.WriteLine("Number + 100:{0}", (number + 100));

        }
        }*/
//a +b = c
namespace methodTest
{
    class ExampleClass
    {
        static void Add(int a, int b)  //(XX.XX) 파라미터
        {
            int c = a + b;
            Console.WriteLine(" a + b :{0}", c);  // " ㅇㄴㅇ" <==상수 
            //ExampleMethod 를 (a+b결과를 인자로 호출하자)
            AnotherClass.ExampleMethod(c); //다른  class면  호출할때 class 이름까지 써줘야된당 다른 namesapce 
        }
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Add(a, b);
          

        }
        public class AnotherClass   //class 추가   public이면 public  
        {

            public static void ExampleMethod(int number)
            {
                Console.WriteLine("Number + 100:{0}", (number + 100));

            }
        }
    }    
    }


    
     