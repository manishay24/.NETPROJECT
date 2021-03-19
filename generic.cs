﻿
using System;
using System.Collections.Generic;

namespace GenericApp
{
    class Program
    {
        //Generic method  
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {  
            int a = 40, b = 60;
            Console.WriteLine("Before swap: {0}, {1}", a, b);

            Swap<int>(ref a, ref b);

            Console.WriteLine("After swap: {0}, {1}", a, b);

            Console.ReadLine();
        }
    }
}

