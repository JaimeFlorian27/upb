using System;



    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Ingrese su salario mensual");
        double salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese 1 si su salario es dependiente, o 2 si su salario es independiente");
         double contrato = double.Parse(Console.ReadLine());

        double smmlv = 877803;
        double basecot = salario * 0.40;

        if (basecot < smmlv )
        {
            basecot = smmlv;
        }

        if (contrato == 2)
            {
                Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo");
                double riesgo = double.Parse(Console.ReadLine());
            double eps = basecot * 0.125;
            double pension = basecot * 0.16;
            double arl;

            if (riesgo == 1)
                {
                    arl = basecot * (0.522/100);
                

            }

                else if (riesgo == 2)
                {
                    arl = basecot * (1.044 / 100);

                }

                else if (riesgo == 3)
                {
                    arl = basecot * (2.436 / 100);

                }

                else if (riesgo == 4)
                {
                    arl = basecot * (4.350 / 100);

                }
                else
                {
                    arl = basecot * (6.960 / 100);

                }

            double salarealmen = salario - eps - pension - arl;
            double salarealan = salarealmen * 12;
            Console.WriteLine("Su salario real mensual es " + salarealmen + " y su salario real anual es: " + salarealan);
        }
        else
            {
            double eps = basecot * 0.04;
            double pension = basecot * 0.04;

            double salarealmen = salario - eps - pension;
            double salarealan = salarealmen * 12 + salario;
            Console.WriteLine("Su salario real mensual es " + salarealmen + " y su salario real anual es: " + salarealan);


        }
        }




    }


