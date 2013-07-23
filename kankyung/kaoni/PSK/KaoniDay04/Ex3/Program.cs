using System;
using Stack = System.Collections.Stack;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            while (st.Count > 0)
            {
                Console.Write("{0} ", st.Pop());
            }
            Console.WriteLine("\n\n");

            GenStack.Start();
        }
    }

    static class GenStack
    {
        public static void Start()
        {
            var st = new Stack<int>();

            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            while (st.Count > 0)
            {
                Console.Write("{0} ", st.Pop());
            }
        }
    }
}
