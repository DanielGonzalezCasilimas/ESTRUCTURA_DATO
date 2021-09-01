using System;
using System.Linq;
using System.Collections.Generic;

namespace AplicacionBase
{
    /*
    GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    SHIFT
        diurnal
    GROUP

        63102C / 239-2A */
    class Program
    /*Crearun programa que pida 10 números, el programa debe preguntar si quieren organizarlo de mayor a menor o de menor a mayor y al final se debe ejecutar el proceso que se haya seleccionado.Problema 5:
    */
    {
        static void Main(string[] args)
        
        {
            int N1, N2,N3,N4,N5,N6,N7,N8,N9,N10;

            List <int> Lista = new List<int>();

            Console.WriteLine("Ingrese el #1: ");

            N1 = int.Parse(Console.ReadLine());

            Lista.Add(N1);

            Console.WriteLine("Ingrese el #2: ");
            N2 = int.Parse(Console.ReadLine());
            Lista.Add(N2);

            Console.WriteLine("Ingrese el #3: ");
            N3 = int.Parse(Console.ReadLine());
            Lista.Add(N3);

            Console.WriteLine("Ingrese el #4: ");
            N4 = int.Parse(Console.ReadLine());
            Lista.Add(N4);

            Console.WriteLine("Ingrese el #5: ");
            N5 = int.Parse(Console.ReadLine());
            Lista.Add(N5);

            Console.WriteLine("Ingrese el #6: ");
            N6 = int.Parse(Console.ReadLine());
            Lista.Add(N6);

            Console.WriteLine("Ingrese el #7: ");
            N7 = int.Parse(Console.ReadLine());
            Lista.Add(N7);

            Console.WriteLine("Ingrese el #8: ");
            N8 = int.Parse(Console.ReadLine());
            Lista.Add(N8);
            
            Console.WriteLine("Ingrese el #9: ");
            N9 = int.Parse(Console.ReadLine());
            Lista.Add(N9);

           Console.WriteLine("Ingrese el #10: ");
           N10 = int.Parse(Console.ReadLine());
           Lista.Add(N10);

           Console.WriteLine("Desea organizarlos de forma ascendente (A) o descendente (D): ");
           char Opcion = char.Parse(Console.ReadLine());

           if(Opcion== 'A' || Opcion == 'a')
           {
               int [] A = Lista.ToArray();
               Array.Sort(A);
               foreach (int numero in A)
               {
                   Console.WriteLine(numero + " ");
               }
               
           }
           if(Opcion=='D'||Opcion == 'd')
           {
               int [] D = Lista.ToArray();
               D = D.OrderByDescending(numero=>numero).ToArray();
               foreach (int numero in D)
               {
                   Console.WriteLine(numero + " ");
               }

           }

            
        }
    }
}
