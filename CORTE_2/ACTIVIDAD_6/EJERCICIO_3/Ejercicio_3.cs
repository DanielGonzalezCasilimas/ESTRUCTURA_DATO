using System;
using System.Collections;
namespace Ejercicio_3
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
    class Ejercicio_3
    {
        /*
        Escriba un programa que reciba la dirección del primer elemento de una lista/pila/cola simple 
        de números enteros y devuelva un apuntador al elemento donde exista el número. <x>. Este número es recibido
        por el método. Se debe retornar NULL si el valor de <x> no se encuentra en la lista/pila/cola.
        */
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();
            Lista.Add(5);
            Lista.Add(4);
            Lista.Add(3);
            imprimir(Lista);
            //int numeros = Lista.Add(1);
            int numeros = Lista.IndexOf(5);
            Console.WriteLine($"El 5 se encuentra en la posicion {1}");
        }

        static void imprimir(ArrayList direccion)
        {
            foreach (int P in direccion)
                Console.Write($" {P} |");
            Console.WriteLine("\n");

            
        }
    }
}
