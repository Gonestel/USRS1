using System;

namespace USRS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу [кг]");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус планеты [км]");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту [км]");
            double h = Convert.ToDouble(Console.ReadLine());
            double g = 0.0098, s = 2, v;
            v = Math.Sqrt((g * Math.Pow(r, s)) / (r + h));
            Console.WriteLine("Результат = {0} км/с", v);
            Console.ReadKey();

        }
    }
}
