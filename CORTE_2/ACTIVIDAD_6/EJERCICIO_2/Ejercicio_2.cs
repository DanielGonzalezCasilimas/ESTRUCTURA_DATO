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
    //Escriba un programa que calcule la sumatoria de los cuadrados de los elementos de una lista/pila/cola de números enteros.
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            ArrayList Pila = new ArrayList();
            Console.Write("Ingrese la longitud de la lista: ");
            int longitud = int.Parse(Console.ReadLine());
            Random aleatorio = new Random () ;

            for(int i = 0; i < longitud; i++)
            {
                Pila.Add(aleatorio.Next(0,20));
            }
            Console.WriteLine("Los elementos de la lista son: ");

            foreach (int elemento in Pila)
                Console.WriteLine($" {elemento}");
            Console.WriteLine("-----------");

            Console.WriteLine("El cuadradado de la lista es: ");
            foreach (int numero in Pila)
                Console.Write(" {0} -", numero * numero);
            Console.WriteLine("\n-----------");

            Console.WriteLine("La sumatoria de los cuadrados es: ");

            int sumatoria = 0;
            foreach (int valor in Pila)
                sumatoria = sumatoria + (valor * valor);
            Console.WriteLine(" {0}", sumatoria);


        }
    }
}

