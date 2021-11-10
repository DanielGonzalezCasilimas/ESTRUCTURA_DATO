using System;
using System.Collections;

/*
    Created by: Daniel Stevan Gonzalez Casilimas 

    Shift: Diurno

    Group: 63102C / 239-2A
*/

//Desarrolle una aplicacion que permita desde un arraylist previamente cargado con cadenas de caractere, substraer los 
//priemros 4 caracteres de cada elemento del arraylist y que los guarde en una cola.

namespace EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();
            int Salir = 0;
        
            do 
            {
                Console.WriteLine("Ingrese las cadenas que desea y escriba 'continuar' para Continuar");

                string Cadenas = Console.ReadLine();

                if (Cadenas == "continuar")
                {
                    Salir = 100;
                }

                else
                {
                    Lista.Add(Cadenas);
                }
            } while (Salir != 100);

            Console.WriteLine("");
            Console.WriteLine("Contenido actual");
            foreach (string n in Lista)
            {
                Console.WriteLine($" [{n}] ");
            }

            string[] Cadena = new string[Lista.Count];
            Lista.CopyTo(Cadena);

            Queue Cola = new Queue(Lista.Count);
            string[] Cadena2 = new string[Lista.Count];

            for (int c = 0; c < Lista.Count; c++)
            {
                Cadena2[c] = Cadena[c].Substring(0, 4);
            }

            for (int c = 0; c < Lista.Count; c++)
            {
                Cola.Enqueue(Cadena2[c]);
            }

            Console.WriteLine("");
            Console.WriteLine("Los priemros caracteres de los elemneto ya se encuentran en la Cola");
            Console.WriteLine("Primeros caracteres de los elementos");
            foreach (string Colas in Cola)
            {
                Console.WriteLine($" [{Colas}] ");
            }

        }
    }
}
