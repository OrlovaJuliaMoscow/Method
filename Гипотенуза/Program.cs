using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гипотенуза
{
    internal class Program
    {
        static double GetHypotenuse(double a, double b)
        {
        return Math.Sqrt(a* a + b* b);
        }
    static void Main(string[] args)
        {
        Console.WriteLine("Введите катеты 1 треугольника");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double z1 = GetHypotenuse(x1, y1);
        Console.WriteLine("Введите катеты 2 треугольника");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        double z2 = GetHypotenuse(x2, y2);

        if (z1 > z2)
            Console.WriteLine("Гипотенуза 1 треуг больше");
        else 
                if(z1 < z2)
            Console.WriteLine("Гипотенуза 2 треуг больше");
        else
            Console.WriteLine("Гипотенузы равны");
        Console.ReadKey();
         }
    }
}
