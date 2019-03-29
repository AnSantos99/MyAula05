using System;

namespace MyFirstMethod
{
    class Program
    {
        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
         
    static void Main(string[] args)
        {
            for (int j = 0; j < 2; j++)
            {
                CountTo10();
            }
        }
    }
}
