using System;



class Program
{
    static void Main(string[] args)
    {
        Random aleatorio = new Random();
        string continuar = "n", continuarprimeros3 = "s";
        int i = 0;
        double dado = 0, total = 0;
        bool repeticion12 = false;

        Console.WriteLine("Bienvenido, los primeros 3 tiros son libres y acumula puntos con todos");
        while (i <= 2 && continuarprimeros3 == "s")
        {
            //dado = int.Parse(Console.ReadLine());
            dado = aleatorio.Next(1, 13);
            total += dado;
            Console.WriteLine("este fue su dado: " + dado);
            Console.WriteLine("este es su puntaje: " + total);
            Console.WriteLine("desea continuar? (s/n): ");
            continuarprimeros3 = Console.ReadLine();
            i++;
        }

        if (i ==3 && continuarprimeros3 == "s" ) continuar = "s";
        

        while (continuar == "s")
        {

            dado = int.Parse(Console.ReadLine());
            //dado = aleatorio.Next(1, 13);
            total += dado;
            Console.WriteLine("este fue su dado: " + dado);
            Console.WriteLine("este es su puntaje: " + total);

            if (dado % 2 == 0)
            {

                if (dado == 12) repeticion12 =true ;

                if (dado != 10 && dado !=12) repeticion12 = false;

                if (total >= 100)
                {
                    Console.WriteLine("Usted ha ganado");
                    continuar = "n";
                }
                else if (dado== 10 && (repeticion12 ==true))
                {
                    Console.WriteLine("Usted ha ganado");
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("desea continuar? (s/n): ");
                    continuar = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Usted ha perdido");
                continuar = "n";
            }

           
        }
        Console.WriteLine("su puntaje fue de: " + total + ", gracias por jugar");
    }
}
