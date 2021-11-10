using System;
using System.Collections;

//Created by: Daniel Stevan González Casilimas
//Group: 239-2A
//Shift: Diurno

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Longitud = 0;
            
            Console.WriteLine("Programa que multiplica los datos de dos colas y muestra el resultado en una tercera cola");

            Console.WriteLine("");
            Console.WriteLine("Ingrese la longitud de la cola");
            Longitud = int.Parse(Console.ReadLine());

            Random DatosAleatorios = new Random();

            Queue Cola1 = new Queue();
            Queue Cola2 = new Queue();

            for (int i = 0; i < Longitud; i++)
            {
                Cola1.Enqueue(DatosAleatorios.Next(1,99));
                Cola2.Enqueue(DatosAleatorios.Next(1,99));
            }

            int[] CopyCola1 = new int[Cola1.Count];
            int[] CopyCola2 = new int[Cola2.Count];

            Cola1.CopyTo(CopyCola1,0);
            Cola2.CopyTo(CopyCola2,0);

            int[] Resultado = new int[Longitud];

            for(int i = 0; i < Longitud; i++)
            {
                Resultado[i] = CopyCola1[i] * CopyCola2[i];
            }

            Queue Cola3 = new Queue(Resultado);

            Console.WriteLine("");
            Console.WriteLine("Contenido de los datos de la Cola 1");

            Console.WriteLine("");
            Console.WriteLine("COLA 1");
            Imprimir(Cola1);

            Console.WriteLine("");
            Console.WriteLine("Contenido de los datos de la Cola 2");

            Console.WriteLine("");
            Console.WriteLine("COLA 2");
            Imprimir(Cola2);
            
            Console.WriteLine("");
            Console.WriteLine("Contenido de los datos de la Cola 3");

            Console.WriteLine("");
            Console.WriteLine("COLA 3");
            Imprimir(Cola3);
            
            Console.WriteLine("");
            Console.WriteLine("En conclusión... ");

            for (int i = 0; i < Longitud; i++)
            {
                Console.WriteLine($" - {CopyCola1[i]} * {CopyCola2[i]} = {Resultado[i]}");
                Console.WriteLine("   --------------");
            }
        }

        static void Imprimir (Queue Colas)
        {
            foreach (int c in Colas)
            {
                Console.WriteLine($"--  {c}  --");
                Console.WriteLine("---------");
                Console.WriteLine("");
            }
        }
    }
}
