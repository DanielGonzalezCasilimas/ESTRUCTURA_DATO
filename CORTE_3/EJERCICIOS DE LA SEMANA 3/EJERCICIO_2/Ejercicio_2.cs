using System;
using System.Collections;

//Created by: Daniel Stevan González Casilimas
//Group: 239-2A
//Shift: Diurno

//Desarrolle un programa que permita cargar una matriz con "n" elementos, luego, desarrollar la suma de todos los 
//elementos y finalmente, imprimir el valor restante. Haga uso de POO para ello

namespace EJERCICIO_2
{
    class Program
    {
        private int LONGITUD;
        private int Sumatoria = 0;
        private int [] Matriz;

        public Program()
        {
            Console.WriteLine("Ingrese la longitud de la matriz");
            LONGITUD = int.Parse(System.Console.ReadLine());

            Matriz = new int [LONGITUD];

            for (int f = 0; f < LONGITUD; f++)
            {
                Console.WriteLine($"Ingrese el elemnto {f + 1}");
                Matriz[f] = int.Parse(System.Console.ReadLine());
                Console.WriteLine($"");
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("La matriz es: ");

            for (int f = 0; f < LONGITUD; f++)
            {
                Console.WriteLine("  | [" + Matriz[f] + "] | ");          
                Console.WriteLine("");
            }
        }

        public void Suma()
        {
            Console.WriteLine("Suma de la matriz: ");

            for (int f = 0; f < LONGITUD; f++)
            {
                Sumatoria = Matriz[f] + Matriz[f];
            }

            Console.WriteLine(Sumatoria);
        }

        static void Main(string[] args)
        {
            Program matriz = new Program();
            matriz.ImprimirMatriz();
            matriz.Suma();
        }
    }
}
