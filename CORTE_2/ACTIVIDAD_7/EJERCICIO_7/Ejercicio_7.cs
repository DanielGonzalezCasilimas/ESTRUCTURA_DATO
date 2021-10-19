using System;
using System.Collections;

namespace Ejercicio_7
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
    class Ejercicio_7
    {
        /*Escriba una rutina que reciba dos Pilas P1 y P2 de números flotantes y apile las mismas 
        en una nueva Pila resultante. Es de destacar que las Pilas recibidas no deben sufrir ningún tipo de cambio o alteración.
        */
        static void Main(string[] args)
        {
            Queue Cola1 = new Queue();
            Queue Cola2 = new Queue();
            Queue Cola3 = new Queue();

            Cola1.Enqueue(1);
            Cola1.Enqueue(2);
            Cola1.Enqueue(3);

            Cola2.Enqueue(4);
            Cola2.Enqueue(5);
            Cola2.Enqueue(6);

            Console.WriteLine("Cola 1");
            Console.WriteLine();
            while (Cola1.Count > 0)
            {
                int C = 0;
                C = (int)Cola1.Dequeue();
                Console.Write(C);
                Cola3.Enqueue(C);
                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine("Cola 2");
            Console.WriteLine();
            while (Cola2.Count > 0)
            {
                int C = 0;
                C = (int)Cola2.Dequeue();
                Console.Write(C);
                Cola3.Enqueue(C);
                Console.WriteLine();
            }
            Console.WriteLine();

            // Se imprime la cola resultante
            Console.WriteLine("Apilacion de las colas: ");
            Console.WriteLine();
            while (Cola3.Count > 0)
            {
                int C = 0;
                C = (int)Cola3.Dequeue();
                Console.WriteLine(C);
            }
        }
    }
}
