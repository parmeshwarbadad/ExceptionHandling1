using System;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two num");
                int n1 = int.Parse (Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Division "+(n1/n2));
                Console.WriteLine("try ends");
            }
            catch(FormatException e)
            {
                Console.WriteLine("In a catch 2");
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("in a catch 1");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine("In a catch 3");
                Console.WriteLine(e.Message);
            }
        }
    }
}
