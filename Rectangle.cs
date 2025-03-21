using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) : base("Прямоугольник")
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {Area():F2}, Периметр: {Perimeter():F2}");
        }
    }

}

