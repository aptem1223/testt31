using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c) : base("Треугольник")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны: {a}, {b}, {c}, Площадь: {Area():F2}, Периметр: {Perimeter():F2}");
        }
    }
}
