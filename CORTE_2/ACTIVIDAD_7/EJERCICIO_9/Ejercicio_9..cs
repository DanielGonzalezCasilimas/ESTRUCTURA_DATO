using System;
using System.Collections;
using System.Collections.Generic;
namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Nombres = new Queue();
            Console.WriteLine("=======================================");
            Console.WriteLine("SU COLA ES DE NOMBRES: ");
            Nombres.Enqueue("-Maria");
            Nombres.Enqueue("-Camila");
            Nombres.Enqueue("-Daniel");
            Nombres.Enqueue("-David");
            Nombres.Enqueue("-Luis");
            Nombres.Enqueue("-Esteban");
            Nombres.Enqueue("-Michel");
            Nombres.Enqueue("-Andrea");

            foreach( string nombres in Nombres){
                Console.WriteLine($" {nombres}");
            }
            string[] array1 = new string[Nombres.Count*2];
            Nombres.CopyTo(array1, Nombres.Count);

            Queue<string> queueCopy1 = new Queue<string>(array1);

            Console.WriteLine("======================================= ");
            Console.WriteLine(" ");
            Console.WriteLine("SE HA CREADO UNA COPIA DE LA COLA EXISTOSAMENTE!!");
            Console.WriteLine("SU COPIA ES LA SIGUIENTE: ");

            foreach(string nomb in queueCopy1){
                Console.WriteLine($"{nomb}");
            }
             
           Console.WriteLine("======================================= ");
        }
    }
}
