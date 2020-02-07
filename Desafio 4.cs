using System;


    class Program
    {
    static void Main()
    {
        Console.WriteLine("Ingrese los votos de A:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los votos de B:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los votos en Blanco:");
        int blancos = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los votos Anulados:");
        int anulados = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de población:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el porcentaje de personas mayores de edad:");
        double p = double.Parse(Console.ReadLine());

        int totales = a + b + blancos + anulados;

        int diferencia;

        if (a < b) diferencia = a - b;
        else diferencia = b - a;


        bool tot = totales > n;

        bool dif =  diferencia < totales / 10;


        bool vot = totales < n * 0.03;

        if ((tot || dif) && vot)
        {
            Console.WriteLine("Las elecciones se deben repetir");

        }
        else
        {
            string ganador;
            if (a > b)  ganador = "a";
            else ganador = "b";
            Console.WriteLine("El ganador es: " + ganador);
        }
    }
    }

