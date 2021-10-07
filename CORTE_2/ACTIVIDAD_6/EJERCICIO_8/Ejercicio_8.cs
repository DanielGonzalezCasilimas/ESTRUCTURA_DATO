using System;
using System.Collections;
using System.Collections.Generic;

namespace Punto_8
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("SU PRIMERA PILA ES: ");
            ArrayList Pila = new ArrayList();
            int Tamaño1 = 10;
            
            Random Aleatorios1 = new Random();
            for(int j = 0; j < Tamaño1; j++){
                Pila.Add(Aleatorios1.Next(1,10));
            }
          imprime(Pila);
          
            Console.WriteLine("SU SEGUNDA PILA ES: ");
            ArrayList Pila2 = new ArrayList();
            int Tamaño2 = 10;
            
            Random Aleatorios2 = new Random();
            for(int i = 0; i < Tamaño2; i++){
                Pila2.Add(Aleatorios2.Next(11,20));
            }
          imprime(Pila2);
          ArrayList pila1 = new ArrayList();
          
         Console.WriteLine("AHORA LOS VALORES DE LA SEGUNDA PILA ESTAN EN LA PRIMERA: ");
         pila1 = Pila;
         Pila = Pila2;
         imprime(Pila);
         Console.WriteLine("AHORA LOS VALORES DE LA PRIMERA PILA ESTAN EN LAS SEGUNDA: ");
         Pila2 = pila1;
         imprime(Pila2);
        }
        static void imprime (ArrayList arreglo){
            foreach(int nums in arreglo)
            {
             Console.Write(" {0} ", nums);
            }
            Console.WriteLine("\n==============");
        }    
    }
}
