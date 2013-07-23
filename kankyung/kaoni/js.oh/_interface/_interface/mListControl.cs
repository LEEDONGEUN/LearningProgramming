using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _interface
{
    class mListControl
    {
        private List<Student> StuentList;

        public struct Student
        {
            public String name;
            public int number;
        }

        public mListControl()
        {
            this.StuentList = new List<Student>();
        }

        // 입력된 구조체 List Add
        public bool insertData(String StuentName, int StudentNumber)
        {
            try
            {
                Student student = new Student();
                student.name = StuentName;
                student.number = StudentNumber;

                StuentList.Add(student);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        // 입력된 학생 수 return
        public int getStudentCount()
        {
            return StuentList.Count;
        }

        // String Format으로 이름, 학번 return
        public String selectData(int count)
        {
            return "이름 : " + StuentList[count].name + ", 학번 : " + StuentList[count].number;
        }

        // String Format으로 이름, 학번 return
        public String selectData_OneStudent(int number)
        {
            int count = 0;

            for(int i =0;i<StuentList.Count;i++)
            {
                if (StuentList[i].number == number)
                {
                    count = i;
                    break;
                }
            }
            
            return "이름 : " + StuentList[count].name + ", 학번 : " + StuentList[count].number;
        }

        // 학생 정보 모두 삭제
        public bool clearData()
        {
            try
            {
                StuentList.Clear();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
    }
}