using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_Периметр_треуг_из_сторон
{
    internal class Program
    {
        static double GetParamsTriangle(double a, double b, double c)
        {
            return Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катеты 1 треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetParamsTriangle(a1, b1, c1);
            Console.WriteLine("Введите катеты 2 треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetParamsTriangle(a2, b2, c2);

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
