using System;

namespace Problema_4
{
    /*
    GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    SHIFT
        diurnal
    GROUP
        63102C / 239-2A 
    */
    class Problema_4
    {
        // Crea un array de numeros de 100 posiciones, que contendrá los numeros del 1 al 100. Obtener suma de todos y la media (promedio) del array.
        static void Main(string[] args)
        {
			int LONGITUD_VECTOR= 100;
            int suma = 0;
            int promedio;

			
			// Definir vector
			int[] Vector = new int[LONGITUD_VECTOR];

			for (int i = 0; i < LONGITUD_VECTOR; i++)
			{
				Vector[i] = 1 * (i+1);
				Console.WriteLine($"Los numeros son -> {Vector[i]}");
			}

            foreach (int j in Vector)
            {
				suma += j;
			}
            promedio = suma / LONGITUD_VECTOR;
            Console.WriteLine($"La suma de los 100 numeros es -> {suma}");
            Console.WriteLine($"La media de los 100 numeros es -> {promedio}");
        }
    }
}
