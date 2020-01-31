using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su salario mensual para determinar su tarifa");
        double salario = double.Parse(Console.ReadLine());

        double smmlv = 877803;

        if (salario < 2 * smmlv)
        {
            double cuota = 3400;
            Console.WriteLine("Usted deberá cancelar la siguiente suma: "+ cuota);
        }
        else if (2 * smmlv <= salario && salario < 5 * smmlv)
        {
            double cuota = 13500;
            Console.WriteLine("Usted deberá cancelar la siguiente suma: " + cuota);
        }
        else
        {
            double cuota = 35600;
            Console.WriteLine("Usted deberá cancelar la siguiente suma: " + cuota);
        }
    }
}