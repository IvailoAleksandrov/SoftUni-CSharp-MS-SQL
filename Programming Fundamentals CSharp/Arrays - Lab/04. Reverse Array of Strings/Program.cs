﻿using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        private const string V = " ";

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Array.Reverse(input);

            Console.WriteLine(String.Join(" ",input));   

        }
    }
}
