using System;

namespace Ejercicio_10
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
        63102C / 239-2A */
    class Ejercicio_10
    {
        /*Realiza un programa que rellene un array de 6 filas por 10 columnas con números 
        enteros positivos comprendidos entre 0 y 1000 (ambos incluidos). A continuación, el programa deberá dar la posición tanto del máximo como del mínimo.
        */
        
        static void Main(string[] args)
        {
            int [,] matriz = new int [6,10];
            int LONGITUD_FILA= 6;
            int LONGITUD_COLUMNA = 10;
            Random aleatorio = new Random();
            for(int f=0; f<LONGITUD_FILA; f++)
            {
                for (int c = 0; c < LONGITUD_COLUMNA; c++)
                {
                    matriz[f, c] = aleatorio.Next(0,1000);
                    Console.Write("  |  [" + matriz[f, c] + "] | ");
                }
                Console.WriteLine();
            }

            
            int mayorSalario = 0;
            for (int f = 0; f < LONGITUD_FILA; f++)
            {
                for(int c = 0; c <LONGITUD_COLUMNA;c++)
                {
                    if (matriz[f, c] > mayorSalario){
                        mayorSalario = matriz[f, c];
                    }
                }
            }
            Console.WriteLine("   El numero mayor es: " + mayorSalario);

            int menorSalario = 999999999;
            for (int f = 0; f < LONGITUD_FILA; f++)
            {
                for(int c = 0; c <LONGITUD_COLUMNA;c++)
                {
                    if (matriz[f, c] < menorSalario){
                        menorSalario = matriz[f, c];
                    }
                }
            }
            Console.WriteLine("   El numero menor es: " + menorSalario);
        }
    }
}
