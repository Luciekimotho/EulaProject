using System;

//A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int i, j = 0;
            //Console.Write(reverseNumber(347));

            for (i = 999; i >= 100; i--)
            {
                for (j = 999; j >= 100; j--)
                {
                 
                   if (i * j == reverseNumber(i * j) && (i*j > max))
                    {
                        max = i * j;
                        //Console.Write("\n");
                        //Console.Write(i + " ");
                        //Console.Write(j + " ");
                    }

                   
                }
            }
            
            Console.Write("\n");
            Console.Write(max);
            Console.Write("\n");

        }

        static int reverseNumber(int original)
        {
            int reverse = 0;
            while(original > 0)
            {
                reverse = (reverse * 10) + original % 10;
                original = original / 10;
            }
            //Console.Write(reverse);
            return reverse;
        }
    }
}
