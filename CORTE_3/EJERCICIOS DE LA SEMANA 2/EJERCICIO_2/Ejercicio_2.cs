using System;

//Desarrolle un programa donde use las funciones o metodos "Substring" y "IndexOf".

/*
Created by: Daniel Stevan González Casilimas
Group: 239-2A
Shift: Diurno
*/

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cadena;

            Console.WriteLine("Nombre completo por favor");
            Cadena = Console.ReadLine();   

            Console.WriteLine(""); 
            Console.WriteLine("Buscar valores dentro de un rango");  
            Console.WriteLine(""); 

            Cadena.Substring(3, 10);
            Console.WriteLine($"Estos son los valores desde el tercer valor hasta el decimo: {Cadena.Substring(3, 10)}");

            Console.WriteLine(""); 
            Console.WriteLine("Buscamos la posición de la primera letra a");   

            Convert.ToString(Cadena.IndexOf("a", 0)+1);
            Console.WriteLine($"La posicición de la primera letra A es: {Convert.ToString(Cadena.IndexOf("a", 0)+1)}");
        }
    }
}
