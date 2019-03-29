using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Method declaration static void (no return) with
        /// the signature CountToN. The body contains a
        /// for loop that counts from 1 to n times.
        /// </summary>
        /// <param name="n"> variable of type intenger</param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        /// <summary>
        /// Method Overload of method CountToN with 2 arguments
        /// </summary>
        /// <param name="n1"> argument 1 of type int </param>
        /// <param name="n2">agurment 2 of type int </param>
        static void CountToN(int n1, int n2)
        {
            for (; n1 < n2; n1++)
            {
                Console.WriteLine(n1);
            }
        }

        /// <summary>
        /// Method declaration static void (no arguments and no return) 
        /// with the CountTo10 signature. The body contains Method CountToN
        /// (with the given value of 10 thats assigned to variable `n`)
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }
         
        /// <summary>
        /// Main method of the main program. The declaration is static void
        /// (no return) with the signature Main containing 1 argument
        /// (string [] args).
        /// The body contains the method CountToN 2 times and CountTo10
        /// </summary>
        /// <param name="args"></param>
    static void Main(string[] args)
        {
            CountToN(4);
            CountToN(2);
            CountToN(1, 3);
            CountTo10();
        }
    }
}
