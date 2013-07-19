using System;
using MessageBox = System.Windows.Forms.MessageBox; // Reference 추가.. System.Windows.Forms 에서 MessageBox만을 사용..

namespace ExceptionEx
{
    class Program
    {
        /// <summary>
        /// 기본 메인
        /// </summary>
        /// <param name="args">
        /// 기본 인자
        /// </param>
        static void Main(string[] args)
        {
            //Console.WriteLine("{0}", args[0]);
            try
            {
                Console.WriteLine("{0}", args[0]);
            }
            catch (IndexOutOfRangeException e) // 딱히.. JAVA와는 다르게, 별개의 Exception 클래스와 관련해서 e 나 ex와 같은 변수를 사용 하지 않으면.. 궂이 구현하지 않아도 됨.. 이는 C/C++와 같은 네이티브 코드 에서도 그대로 적용 됨. 
            {
                MessageBox.Show(string.Format(@"에러~~  {0, 10}", e));
            }
            catch (NullReferenceException)
            {
                // works
            }
        }
    }
}
