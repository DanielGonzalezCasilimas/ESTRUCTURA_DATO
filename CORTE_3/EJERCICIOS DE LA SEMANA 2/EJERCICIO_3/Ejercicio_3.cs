using System;

//Desarrolle un programa que permita cargar un vector con 5 cadenas de carácteres, una vez cargado, permita convertir las 5 cadenas de carácteres en mayúsculas y con ello, llenar un nuevo vector.
//Debe mostrar los dos vectores; el que tiene las 5 cadenas en minúsculas y el que tiene las 5 cadenas en mayúsculas.

/*
Created by: Daniel Stevan González Casilimas
Group: 239-2A
Shift: Diurno
*/

namespace EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cadena1 = new string[5];
            string[] Cadena2 = new string[5];
            int LONGITUD = 5;

            for (int c = 0; c < LONGITUD; c++)
            {
                Console.Write($"Ingrese la cadena {c+1} : ");
                Cadena1[c] = Console.ReadLine();
            }

            for (int c = 0; c < LONGITUD; c++)
            {
                Cadena2[c] = Cadena1[c].ToUpper();
            }

            Console.WriteLine("");
            Console.WriteLine("Estas 5 Cadenas están en minúsculas");

            foreach (string Cadenas in Cadena1)
            {
                Console.WriteLine($"  {Cadenas}  ");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Estas 5 Cadenas están en mayúsculas");

            foreach (string Cadenas in Cadena2)
            {
                Console.WriteLine($"  {Cadenas}  ");
                Console.WriteLine("");
            }
        }
    }
}
