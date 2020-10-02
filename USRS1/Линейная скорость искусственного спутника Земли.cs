using System;

namespace USRS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу [кг]");
            string mass = Console.ReadLine();
            double m = Convert.ToDouble(mass);
            Console.WriteLine("Введите радиус планеты [км]");
            string rad = Console.ReadLine();
            double r = Convert.ToDouble(rad);
            Console.WriteLine("Введите высоту [км]");
            string heig = Console.ReadLine();
            double h = Convert.ToDouble(heig);
            double g = 0.0098, s = 2, v;
            v = Math.Sqrt((g * Math.Pow(r, s)) / (r + h));
            Console.WriteLine("Результат = {0} км/с", v);
            Console.ReadLine();

        }
    }
}
