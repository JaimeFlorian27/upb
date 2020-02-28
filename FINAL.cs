using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, r = 0;
            double[] coordsx = { 0, 1, 2, 3};
            double[] coordsy = { 0, 1, 2, 3 };
            double[] pendiente = { 0, 0, 0, 0 };
            double[] distancia = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] cortey = { 0, 0, 0, 0 };
            double distanciamayor = 0;
            bool pendientesiguales = false, cortesiguales = false;
             for (int i = 0; i < 3; i++)
             {
                 pendiente[i] = ((coordsy[i + 1] - coordsy[i]) / (coordsx[i + 1] - coordsx[i]));
                 Console.WriteLine("Pendiente entre " + coordsx[i] + "," + coordsx[i] + " y " + coordsx[i + 1] + "," + coordsy[i + 1] + " es: " + pendiente[i]);
                 cortey[i] = (coordsy[i] - (pendiente[i] * coordsx[i]));
                 Console.WriteLine("el corte en y es: " + cortey[i]);
             }
            for (int i = 0; i < 3; i++)
            {
                if (pendiente[i] == pendiente[i + 1]) pendientesiguales = true;
                else break;
                if (cortey[i] == cortey[i + 1]) cortesiguales = true;
                else break;

            }
            for (int i = 0; i < 12; i++)
            {
                if (r > 3) r = 0;
                if (i % 4 == 0) a++;
                distancia[i] = Math.Abs(Math.Sqrt((Math.Pow((coordsx[r] - coordsx[a]), 2) + (Math.Pow(coordsy[r] - coordsy[a], 2)))));
                if (distancia[i] > distanciamayor) distanciamayor = distancia[i];
                r++;
        }

            if (cortesiguales == true && pendientesiguales == true) Console.WriteLine("Hacen Parte de la misma recta");
            else Console.WriteLine("No hacen parte de la misma recta");
            Console.WriteLine("la distancia mayor fue:" + distanciamayor);
        }   
    }
