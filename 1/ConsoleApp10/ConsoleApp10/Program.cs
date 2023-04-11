using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method();
            }
            catch (Exception ex) when (Check(ex))
            {
                Console.Write('B');
            }
        }

        static void Method()
        {
            try { throw new Exception(); }
            finally { Console.Write('A'); }
        }

        static bool Check(Exception ex)
        {
            Console.Write("C");
            return true;
        }
    }
}
