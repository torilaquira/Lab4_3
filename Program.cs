using System;

namespace Lab4_3
{
    class PrimeNumbers
    {

    }
    class Program
    {
        static public bool IsPrime(int num)
        {
            if (num<=1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i=3; i<=num; i+=2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }


            static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!");
            Console.WriteLine("Which prime number are you looking for?: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(num));
        }
    }
}
