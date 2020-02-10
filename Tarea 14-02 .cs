using System;



    class Program
    {
        static void Main()
        {
        Random rnd = new Random();
        int carta1 = rnd.Next(1, 11);
        int carta2 = rnd.Next(1, 11);
        int cartastotal = carta1 + carta2;
        int cartanueva =0;
        string respuesta = "";

        Console.WriteLine("Sus cartas son " + carta1 + " y " + carta2 + " en total tiene " + cartastotal );

        Console.WriteLine("Desea continuar (s/n): ");

        respuesta = Console.ReadLine();

        while (respuesta == "s" && cartastotal < 21)
        {
            cartanueva = rnd.Next(1, 11);
            
            cartastotal += cartanueva;

            if (cartastotal >= 21) Console.WriteLine("Sacó un " + cartanueva + ", Usted ha sido eliminado");

            else
            {
            Console.WriteLine("sacó un " + cartanueva + " y en total tiene " + cartastotal);
            Console.WriteLine("Desea continuar (s/n): ");
            respuesta = Console.ReadLine();
            }
            
        }
        Console.WriteLine("Su total fue " + cartastotal + ", gracias por jugar.");
    }
}

