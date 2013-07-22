using System;

namespace KaoniDay03
{
    class Program
    {
        static void Main(string[] args)
        {
            double dd = 12.68;
            int dr = (int)dd; // 내림
            int dv = Convert.ToInt32(dd); // 반올림

            Console.WriteLine("{0}, {1}", dr, dv);

            var l = new LoopTest();
            //l.Setting();

            var read = Console.ReadLine();

            Console.WriteLine(l.MudStr());
            Console.WriteLine(l.PropertiesStr);
            Console.WriteLine(l.MudStr(read));

            var readInt = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}, {1}", readInt, l.MudStr(DateTime.Now.Millisecond));

            var r1 = int.Parse(Console.ReadLine());
            var r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", r1, r2, l.Add(r1, r2));
        }
    }

    class LoopTest
    {
        public LoopTest() { }

        public void Setting()
        {
            do
            {
                Console.WriteLine("EEEE"); 
                // break;
            }
            while (true);

            /*
            for (; ; )
            {
                Console.WriteLine("EEEE");
                // break;
            }
            */
        }

        public string MudStr()
        {
            return @"문자열 반환 메서드";
        }

        public string MudStr(string msg) // 오버로드
        {
            return msg;
        }

        public string MudStr(int num) 
        {
            return num.ToString();
        }

        public int Add(int a, int b)
        {
            Console.WriteLine("set {0}", MudStr(a + b));
            return a + b;
        }

        public string PropertiesStr
        {
            get
            {
                return @"프로퍼티";
            }
        }
    }
}
