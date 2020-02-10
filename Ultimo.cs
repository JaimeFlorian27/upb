using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, por favor ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese su tipo de contrato,1 independiente o 2 dependiente: ");
            int contrato = int.Parse(Console.ReadLine());

            double smmlv = 877803;
            double ARL, EPS, pension, salariomensual, salarioanual;
            double cotizacion = 0.4 * salario;
           
            if (cotizacion < smmlv) cotizacion = smmlv;


            switch (contrato)
            {
                case 1:
                    Console.WriteLine(" por favor ingrese el nivel de su riesgo laboral: ");
                    int riesgo = int.Parse(Console.ReadLine());
                    pension = 0.16 * cotizacion;
                    EPS = 0.125 * cotizacion;
                    switch (riesgo)
                    {
                        case 1:
                            ARL = cotizacion * 0.522 / 100;

                            break;
                        case 2:
                            ARL = (cotizacion * 0.522) / 100;

                            break;
                        case 3:
                            ARL = (cotizacion * 2.436) / 100;

                            break;
                        case 4:
                            ARL = (cotizacion * 4.350) / 100;

                            break;
                        default:
                            ARL = (cotizacion * 6.960) / 100;

                            break;
                    }
                    salariomensual = salario - pension - EPS - ARL;
                    salarioanual = salariomensual * 12;
                    Console.WriteLine("su salario mensual sería: " + salariomensual);
                    Console.WriteLine("su salario anual sería: " + salarioanual);
                    break;
                case 2:
                    EPS = cotizacion * 0.04;
                    pension = cotizacion * 0.4;
                    salariomensual = salario - pension - EPS;
                    salarioanual = salariomensual * 12 + salario;
                    Console.WriteLine("su salario mensual seria: " + salariomensual);
                    Console.WriteLine("su salario anual sería: " + salarioanual);
                    break;
                    
            }
            
        }
        
    }
}
        