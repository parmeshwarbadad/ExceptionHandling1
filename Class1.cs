using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling1
{
    class Class1
    {
        public static void m1(int a,int b)
        {
            Console.WriteLine("m1 starts");
            Console.WriteLine("Division "+(a/b));
            Console.WriteLine("main ends");
        }
        public static void m2(int x, int y)
        {
            Console.WriteLine("in m2 start");
            m1(x, y);
            Console.WriteLine("in m2 ends");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            try
            {
                m2(10, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message );
            }
            Console.WriteLine("main ends");
        }
    }
}
