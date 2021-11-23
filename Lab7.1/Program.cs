using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника:");
            Console.WriteLine("Введите длину первой стороны треугольника:");
            double triangle1A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны треугольника:");
            double triangle1B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны треугольника:");
            double triangle1C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника:");
            Console.WriteLine("Введите длину первой стороны треугольника:");
            double triangle2A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны треугольника:");
            double triangle2B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны треугольника:");
            double triangle2C = Convert.ToInt32(Console.ReadLine());
            int numBigger = WhichTriangleIsBigger(triangle1A, triangle1B, triangle1C, triangle2A, triangle2B, triangle2C);
            Console.WriteLine("Больше площадь треугольника № {0}", numBigger);
            Console.ReadKey();
        }
        static int WhichTriangleIsBigger(double firstA, double firstB, double firstC, double secondA, double secondB, double secondC)
        {
            int num = 0;
            double first_halfPerimeter = (firstA + firstB + firstC) / 2;
            double second_halfPerimeter = (secondA + secondB + secondC) / 2;
            Console.WriteLine("Полупериметр первого: {0}", first_halfPerimeter);
            double first_area = Math.Sqrt(first_halfPerimeter * (first_halfPerimeter - firstA) * (first_halfPerimeter - firstB) * (first_halfPerimeter - firstC));
            double second_area = Math.Sqrt(second_halfPerimeter * (second_halfPerimeter - secondA) * (second_halfPerimeter - secondB) * (second_halfPerimeter - secondC));
            Console.WriteLine("Площадь первого треугольника: {0}", first_area);
            Console.WriteLine("Площадь второго треугольника: {0}", second_area);
            if (first_area > second_area)
            {
                num = 1;
            }
            else
            {
                num = 2;
            }
            return num;

        }
    }
}
