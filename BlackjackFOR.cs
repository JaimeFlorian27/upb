using System;
class Program
{
    static void Main()
    {
        Random aleatorio = new Random();
        int errores = 0;
        int numero1 = 0, numero2 = 0;
        int jugadormaximo = 0, puntajemaximo = 0;
        int segundo = 0, segundopuntaje = 0;

        numero1 = aleatorio.Next(1, 11);
        numero2 = aleatorio.Next(1, 11);
        Console.WriteLine("si usted es humano por favor realice esta suma: " + numero1 + "+" + numero2);
        double respuesta = double.Parse(Console.ReadLine());
        while (respuesta != numero1 + numero2)
        {
            errores++;
            if (errores > 2) break;
            numero1 = aleatorio.Next(1, 11);
            numero2 = aleatorio.Next(1, 11);
            Console.WriteLine("si usted es humano por favor realice esta suma: " + numero1 + "+" + numero2);
            respuesta = double.Parse(Console.ReadLine());
        }

        if (errores <= 2)
        {
            Console.WriteLine("ingrese el numero de jugadores (min 2 jugadores y max 5 jugadores): ");
            int jugadores = int.Parse(Console.ReadLine());
            string[] nombrejugador = new string[jugadores];
                int[] puntaje = new int[jugadores];

                while ((jugadores <= 1) || (6 <= jugadores))
            {
                Console.WriteLine("Error, ingrese el numero de jugadores (min 2 jugadores y max 5 jugadores): ");
                jugadores = int.Parse(Console.ReadLine());
            }


            for  (int e =0 ; e < jugadores; e++)
            {
                Console.WriteLine("ingrese su nombre: ");
                nombrejugador[e] = Console.ReadLine();

                int cartas;

                for (int i =0; i<1;i++)
                {
                    cartas = aleatorio.Next(1, 11);
                    puntaje[e] += cartas;
                    Console.WriteLine("esta fue su carta:" + cartas);
                    Console.WriteLine("esete es su puntaje:" + puntaje[e]);

                }
                while (puntaje[e] < 21)
                {
                    cartas = aleatorio.Next(1, 11);
                    puntaje[e] += cartas;
                    Console.WriteLine("esta fue su carta:" + cartas);
                    Console.WriteLine("este es su puntaje:" + puntaje[e]);

                    if (puntaje[e] > 21)
                    {
                        Console.WriteLine("no puedes continuar, perdiste, este fue tu puntaje " + puntaje[e]);
                        break;
                    }

                     if (puntaje[e] <= 21 && puntaje[e] > puntajemaximo)
                    {

                        puntajemaximo = puntaje[e];
                        jugadormaximo = e;

                    }

                    Console.WriteLine("desea continuar (s/n)");
                    string continuar = Console.ReadLine();
                    while ((continuar != "s" && continuar != "n"))
                    {
                        Console.WriteLine("por favor ingrese una respuesta valida,¿desea continuar?: (s/n)");
                        continuar = (Console.ReadLine());
                    }
                    if (continuar == "n")
                    {
                        Console.WriteLine("gracias por participar");
                        break;
                    }

                }

                for (int a = 0; a < jugadores; a++)
                {
                    if (puntaje[a] > segundopuntaje && puntaje[a] < puntajemaximo)
                    {

                        segundopuntaje = puntaje[a];
                        segundo = a;
                        

                    }
                }
            }
            Console.WriteLine("el juego termino, el jugador con mejor puntaje fue: " + nombrejugador[jugadormaximo] + ", con: " + puntajemaximo +"puntos, y en segundo lugar " + nombrejugador[segundo] + ", con " + segundopuntaje + " puntos" );
        }
    }
}
