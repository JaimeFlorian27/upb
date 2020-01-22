using System;

class Program
{
    static void Main()
    {
        //Obtener datos
        Console.Write("Escriba el valor del ángulo c: ");
        double cGrados = double.Parse(Console.ReadLine());
        Console.Write("Escriba el valor del cateto z: ");
        double z = double.Parse(Console.ReadLine());

        //Conversión de grados a radianes
        double c = cGrados * (Math.PI / 180);

        //Cálculo de variables faltantes
        double y = 1/Math.Tan(c) * z;
        double t = 1/Math.Sin(c) * z;
        double a = 180 - 90 - cGrados;

        //Imprimir datos
        Console.WriteLine("el cateto y es igual a: " + y);
        Console.WriteLine("la hipotenusa t es igual a: " + t);
        Console.WriteLine("el ángulo a es igual a: " + a );
    }
}