﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int S = CalcSum(a, b);
            Console.WriteLine(S);
            Console.ReadKey();
        }

        static int CalcSum(int a, int b)
        {
            int S = a + b;
            return S;
        }
    }
}
