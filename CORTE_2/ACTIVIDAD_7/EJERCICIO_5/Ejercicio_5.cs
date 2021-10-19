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
    class Program
    {
        static void Main(string[] args)
        {
            //Programa con Lista, Pila o Cola en el que se pase una lista a otra y al final la primera lista no tenga nada.

            Queue Cola = new Queue();
            Random DatosAleatorios = new Random();

            int Longitud;

            Console.WriteLine("Ingrese la longitud de la lista");
            Longitud = int.Parse(Console.ReadLine());

            for (int i = 0; i < Longitud; i++)
            {
                Cola.Enqueue(DatosAleatorios.Next(0,100));
            }

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la lista");

            foreach (int n in Cola)
            {
                Console.WriteLine($"--  {n}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Se hará una copia de la cola, esta nueva cola se llamará Cola2");

            Queue Cola2 = (Queue)Cola.Clone();

            Console.WriteLine("");
            Console.WriteLine("Contenido de la cola2");

            foreach (int b in Cola2)
            {
                Console.WriteLine($"--  {b}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }

            Console.WriteLine("Ingrese 1 si desea eliminar los datos de la primera");
            Console.WriteLine("RECUERDE!!! AL ELIMINAR LOS DATOS LE VA A SACAR UN ERROR, PUES YA NO HAY RASTRO DE ESTOS ELEMENTOS EN LA COLA");
            int Respuesta = 0;
            Respuesta = int.Parse(Console.ReadLine());

            if (Respuesta == 1)
            {
                Cola.Clear();

                Console.WriteLine("");
                
                foreach (int c in Cola)
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
