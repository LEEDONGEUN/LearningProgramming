using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay02
{
    /// <summary>
    /// 직원등록 클래스
    /// </summary>
    class Program
    {
        /// <summary>
        /// 직원정보
        /// </summary>
        public struct employee
        {
            public string Name;
            public string age;
            public string address;
            public string sex;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("가온아이 2번째 실습");
            Console.WriteLine("Module 3. Using Value Type Variables\n");

            employee CompanyEmp;          

            //직원등록
            Console.WriteLine("직원 등록");
            Console.WriteLine("---------");
            Console.Write("이 름 : ");
            CompanyEmp.Name = Console.ReadLine();
            Console.Write("나 이 : ");
            CompanyEmp.age = Console.ReadLine();
            Console.Write("주 소 : ");
            CompanyEmp.address = Console.ReadLine();
            Console.Write("성 별 : ");
            CompanyEmp.sex = Console.ReadLine();
            Console.WriteLine();

            //등록한 직원 출력
            Console.Write("{0:yyyy년 M월 d일 dddd tt hh시 mm분}", DateTime.Now);
            Console.WriteLine("에 " + CompanyEmp.address + "에 사는 " + CompanyEmp.age + "살 " + CompanyEmp.Name + "님께서 등록하셨습니다.\n");
            
            
        }
    }
}
