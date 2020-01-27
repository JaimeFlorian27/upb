using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("y: ");
            double y = double.Parse(Console.ReadLine());

            double a = Math.Atan(y / z);

            double bradianes = b * (Math.PI / 180);
            double x = z * Math.Tan(a + bradianes) - y;
            Console.WriteLine("x: " + x);
        }
    }
