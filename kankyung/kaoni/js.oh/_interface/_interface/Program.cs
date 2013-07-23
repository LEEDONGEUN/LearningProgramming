using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _interface
{
    class Program
    {
        static mListControl control = new mListControl();

        static void Main(string[] args)
        {

            bool Flag = true;

            while (Flag) 
            {
                Console.WriteLine("0. 종료");
                Console.WriteLine("1. 학생 정보 입력");
                Console.WriteLine("2. 학생 모두 출력");
                Console.WriteLine("3. 학생 모두 삭제");
                Console.WriteLine("4. 학번으로 학생 찾기");

                switch(Console.ReadLine())
                {
                    case "0":
                        Flag = false;
                        break;
                    case "1":
                        Student_Insert();
                        break;
                    case "2":
                        Student_AllPrint();
                        break;
                    case "3":
                        Student_AllClear();
                        break;
                    case "4":
                        Student_OnePrint();
                        break;
                }
            }
            
            
        }

        static void Student_Insert()
        {
            Console.WriteLine("이름, 학번 입력");
            control.insertData(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
        }

        static void Student_AllPrint() 
        {
            for (int i = 0; i < control.getStudentCount(); i++)
            {
                Console.WriteLine(control.selectData(i));
            }
        }

        static void Student_OnePrint()
        {
            Console.WriteLine(control.selectData_OneStudent(Int32.Parse(Console.ReadLine())));
        }

        static void Student_AllClear()
        {
            control.clearData();
        }
    }
}
