﻿using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').Where(x => x.Length % 2 == 0).ToArray();
            foreach (var word in array)
            {
                Console.WriteLine(word);
            }

        }
    }
}
