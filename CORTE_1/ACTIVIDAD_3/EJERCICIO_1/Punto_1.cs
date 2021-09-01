using System;

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

namespace PUNTO1
{
    class Punto_1
    {
        static void Main(string[] args)
        {
            int Entrada;
            
            Console.WriteLine("Ingrese un número porfavor");
            Entrada = int.Parse(System.Console.ReadLine());
            Console.WriteLine("");

            for (int i=1; i <= Entrada; i++)
            {
                for (int n=1; n <= i; n++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }

            
            
        }
    }
}
