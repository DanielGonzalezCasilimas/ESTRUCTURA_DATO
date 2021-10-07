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
        que la Pila P no debe sufrir ningún tipo de cambio o alteración.*/

        static void Main(string[] args)
        {
            ArrayList Pila1 = new ArrayList();
            Pila1.Add(0.1f);
            Pila1.Add(0.2f);
            Pila1.Add(0.3f);
            imprimir(Pila1);

            ArrayList Pila2 = new ArrayList();
            Pila2.AddRange(Pila1);
            Pila2.Reverse();
            imprimir(Pila2);
        }

        static void imprimir(ArrayList Invertido)
        {
            foreach (float P in Invertido)
                Console.Write($" {P} |");
            Console.WriteLine("\n");
        }
    }
}
