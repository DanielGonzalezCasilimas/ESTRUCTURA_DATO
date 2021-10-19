using System;
using System.Collections;

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
        63102C / 239-2A 
    */
    class Ejercicio_10
    {
        /*
        Escriba una rutina que reciba una Pila P de números flotantes y devuelva una nueva Pila,
        pero con los elementos invertidos,es decir el último de la Pila P, pasará a ser el primero de la nueva Pila Es de destacar 
        que la Pila P no debe sufrir ningún tipo de cambio o alteración.
        */
        static void Main(string[] args)
        {

            // Se instancia una nueva cola y pila
            Queue Cola = new Queue();
            Stack Pila = new Stack();

            // Se carga la cola con valores
            Cola.Enqueue(1);
            Cola.Enqueue(2);
            Cola.Enqueue(3);
            Cola.Enqueue(4);

            Console.WriteLine("La cola inicial es: ");

            while (Cola.Count > 0)
            {
                int Col = 0;
                Col = (int)Cola.Dequeue();
                Console.WriteLine($"  Cola: {Col}");
                Pila.Push(Col);
            }
            Console.WriteLine("Se creó una pila: ");
            while (Pila.Count > 0)
            {
                Console.WriteLine($"  Pila: {Pila.Pop()}");
            }
            Console.WriteLine("ya no hay elementos en la Pila.");
        }
    }
}
