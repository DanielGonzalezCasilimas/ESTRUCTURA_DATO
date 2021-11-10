using System;
using System.Collections;

//Created by: Daniel Stevan González Casilimas
//Group: 239-2A
//Shift: Diurno

namespace Ejercicio_2
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
                Console.WriteLine("5- Peek");        // Mirar primer valor en la cola
                Console.WriteLine("6- ToArray");     // Crear una copia de la cola a un Array
                Console.WriteLine("7- Clone");       // Creaar una copia superficial de la cola
                Console.WriteLine("8- Salir");

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

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine($"El primer valor de la cola es: {miCola.Peek()}");

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

                    case 6:
                        Queue queueCopy = new Queue(miCola.ToArray());
                        //Queue queueCopy = (Queue)miCola.ToArray();

                        Console.WriteLine("");
                        Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                        Console.WriteLine("");

                        Console.WriteLine("El contenido de la primera copia con los valores restantes: ");

                        foreach (int n in queueCopy)
                        {
                            Console.WriteLine($"--  {n}  --");
                            Console.WriteLine("---------");
                            Console.WriteLine("");
                        }
                    break;

                    case 7:
                        Console.WriteLine("");
                        Console.WriteLine("Se hará una copia de la cola, esta nueva cola se llamará miCola2");

                        Queue miCola2 = (Queue)miCola.Clone();

                        Console.WriteLine("");
                        Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                        Console.WriteLine("");

                        foreach (int n in miCola2)
                        {
                            Console.WriteLine($"--  {n}  --");
                            Console.WriteLine("---------");
                            Console.WriteLine("");
                        }
                    break;
                }
            } while (opcion != 8);
        }
    }
}