using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, count = 0;

            while (true)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                    count++;

                    if (count == 1000)
                    {
                        break;
                    }
                }
                i++;

            }
            Console.ReadLine();
        }

        static bool isPrime(int num)
        {
            int i = 2;

            while (i <= num / 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
                i++;
            }

            return true;
        }
    }
}
