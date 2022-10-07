﻿using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int digits = number;

            while (digits > 0)
            {
                int currentNum = digits % 10;
                if (currentNum % 2 != 0)
                {
                    sum += currentNum;
                }
                digits /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int digits = number;
            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 == 0)
                {
                    sum+= currentDigit;
                }
                digits = digits / 10;
                
            }
            return sum;
        }
    }
}
