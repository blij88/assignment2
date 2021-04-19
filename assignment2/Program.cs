using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci to the tenth number
            BasicFibonacci(int.MaxValue);


            Console.ReadLine();
        }

        private static void BasicFibonacci(int sequenceLength)
        {
            long a = 0;
            long b = 1;
            Console.WriteLine($"{a}\n{b}");
            for (int i = 0; i < sequenceLength; i++)
            {
                long c = a + b;
                if (c < 0)
                {
                    Console.WriteLine(i+1);
                    break;
                }
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

    }
}
