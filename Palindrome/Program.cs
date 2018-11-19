using System;

//A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(reverseNumber(347));

            for (int i = 99;i >= 0; i--)
            {
                for (int j = 99; j >= 0; j--)
                {
                    if( i*j == reverseNumber(i * j))
                    {
                       // Console.Write(i);
                        //Console.Write(j);
                    }
                }
            }
        }

        static int reverseNumber(int original)
        {
            int reverse = 0;
            while(original > 0)
            {
                reverse = (reverse * 10) + original % 10;
                original = original / 10;
            }
            Console.Write(reverse);
            return reverse;
        }
    }
}
