using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("d: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("x: ");
            double x = double.Parse(Console.ReadLine());

            double dradianes = d * (Math.PI / 180);

            double y = w * Math.Cos(dradianes) - x;
            Console.WriteLine("y: " + y);

        }
    }
}
