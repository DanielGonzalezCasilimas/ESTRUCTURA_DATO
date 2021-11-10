using System;
using System.Collections;

//Created by: Daniel Stevan González Casilimas
//Group: 239-2A
//Shift: Diurno

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            Queue miCola = new Queue();

            do
            {
                Console.WriteLine("1- Enqueue");     // Agregar un elemento a la cola
                Console.WriteLine("2- Dequeue");     // Borrar un elemento de la cola
                Console.WriteLine("3- Clear");       // Limpiar toda a cola
                Console.WriteLine("4- Contains");    // Ubicar un elemento en la cola
                Console.WriteLine("5- Salir");

                Console.Write("Dime una opcion del menú: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.Write("Introduce un número para la cola:  ");
                        numero = int.Parse(Console.ReadLine());

                        miCola.Enqueue(numero);

                        Console.WriteLine("");
                        Console.Write("Contenido Actual");

                        Console.WriteLine("");
                        Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                        Console.WriteLine("");

                        foreach (int n in miCola)
                        {
                            Console.WriteLine($"--  {n}  --");
                            Console.WriteLine("---------");
                            Console.WriteLine("");
                        }
                    break;

                    case 2:
                        numero = (int)miCola.Dequeue();

                        Console.WriteLine("");
                        Console.WriteLine($"El valor obtenido es: {numero}");

                        Console.WriteLine("");
                        Console.Write("Contenido Actual");

                        Console.WriteLine("");
                        Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                        Console.WriteLine("");

                        foreach (int n in miCola)
                        {
                            Console.WriteLine($"--  {n}  --");
                            Console.WriteLine("---------");
                            Console.WriteLine("");
                        }
                    break;

                    case 3:
                        miCola.Clear();

                        Console.WriteLine("");
                        Console.WriteLine("La cola ha sido limpiada");

                        Console.WriteLine("");
                        Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                        Console.WriteLine("");

                        foreach (int n in miCola)
                        {
                            Console.WriteLine($"--  {n}  --");
                            Console.WriteLine("---------");
                            Console.WriteLine("");
                        }
                    break;

                    case 4:
                        Console.WriteLine("");
                        Console.Write("Dame el valor a encontrar:  ");
                        numero = int.Parse(Console.ReadLine());

                        encontrado = miCola.Contains(numero);
                    
                        Console.WriteLine("");

                        Console.WriteLine("");
                        Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                        Console.WriteLine("");

                        foreach (int n in miCola)
                        {
                            Console.WriteLine($"--  {n}  --");
                            Console.WriteLine("---------");
                            Console.WriteLine("");
                        }
                    break;
                }
            } while (opcion != 5);
        }
    }
}