using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("d: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("y: ");
            double y = double.Parse(Console.ReadLine());

            double a = 180 - d - 90 - b;
            double aradianes = a * (Math.PI / 180);

            double z = y / Math.Tan(aradianes);
            Console.WriteLine("z: " + z);
        }
    }
}
