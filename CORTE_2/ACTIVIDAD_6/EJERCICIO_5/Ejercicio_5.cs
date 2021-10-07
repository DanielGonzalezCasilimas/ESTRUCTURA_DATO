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

namespace EJERCICIO_5
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
            //Programa con Lista, Pila o Cola en el que se pase una lista a otra y al final la primera lista no tenga nada.

            ArrayList Pila = new ArrayList();
            Random DatosAleatorios = new Random();

            int Longitud;

            Console.WriteLine("Ingrese la longitud de la lista");
            Longitud = int.Parse(Console.ReadLine());

            for (int i = 0; i < Longitud; i++)
            {
                Pila.Add(DatosAleatorios.Next(0,100));
            }

            Pila.Sort();

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la lista");
            foreach (int a in Pila)
            {
                Console.WriteLine($" [{a}] ");
            }

            ArrayList NuevaPila = new ArrayList();

            Console.WriteLine("");
            Console.WriteLine("Se pasan los datos a la nueva lista");

            NuevaPila.AddRange(Pila);

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la lista nueva");
            foreach (int b in NuevaPila)
            {
                Console.WriteLine($" [{b}] ");
            }

            Console.WriteLine("Ingrese 1 si desea eliminar los datos de la primera");
            Console.WriteLine("RECUERDE!!! AL ELIMINAR LOS DATOS LE VA A SACAR UN ERROR, PUES YA NO HAY RASTRO DE ESTOS ELEMENTOS EN LA LISTA");
            int Respuesta = 0;
            Respuesta = int.Parse(Console.ReadLine());

            if (Respuesta == 1)
            {
                Pila.Clear();

                Console.WriteLine("");
                
                foreach (int c in Pila)
                {
                    Console.WriteLine($" [{c}] ");
                }

                Console.WriteLine("SE ELIMINARON TODOS LOS ELEMENTOS DE ESTA LISTA");
            }

            else
            {
                Console.WriteLine("Decidio no eliminar los datos de la primera lista");
            }
        }
    }
}
