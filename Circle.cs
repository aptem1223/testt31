using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Circle: Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Круг")
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {Radius}, Площадь: {Area():F2}, Периметр: {Perimeter():F2}");
        }
    }
}
