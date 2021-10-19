using System;
using System.Collections;
/*
    GROUP MEMBERS
        Roa Ruiz María Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    
    SHIFT
        diurnal

    GROUP
        63102C / 239-2A */
namespace AplicacinBase
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
           Console.Write("Ingrese la dimensión de la cola: ");
           int dimension = int.Parse(Console.ReadLine());
           Queue Numeros = new Queue();
           Random aleatorio = new Random();
           for(int i = 0; i < dimension; i++)
           {
               int elemento = aleatorio.Next(0,20);
               Numeros.Enqueue(elemento);
           }
           Console.WriteLine("Elementos de la cola: ");
           imprimirCola(Numeros);
           Console.WriteLine("Los cuadarados de la cola son: ");
           cuadrados(Numeros);
           sumatoriaCuadrados(Numeros);
           
        }
        static void imprimirCola (Queue cola)
        {
            foreach (int num in cola)
                Console.Write($" {num} |");
            Console.WriteLine();
        }
        static void cuadrados (Queue cola)
        {
             foreach (int num in cola)
                Console.Write($" {num * num} |");  
            Console.WriteLine();          
        }

        static void sumatoriaCuadrados (Queue cola)
        {
            int sumatoriaCuadrados = 0;
             foreach (int num in cola)
                sumatoriaCuadrados += (num * num);
            Console.WriteLine($"La sumatoria total de los cuadrados es de : {sumatoriaCuadrados}");
        }
    }
}
