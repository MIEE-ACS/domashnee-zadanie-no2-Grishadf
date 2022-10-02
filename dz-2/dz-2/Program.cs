using System;

namespace dz_2
{
    class Program
    {

        static double seg1(double x)
        {
            return 2;
        }

        static double seg2(double x)
        {
            return 0.25 * x + 0.5;
        }

        static double seg3(double x, double r)
        {
            double y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x + r, 2)) + r; //Центр окружности в (-r; r)
            return y;
        }

        static double seg4(double x, double r)
        {
            double y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2));
            return y;
        }

        static double seg5(double x)
        {
            return 2 - x;
        }

        static void Main(string[] args)
        {
            Console.Write("Таблица значений функции от аргумента:\n");

            for (double x = -7; x <= 3; x += 0.2)
            {
                if (x < -7)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if ((x >= -7) && (x < -5.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg1(x));
                }
                if ((x > -6.1) && (x <= -1.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg2(x));
                }
                if ((x >= -2.1) && (x < -0.1))
                {

                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg3(x, 2));

                }
                if ((x > 0.1) && (x <= 1.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg4(x, 2));
                }
                if ((x > 2.1) && (x < 2.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg5(x));
                }
            }
            double r;
            Console.Write("Введите радиус: ");
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.Write("Введите радиус в численном виде:");
            }


            if (r < 2) r = 0;


            while (true)
            {
                Console.Write("Введите значение 'x': ");
                double x;
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Введите аргумент функции в численном виде:");
                }

                if (x < -7)
                {
                    Console.WriteLine("Функция не определена");
                }

                if (x == -6)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg1(x));
                }

                else if (x < -6)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg1(x));
                }
                else if (x < -2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg2(x));
                }
                else if (x < 0)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg3(x, r));
                }
                else if (x < 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg4(x, r));
                }

                else if (x <= 3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, seg5(x));
                }
                else
                {
                    Console.WriteLine("Функция не определена");
                }

            }
        }
    }
}

