using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("t: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = double.Parse(Console.ReadLine());

            double cradianes = c * (Math.PI / 180);

            double z = t * Math.Sin(cradianes);

            double ab = Math.Acos(z / w);

            double y = Math.Cos(cradianes) * t;

            double x = Math.Sin(ab) * w - y;
            Console.WriteLine("x: " + x);
        }
    }
}
