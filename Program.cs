using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Rectangle(4, 6));
            figures.Add(new Square(5));
            figures.Add(new Triangle(3, 4, 5));
            figures.Add(new Circle(5));

            Console.WriteLine("Информация о фигурах:");
            foreach (var figure in figures)
            {
                figure.Print();
                Console.WriteLine();
            }
        }
    }
}
