using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?

namespace Primenumbers
{    
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10;
            bool[] is_prime = MakeSieve(max);
            for(int i = 2; i < max; i++)
                if(is_prime[i])
                    Console.Write("{0}\t", i);
        }

        static bool[] MakeSieve(int max)
        {

            //An array indicating whether numbers are prime
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++)
                //Initially make all numbers as prime
                is_prime[i] = true;

            //Cross out multiples
            for (int i = 2; i <= max; i++)
            {
                if (is_prime[i])
                {
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }
    }
}
