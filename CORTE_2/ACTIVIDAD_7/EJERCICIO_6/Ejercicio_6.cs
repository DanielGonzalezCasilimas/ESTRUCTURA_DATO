using System;
using System.Collections;
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
namespace AplicacionBase
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
           Queue ColaP = new Queue();
           Console.WriteLine("Ingrese la dimensión del la cola");
           int dimensión = int.Parse(Console.ReadLine());
           Random aleatorio = new Random ();
           for(int i = 0; i < dimensión; i++)
           {
               int elemento = aleatorio.Next(0,100);
               ColaP.Enqueue(elemento);
           }
           Console.WriteLine("Elementos de la Cola P:");
           imprimirCola(ColaP);
           transferencia(ColaP);           
           Console.WriteLine("Contenido de la cola original, después del proceso de trasnferenicia");
           imprimirCola(ColaP);
        }
        static void transferencia(Queue original)
        {
            int [] colaInvertida = new int [original.Count];
            original.CopyTo(colaInvertida,0);
            Array.Reverse(colaInvertida);
            Queue resultadoInversión = new Queue(colaInvertida);
            Console.WriteLine("Resultado de la transferencia invertida: ");
            original.Clear();
            imprimirCola(resultadoInversión);
        }
        static void imprimirCola (Queue cola)
        {
            foreach(int valor in cola)
                Console.Write($" {valor} |");
            Console.WriteLine();
        }
    }
}
