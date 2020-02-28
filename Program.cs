using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordsx = { 0, 2, 3, 7 };
            double[] coordsy = { 0, 1, 5, 6 };
            double[] pendiente = { 0, 0, 0, 0 };
            double[] distancia = { 0, 0, 0, 0 };
            double[] cortey = { 0, 0, 0, 0 };
            double distanciamayor=0;
            bool pendientesiguales = false, cortesiguales = false;
            for (int i = 0; i < 3; i++)
            {
                pendiente[i] = ((coordsy[i + 1] - coordsy[i]) / (coordsx[i + 1] - coordsx[i]));
                Console.WriteLine("Pendiente entre " + coordsx[i] + "," + coordsx[i] + " y " + coordsx[i + 1] + "," + coordsy[i + 1] + " es: " + pendiente[i]);
                cortey[i] = (coordsy[i] - (pendiente[i] * coordsx[i]));
                Console.WriteLine("el corte en y es: " + cortey[i]);
                distancia[i] = Math.Sqrt((Math.Pow(coordsx[i + 1] - coordsx[i], 2) + (Math.Pow(coordsy[i + 1] - coordsy[i], 2))));
                Console.WriteLine("distancia es: " + distancia[i]);


                if (distancia[i] > distanciamayor) distanciamayor = distancia[i];
                Console.WriteLine("la distancia mayor fue:" + distancia[i]);

            }
            for (int i = 0; i<3; i++)
            {
                if (pendiente[i] == pendiente[i + 1]) pendientesiguales = true;
                if (cortey[i] == cortey[i + 1]) cortesiguales = true;

            }
            if (cortesiguales ==true && pendientesiguales ==true)
            {
                Console.WriteLine ("Hacen Parte de la misma recta");
            }
            if (i % 3 == 0)
            {

            }
            coordsx
        }
    }
}