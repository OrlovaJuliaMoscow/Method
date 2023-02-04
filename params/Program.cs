using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int S = CalcSum(ref a, b);
        Console.WriteLine(S);
            Console.ReadKey();
        }

    static void CalcSum(params int[] numbers)
    {
        int S = 0;
            foreach (int i in numbers)
                S += n;
            Console.WriteLine(S);
        }
}
