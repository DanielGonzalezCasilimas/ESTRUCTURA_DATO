using System;

/*  *GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
     *SHIFT
        diurnal
     *GROUP
        63102C / 239-2A 
    */

namespace Ejercicio_4
{
    class Program
    {
        int[,] Matriz = new int[5, 5];
        int LONGITUD_FILA_MATRIZ = 5;
        int LONGITUD_COLUMNA_MATRIZ = 5;

        public void CargarMatriz()
        {
            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write($"Ingrese el elemento {f+1}, {c+1} del la matriz: ");
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("La matriz resultante es");

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }
        }

        public void ImprimirMatrizInversa()
        {
            Console.WriteLine("");
            Console.WriteLine("La matriz inversa es");

            for (int f = 0; f < LONGITUD_COLUMNA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_FILA_MATRIZ; c++){
                    Console.Write("    [" + Matriz[c, f] + "] ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program Matriz = new Program();
            Matriz.CargarMatriz();
            Matriz.ImprimirMatriz();
            Matriz.ImprimirMatrizInversa();
        }
    }
}
