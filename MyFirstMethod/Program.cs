using System;

namespace MyFirstMethod
{
    class Program
    {
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }
        static void CountTo10()
        {
            CountToN(10);
        }
         
    static void Main(string[] args)
        {
            CountToN(4);
            CountToN(2);
            CountTo10();
        }
    }
}
