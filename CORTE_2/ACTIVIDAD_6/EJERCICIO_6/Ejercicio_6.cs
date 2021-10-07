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

namespace EJERCICIO_6
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            //Programa en el que se pasa Pila1 a la Pila2 con los elemnetos invertidos. Y al final la primera Pila no debe tener información.

            ArrayList Pila1 = new ArrayList();
            Random NumerosAleatorios = new Random();

            int Cantidad;

            Console.WriteLine("Ingrese la cantidad de la lista");
            Cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < Cantidad; i++)
            {
                Pila1.Add(NumerosAleatorios.Next(0,100));
            }

            Pila1.Sort();

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la Pila1");
            foreach (int a in Pila1)
            {
                Console.WriteLine($" [{a}] ");
            }

            ArrayList Pila2 = new ArrayList();

            Console.WriteLine("");
            Console.WriteLine("Se pasan los elementos a la nueva lista. Además, se invirtieron los datos para la Pila2");

            Pila2.AddRange(Pila1);
            Pila2.Reverse();

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la Pila2");
            foreach (int b in Pila2)
            {
                Console.WriteLine($" [{b}] ");
            }

            Console.WriteLine("Ingrese 1 si desea eliminar los elementos de la Pila1");
            Console.WriteLine("RECUERDE!!! AL ELIMINAR LOS ELEMENTOS LE VA A SACAR UN ERROR, PUES YA NO HAY RASTRO DE ESTOS ELEMENTOS EN LA LISTA");
            int Res = 0;
            Res = int.Parse(Console.ReadLine());

            if (Res == 1)
            {
                Pila1.Clear();

                Console.WriteLine("");
                
                foreach (int c in Pila1)
                {
                    Console.WriteLine($" [{c}] ");
                }

                Console.WriteLine("SE ELIMINARON TODOS LOS ELEMENTOS DE ESTA LISTA");
            }

            else
            {
                Console.WriteLine("Decidio no eliminar los elementos de la Pila1");
            }
        }
    }
}
