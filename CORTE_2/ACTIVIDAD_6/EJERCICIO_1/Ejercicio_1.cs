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

namespace EJERCICIO_1
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();
            int Salir = 0;
            do 
            {
                Console.WriteLine("Ingrese los numeros de la lista y ingrese 0 para salir");

                int NumLista = int.Parse(Console.ReadLine());

                if (NumLista == 0)
                {
                    Salir = 100;
                }

                else
                {
                    Lista.Add(NumLista);
                }
            } while (Salir != 100);

            Lista.Sort();
            Console.WriteLine();

            foreach (int n in Lista)
            {
                Console.WriteLine($" [{n}] ");
            }

        }
    }
}
