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
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que crea pasa una Cola C a una Pila P pero manteniendo el orden de salida, y al final la Cola no debe tener nada. 
        
            Queue Cola = new Queue();
            Random DatosAleatorios = new Random();

            int Longitud;

            Console.WriteLine("Ingrese la longitud de la cola");
            Longitud = int.Parse(Console.ReadLine());

            for (int i = 0; i < Longitud; i++)
            {
                Cola.Enqueue(DatosAleatorios.Next(0,100));
            }

            Console.WriteLine("");
            Console.WriteLine("Contenido actual de la Cola");

            foreach (int c in Cola)
            {
                Console.WriteLine($"--  {c}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Se hará una copia de la cola para pasarla a una Pila");

            int[] Pila = new int[Cola.Count];

            Cola.CopyTo(Pila,0);

            Console.WriteLine("");
            Console.WriteLine("Contenido de la Pila");

            foreach (int p in Pila)
            {
                Console.WriteLine($"--  {p}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }

            Console.WriteLine("Ingrese 1 si desea eliminar los datos de la Cola");
            Console.WriteLine("RECUERDE!!! AL ELIMINAR LOS DATOS LE VA A SACAR UN ERROR, PUES YA NO HAY RASTRO DE ESTOS ELEMENTOS EN LA COLA");
            int Respuesta = 0;
            Respuesta = int.Parse(Console.ReadLine());

            if (Respuesta == 1)
            {
                Cola.Clear();

                Console.WriteLine("");
                foreach (int c in Cola)
                {
                    Console.WriteLine($"--  {c}  --");
                    Console.WriteLine("---------");
                    Console.WriteLine("");
                }

                Console.WriteLine("SE ELIMINARON TODOS LOS ELEMENTOS DE LA COLA");
            }

            else
            {
                Console.WriteLine("Decidio no eliminar los datos de la primera lista");
            }
        }
    }
}