﻿using System;
using Library;

namespace CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Thing().Get(42)}.");
            Console.WriteLine("Hello World!");
        }
    }
}
