using System;


//Desarrolle una aplicacion que permita registrar en una Matriz 10 cadenas de caracteres, una vez registradas, las 
//ordenen de forma ascedente, cuente la cantidad de carcateres de cada cadena y la guarde en una segunda Matriz, 
//finalmente, imprima el Promedio de carcateres de la segunda.

namespace EJERCICIO_2
{
    class MatrizConCadenas
    {
        private string [] Matriz1 = new string[10];
        private int [] Matriz2 = new int [10];
        int Longitud;
        int Total;
        float promedio;

        public MatrizConCadenas()
        {
            for(int i = 0; i < Matriz1.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Ingrese el elemento {i+1} de la cadena");
                Matriz1[i] =Console.ReadLine();                 
            }
            
            Longitud = Matriz1.Length;
        }

        public void  Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("Los elementos de la primera Matriz es: ");
            Console.WriteLine("");

            foreach (string M in Matriz1)
            {
                Console.Write($"|{M}|");
            }

            Console.WriteLine("");
            Console.WriteLine($"La Longitud de la cadena es {Longitud}");
        }

        public void MatrizConCadenas2()
        {
            for(int i = 0 ; i < Longitud; i++)
            {
               Matriz2[i] = Matriz1[i].Length;
            }

            Console.WriteLine("");
            Console.WriteLine("Conenido segunda Matriz:");
            Console.WriteLine("");

            foreach (int M2 in Matriz2)
            {
               Console.Write($"|{M2}|");
            }
        }

        public void Promedio()
        {
            foreach (int M2 in Matriz2)
            {
                Total += M2;
            }

            promedio= Total/10;

            Console.WriteLine("");
            Console.WriteLine($"El Promedio de caracteres de la cantidad es: {promedio}");
        }

        static void Main(string[] args)
        {
            MatrizConCadenas Mat = new MatrizConCadenas();
            Mat.Imprimir();
            Mat.MatrizConCadenas2();
            Mat.Promedio();
        }
    }
}
