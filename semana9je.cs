using System;

namespace semana9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0,dado2 = 0, total = 0, vidas =3;
            double turnos = 0, turnosvida =0 ;
            string continuar = "s";

            while (true)
            {
                turnos++;
                turnosvida++;
                if (turnos != 3)
                {
                    dado1 = aleatorio.Next(1, 7);
                    Console.WriteLine("este fue su dado:" + dado1);
                    total += dado1;
                }
                if (turnos == 3)
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("estos son sus dados:" + dado1 + "," + dado2);
                    if (dado1 == dado2)
                    {
                        vidas++;
                        Console.WriteLine("ganó vida");
                    }
                    
                    total += dado1 + dado2;
                    turnos = 0;
                }
                
                if (turnosvida % 2 ==0)
                {
                    vidas--;
                    Console.WriteLine("perdió una vida");
                    
                }
                Console.WriteLine("este es su total:" + total);
                Console.WriteLine("esta es su vida:" + vidas);
            
                if (vidas ==0)
                {
                    Console.WriteLine("usted ha perdido");
                    break;
                }
                if (total > 100)
                {
                    Console.WriteLine("usted ha ganado");
                    break;
                }

                Console.WriteLine("desea continuar?: (s/n)");
                continuar = Console.ReadLine();
                if (continuar != "s") break;
            }

            Console.WriteLine("este es su total:" + total + " gracias por jugar");

        }
    }
}
