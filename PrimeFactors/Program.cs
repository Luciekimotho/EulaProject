using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            primeFactors(n);
        }

         static void primeFactors(int n)
        {  
            //check if num is divisble by 2
            while (n % 2 == 0)
            {
                //if yes, write as the first prime factor and proceed to divide the number by 2
                Console.Write(2 + " ");
                n /= 2;
            }

            //if the number is odd, or has been divided by 2 to the point where it is odd,
            //Loop through starting from 3 which is the next number, we increment by 2 because the number is odd
            for(int i =3; i <= Math.Sqrt(n); i += 2)
            {
                //if i divides n, print the number and divide n by i
                while(n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            //the number that remains after the divisions
            Console.Write(n);
        }
    }
}
