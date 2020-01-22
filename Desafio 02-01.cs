using System;

class Program
{
    static void Main()
    {
        //Obtener datos
        Console.Write("Escriba el valor del cateto z: ");
        double z = double.Parse(Console.ReadLine());
        Console.Write("Escriba el valor del cateto y: ");
        double y = double.Parse(Console.ReadLine());

        //Cálculo de variables faltantes
        double t = Math.Sqrt(z * z + y * y);
        double a = Math.Atan(y / z) * 180 / Math.PI;
        double c = Math.Atan(z / y) * 180 / Math.PI;

        //Imprimir datos
        Console.WriteLine("La hipotenusa t e igual a: " + t);
        Console.WriteLine("El angulo A es igual a: " + a);
        Console.WriteLine("El angulo C es igual a: " + c);
    }
}