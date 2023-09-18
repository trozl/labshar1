using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labshar1
{
    class SecondNum
    {
        private double x1, x2, y1, y2, x3, y3;
        private double s, r;
        private double line1, line2, line3;
        public void InputTrianglePoints()
        {
            Console.WriteLine("Введите коорданаты 1 точки:");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коорданаты 2 точки:");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коорданаты 3 точки:");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());

        }
        public void CalculateInnerCircleRadius()
        {
            s = 1 / 2 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1)*(y2 - y1));
            line1 = Math.Sqrt((Math.Pow((x1 - x2), 2)) + Math.Pow((y1 - y2), 2));
            line2 = Math.Sqrt((Math.Pow((x3 - x2), 2)) + Math.Pow((y3 - y2), 2));
            line3 = Math.Sqrt((Math.Pow((x1 - x3), 2)) + Math.Pow((y1 - y3), 2));
            r = (2 * s) / (line1 + line2 + line3);
        }
        public void ShowCalculate()
        {
            Console.WriteLine($"При коорданатах\nx1 = {x1} y1 = {y1}\n x2 = {x2} y2 = {y2}\n x3 = {x3} y3 = {y3}");
            Console.WriteLine($"Радиус вписанной окружности (r) = {r}");
            Console.WriteLine($"Площадь треугольника (s) = {s}");
        }
    }
}
