using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Square : Figure
    {
        private double side;

        public Square(double side) : base("Квадрат")
        {
            this.side = side;
        }

        public double Side { get { return side; } }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона: {side}, Площадь: {Area():F2}, Периметр: {Perimeter():F2}");
        }
    }
}
