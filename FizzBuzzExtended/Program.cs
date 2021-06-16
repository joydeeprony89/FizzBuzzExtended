using System;

namespace FizzBuzzExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100000;
            FizzBuzz(n);
        }

        static void FizzBuzz(int n)
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            for (int i = 1; i <= n; i++)
                Console.WriteLine(fizzBuzzer.HandleNumber(i));
        }
    }
}
