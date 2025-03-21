using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   abstract class Figure
    {
        private string name;
        public Figure(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
    }
}
