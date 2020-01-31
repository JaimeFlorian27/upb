using System;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese su salario mensual para determinar su tarifa");
        double salario = double.Parse(Console.ReadLine());

        double smmlv = 877803;

        if (salario< 2 * smmlv)
        {
            Console.WriteLine("Usted deberá cancelar la tarifa A");
        }
        else if (2*smmlv<= salario && salario < 4* smmlv)
        {
            Console.WriteLine("Usted deberá cancelar la tarifa B");
        }
        else
        {
            Console.WriteLine("Usted deberá cancelar la tarifa C");
        }
        }
    }
