using System;
using System.Collections;

/*
    Created by: Daniel Stevan Gonzalez Casilimas 

    Shift: Diurno

    Group: 63102C / 239-2A
*/

//Desarrolle una aplicacion que permita cargar con cadenas de caracteres un arraylist de "n" elementos, y a continuacion,
//cree dos vectores con las cadenas de caracteres en minusculas y mayusculas, en consecuencia, será 1 arralsit  que se 
//cargara desde la consola y dos vectores con las mismas cadenas de caracteres; una en minuscula y otra en mayuscula.


namespace EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();
            int Salir = 0;
        
            do 
            {
                Console.WriteLine("Ingrese las cadenas que desea y escriba 'salir' para salir");

                string Cadenas = Console.ReadLine();

                if (Cadenas == "salir")
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

            string[] Cadena1 = new string[Lista.Count];
            Lista.CopyTo(Cadena1);

            string[] Cadena2 = new string[Lista.Count];
            Lista.CopyTo(Cadena1);

            for (int c = 0; c < Lista.Count; c++)
            {
                Cadena2[c] = Cadena1[c].ToUpper();
            }

            Console.WriteLine("");
            Console.WriteLine("Estas cadenas estan en Minúscula");

            foreach (string C in Cadena2)
            {
                Console.WriteLine($"  {C}  ");
                Console.WriteLine("");
            }

            for (int c = 0; c < Lista.Count; c++)
            {
                Cadena1[c] = Cadena2[c].ToLower();
            }

            Console.WriteLine("");
            Console.WriteLine("Estas cadenas estan en Mayúscula Minúscula");
            
            foreach (string C in Cadena1)
            {
                Console.WriteLine($"  {C}  ");
                Console.WriteLine("");
            }

        }
    }
}