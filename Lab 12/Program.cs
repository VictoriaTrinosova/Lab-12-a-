using System;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Сircle.Lenght();
            Сircle.Area();
            Сircle.Сoordinates();
            Console.ReadKey();

        }
        public static class Сircle
        {
            public static int r = 8;
            public static int x = 12;
            public static int y = 2;
            public static int x_0 = 0;
            public static int y_0 = 0;
            public static double l;
            public static double p;

            public static void Lenght()
            {
                l = 2 * Math.PI * (double)r;
                Console.WriteLine("Длина окружности равна: {0}", Math.Round(l, 2));

            }
            public static void Area()
            {
                p =Math.PI * (double)r* (double)r;
                Console.WriteLine("Площадь окружности равна: {0}", Math.Round(p, 2));

            }
            public static void Сoordinates()
            {
                if ((x_0 + x) < r&& (y_0 + y) < r)
                {
                    Console.WriteLine("Точка принадлежит заданной окружности");
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит заданной окружности");
                }


            }
        }
    }
}
