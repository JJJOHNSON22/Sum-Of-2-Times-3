﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassSumOf2Times3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1 is: ");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 2 is: ");
            int b1 = Convert.ToInt32(Console.ReadLine());

            //if the first number is equal to the second number than the sum of those two numbers will be multiplied by three
            if (a1 == b1)
            {
                Console.WriteLine($"({a1} + {b1}) * 3 = {(a1 + b1) * 3}");
            }
            else
            {
                Console.WriteLine($"{a1} + {b1} = {a1 + b1}");
            }
        }
    }
}
