using System;

//Desarrolle un porgrama donde se encuntren varias metodos de cadena.

/*
Created by: Daniel Stevan González Casilimas
Group: 239-2A
Shift: Diurno
*/

namespace EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string Cadena;

            Console.WriteLine("Ingrese una cadena por favor");
            Cadena = Console.ReadLine();
            Console.WriteLine("");

            do
            {
                Console.WriteLine("1- Length");           //Calcular longitud de la cadena
                Console.WriteLine("2- SubString (1)");    //Ubicación inicial de la cadena
                Console.WriteLine("3- SubString (2)");    //Ubicación final de la cadena
                Console.WriteLine("4- SubString (3)");    //Mostrar del segundo hasta el sexto letra de la cadena
                Console.WriteLine("5- IndexOf");          //Mostrar la primera letra pedida
                Console.WriteLine("6- ToUpper");          //Convertir cadena en mayuscula
                Console.WriteLine("7- ToLower");          //Convertir cadena en minuscula
                Console.WriteLine("8- Replace");          //Borrar espacios en blanco
                Console.WriteLine("9- Salir");

                Console.Write("Dime una opcion del menú: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Convert.ToString(Cadena.Length);

                        Console.WriteLine("");
                        Console.WriteLine($"La longitud de la cadena es: {Convert.ToString(Cadena.Length)}");
                        Console.WriteLine("");
                    break;

                    case 2:
                        Cadena.Substring(0, 1);

                        Console.WriteLine("");
                        Console.WriteLine($"El primer valor de la cadena es: {Cadena.Substring(0, 1)}");
                        Console.WriteLine("");
                    break;

                    case 3:
                        Cadena.Substring(Cadena.Length - 1, 1);

                        Console.WriteLine("");
                        Console.WriteLine($"El ultimo valor de la cadena es: {Cadena.Substring(Cadena.Length - 1, 1)}");
                        Console.WriteLine("");
                    break;

                    case 4:
                        Cadena.Substring(2, 6);

                        Console.WriteLine("");
                        Console.WriteLine($"Estos son los valores desde el segundo valor hasta el sexto: {Cadena.Substring(2, 6)}");
                        Console.WriteLine("");
                    break;

                    case 5:
                        Convert.ToString(Cadena.IndexOf("a", 0)+1);

                        Console.WriteLine("");
                        Console.WriteLine($"La posicición de la primera letra a es: {Convert.ToString(Cadena.IndexOf("a", 0)+1)}");
                        Console.WriteLine("");
                    break;

                    case 6:
                        Cadena.ToUpper();

                        Console.WriteLine("");
                        Console.WriteLine($"Ahora la cadena está en mayuscula: {Cadena.ToUpper()}");
                        Console.WriteLine("");
                    break;

                    case 7:
                        Cadena.ToLower();

                        Console.WriteLine("");
                        Console.WriteLine($"Ahora la cadena está en minuscula: {Cadena.ToLower()}");
                        Console.WriteLine("");
                    break;

                    case 8:
                        Cadena.Replace(" ","");

                        Console.WriteLine("");
                        Console.WriteLine($"Ahora la cadena se ve así sin los espacios en blanco: {Cadena.Replace(" ","")}");
                        Console.WriteLine("");
                    break;
                }
            } while (opcion != 9);
        }
    }
}
