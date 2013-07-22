using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuGuDan
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Setting();

            /*for (int j = 2; j < 10; j++)
            {
                Console.WriteLine("\n\n{0}단", j);

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", j, i, st.Gugudan(j, i));
                } 
            }*/ // 나열

            var j = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                if (j < 2 || j >= 10) return;
                Console.WriteLine("{0} X {1} = {2}", j, i, st.Gugudan(j, i));
            } 
        }
    }

    class Setting
    {
        public Setting() { }

        public int Gugudan(int i, int j)
        {
            return i * j;
        }
    }
}
