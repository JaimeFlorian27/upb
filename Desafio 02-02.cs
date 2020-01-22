using System;

class Program
{
    static void Main()
    {
        //Obtener datos
        Console.Write("Escriba el valor de la hipotenusa t: ");
        double t = double.Parse(Console.ReadLine());
        Console.Write("Escriba el valor del ángulo a: ");
        double aGrados = double.Parse(Console.ReadLine());

        //Conversión de grados a radianes
        double a = aGrados * (Math.PI / 180);

        //Cálculo de variables faltantes
        double y = Math.Sin(a) * t ;
        double z = Math.Cos(a) * t  ;
        double c = 180 - 90 - aGrados ;

        //Imprimir datos
        Console.WriteLine("el cateto y es igual a: " + y);
        Console.WriteLine("el cateto z es igual a: " + z);
        Console.WriteLine("el ángulo c es igual a: " + c);
    }
}