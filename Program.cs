using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle("Треугольник = ", 5 , 2 , 10 );
            triangle.Print();
        }
    }
}
