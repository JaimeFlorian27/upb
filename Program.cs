using System;


    class Program
    {
        static void Main()
        {
        Random Aleatorio = new Random();
        int dado1 = 0, dado2 = 0, consecutivos = 0, total = 0, mayor6 = 0, turnos = 0;
        string respuesta = "s";
        while (respuesta == "s")
            
        {
            //int dado1 = int.Parse(Console.ReadLine()), dado2 = int.Parse(Console.ReadLine());
            dado1 = Aleatorio.Next(1, 7);
            dado2 = Aleatorio.Next(1, 7);
            total += dado1 + dado2;
            turnos++;

            if (dado1 + dado2 > 6)  mayor6++;
            

            if (dado1 == dado2 )
            {
                consecutivos ++ ;
                Console.WriteLine(consecutivos);
            }
            else
            {
                consecutivos = 0;
            }

            if (consecutivos == 3)
            {
                Console.WriteLine("Ganaste, sacaste 3 dobles consecutivos, tu total fue de " + total);
                respuesta = "n";
            }
    
            if (total >= 100)
            {
                Console.WriteLine("Ganaste, sacaste 100 o más puntos, tu total fue de " + total);
                respuesta = "n";
            }

            else if (dado1 + dado2 == 2)
            {
                Console.WriteLine("chao papá");
                respuesta = "n";

            }
            else
            {
                Console.WriteLine("Dado 1= " + dado1 + ", Dado 2= " + dado2 + ", total= " + total);
                Console.WriteLine("Desea Continuar (s/n)");
                respuesta = Console.ReadLine();
            }
            
        }
        double porcentaje = (mayor6 * 100.0) / turnos ;
        Console.WriteLine("Juego finalizado");
        Console.WriteLine("El porcentaje de turnos donde la suma de ambos dados fue más de seis es: " + porcentaje);
    }
}

