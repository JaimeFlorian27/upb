using System;

namespace TareaClase10
{

    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int total = 0;
            int i = 0;
            string jugadormaximo ="nadie", nombrejugador;
            int errores = 0, numero1 = aleatorio.Next(1, 11), numero2 = aleatorio.Next(1, 11), jugador = 0, puntajemaximo =0;

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

                while ((jugadores <= 1) || (6 <= jugadores))
                {
                    Console.WriteLine("Error, ingrese el numero de jugadores (min 2 jugadores y max 5 jugadores): ");
                    jugadores = int.Parse(Console.ReadLine());
                }
                

                while (jugador < jugadores)
                {
                    Console.WriteLine("ingrese su nombre: ");
                    nombrejugador = Console.ReadLine();
                    jugador++;

                    int cartas;
                    while (i < 1)
                    {
                        cartas = aleatorio.Next(1, 11);
                        total += cartas;
                        Console.WriteLine("esta fue su carta:" + cartas);
                        Console.WriteLine("esete es su puntaje:" + total);
                        i++;
                    }
                    while (total < 21)
                    {
                        cartas = aleatorio.Next(1, 11);
                        total += cartas;
                        Console.WriteLine("esta fue su carta:" + cartas);
                        Console.WriteLine("este es su puntaje:" + total);
                        if (total > 21)
                        {
                            Console.WriteLine("valiste verga, perdiste" + total + "puntos");
                            break;
                        }
                            
                            Console.WriteLine("desea continuar (s/n)");
                        string continuar = Console.ReadLine();
                        if (continuar != "s") break;
                        
                    }

                    if(total <= 21 && total >puntajemaximo)
                    {

                        puntajemaximo = total;
                        jugadormaximo = nombrejugador;
                    }
                    i = 0;
                   
                    total = 0;
                    

                }

                Console.WriteLine("el juego termino, el jugador con mejor puntaje: " + jugadormaximo + ",con: " + puntajemaximo); 
            }
        }
    }
}




    
