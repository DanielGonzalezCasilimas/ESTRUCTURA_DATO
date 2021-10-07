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

namespace EJERCICIO_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            //Programa con Lista, Pila o Cola en el que se pase una lista a otra y al final la primera lista no tenga nada con Métodos.

            ArrayList Pila = new ArrayList();
            Random DatosAleatorios = new Random();
            int Longitud;
            int Respuesta;

            Console.WriteLine("Ingrese la longitud de la lista");
            Longitud = int.Parse(Console.ReadLine());

            for (int i = 0; i < Longitud; i++)
            {
                Pila.Add(DatosAleatorios.Next(0,100));
            }

            Pila.Sort();

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la lista");
            Imprimir(Pila);

            ArrayList NuevaPila = new ArrayList();

            Console.WriteLine("");
            Console.WriteLine("Se pasan los datos a la nueva lista");

            NuevaPila.AddRange(Pila);

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la lista nueva");
            Imprimir(NuevaPila);

            Console.WriteLine("Ingrese 1 si desea eliminar los datos de la primera");
            Console.WriteLine("RECUERDE!!! AL ELIMINAR LSO DATOS LE VA A SACAR UN ERROR, PUES YA NO HAY RASTRO DE ESTOS ELEMENTOS EN LA LISTA");
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

        static void Imprimir (ArrayList Arreglo)
        {
            foreach (int n in Arreglo)
            {
                Console.WriteLine($" [{n}] ");
            }
        }
    }
}