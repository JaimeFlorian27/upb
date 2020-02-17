using System;



    class Program
    {
        static void Main()
        {
        Random Aleatorio = new Random();
        int dado=0, vidas=1, total=0, i=2, repet6=0, repet1 = 0;
        string continuar, usardadoesp="a";
        while (true)
        {
            Console.WriteLine("Tiene " + vidas + " vidas");
            if (i != 0)
            {
                Console.WriteLine("Desea usar el dado especial?, le quedan " + i + " dados. (s/n)");
                usardadoesp = Console.ReadLine();
                if (usardadoesp == "s")
                {
                    dado = Aleatorio.Next(1, 13);
                    i--;
                }
                
            }

            if (usardadoesp != "s") dado = Aleatorio.Next(1, 7); //dado = int.Parse(Console.ReadLine());
            total += dado;
            Console.WriteLine("Dado: " + dado + " Total= " + total);

            if (dado == 1)
            {
                repet1++;
            }

            if (repet1 == 2)
            {
                
                vidas -= 1;
                Console.WriteLine("Has perdido una vida, ahora tienes " + vidas +" vidas");
                total -= 10;
                repet1 = 0;
            }

            if (dado == 6) repet6++;


            else repet6 = 0;


            if (repet6 == 2)
            {
                
                if (vidas<3) vidas++;
                Console.WriteLine("Ganaste una vida ahora tienes " + vidas + " vidas");
                repet6 = 0;
            }
            if (vidas==0)
            {
                Console.WriteLine("Has perdido");
                break;
            }
            if (total >=100)
            {
                Console.WriteLine("Has ganado");
                break;
            }

            Console.WriteLine("Desea Continuar (s/n)");
            continuar = Console.ReadLine();
            if (continuar != "s") break;
        }

        }
    }

