using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Area_trian
{
    internal class Program
    {
        static double GetPperim(double a, double b, double c)
        {
           return (a + b + c) / 2;
        }
        static double GetS(double a, double b, double c, double p);
        double p = GetPperim(a, b, c);
        {
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катеты 1 треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetS(a1, b1, c1);
            Console.WriteLine("Введите катеты 2 треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetS(a2, b2, c2);

            if (s1 > s2)
                Console.WriteLine("Площадь 1 треуг больше");
            else
                    if (s1 < s2)
                Console.WriteLine("Площадь 2 треуг больше");
            else
                Console.WriteLine("Площади равны");
            Console.ReadKey();
        }
    }
}