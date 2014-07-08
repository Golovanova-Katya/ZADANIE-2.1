using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_2._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ребра а,б,с:\n");
            Parallelepiped paralleli = new Parallelepiped(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Площадь поверхности = " + paralleli.Squere);
            Console.WriteLine("Объём параллелепипеда = {0:F}", paralleli.V);
            Console.WriteLine("Диагональ параллелепипеда = {0:F}", paralleli.Diagonal());
            Console.WriteLine("Площадь круга = {0:F}", paralleli.Kryg(4, 4));
            Console.ReadLine();

        }
    }

    class Parallelepiped
    {
        double a;
        double b;
        double c;

        public Parallelepiped(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Squere
        {
            get { return 2 * (a * b + b * c + a * c); }
        }

        public double V
        {
            get { return a * b * c; }
        }

        public double Diagonal()
        {
            return Math.Sqrt(a * a + b * b + c * c);
        }

        public double Kryg(int a, int b)
        {
            return Math.PI * Math.Pow(a / 2, 2);
        }
    }
}

