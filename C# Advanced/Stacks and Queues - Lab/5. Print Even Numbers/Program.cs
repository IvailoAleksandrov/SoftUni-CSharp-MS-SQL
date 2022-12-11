﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    queue.Enqueue(numbers[i]);
                }
            }
            
            Console.WriteLine(string.Join(", ", queue));

            //Second Try With LINQ
            //Queue<int> evenNumbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Where(i => i % 2 == 0));
            //Console.WriteLine(string.Join(", ", evenNumbers));
            
        }
    }
}
