using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema_8
{
    class Problema_8
    {
        //Programa para leer la altura de N personas y calcular la altura media. 
        //Calcular cuantas personas tienen la altura superior a la media y cuantas inferior a la media. El valor N se pide por teclado y debe ser entero positivo.
        static void Main(string[] args)
        {
			//int alumnosEnDosGrupos = 0;
            int CantidadPersonas =0; 
            int posicionCentralVector;
            int mayor =0;
            int menor =0;
            do
            {
                Console.Write("El numero debe ser par, ¿Cuantas personas desea ingresar?: ");
                CantidadPersonas = int.Parse(System.Console.ReadLine());

            } while (CantidadPersonas <= 0);
            
            int[] AlturaPersonas = new int[CantidadPersonas];

            for (int i = 0; i < CantidadPersonas; i++)
            {
                Console.Write($"Digite la Altura de la persona: {i+1}: ");
                AlturaPersonas[i] = int.Parse(System.Console.ReadLine());
            }

            Array.Sort(AlturaPersonas);
            posicionCentralVector = CantidadPersonas /2;
            
            

            for(int j=0;j < AlturaPersonas.Length;j++)
            {
                if(AlturaPersonas[posicionCentralVector] > AlturaPersonas[j] )
                {
                    menor += 1;            
                }
                if(AlturaPersonas[posicionCentralVector] < AlturaPersonas[j] )
                {
                    mayor += 1;
                }
            }

            Console.WriteLine($"La altura media de los {CantidadPersonas} es: {AlturaPersonas[posicionCentralVector]}.");
            Console.WriteLine($"Los Mayores son: {mayor}.");
            Console.WriteLine($"Los Menores son: {menor}.");

        }
    }
}