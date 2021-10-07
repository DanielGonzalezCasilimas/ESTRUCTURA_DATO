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
        en una nueva Pila resultante. Es de destacar que las Pilas recibidas no deben sufrir ningún tipo de cambio o alteración.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Primer Lista: ");
            ArrayList Pila1 = new ArrayList();
            Pila1.Add(0.01F);
            Pila1.Add(0.02F);
            Pila1.Add(0.03F);
            imprimir(Pila1);

            Console.WriteLine("Segunda Lista: ");
            ArrayList Pila2 = new ArrayList();
            Pila2.Add(0.04F);
            Pila2.Add(0.05F);
            Pila2.Add(0.06F);
            imprimir(Pila2);

            ArrayList Pila3 = new ArrayList();
            Console.WriteLine("La Apilacion en una nueva Pila es: ");
            Pila3.AddRange(Pila1);
            Pila3.AddRange(Pila2);
            imprimir(Pila3);
        }
        static void imprimir(ArrayList apilar)
        {
            foreach (float P in apilar)
                Console.Write($" {P} |");
            Console.WriteLine("\n");
        }
    }
}
