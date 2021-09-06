using System;

namespace Problema_9
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
        63102C / 239-2A 
    */
    class Problema_9
    {
        //Programa que muestra el numero de apuestas que son necesarias para que se acierten 5 numeros dados en una loteria
        static void Main(string[] args)
        {

            int Numeros =0;
            int Serie =0;
            Random NumerosApuestas = new Random();

            Console.WriteLine("Digita tus 5 numeros de la lóteria: ");
            do
            {    
                for(int i =0; i < 4; i++)
                {
                    Console.WriteLine($"Digita tu numero {i+1} de la lóteria: ");
                    Numeros = int.Parse(Console.ReadLine());
                }
                if(Numeros <=-1)
                {
                    Console.WriteLine("El numero no puede ser un negativo. Intente de nuevo: ");
                }
                Console.WriteLine($"Digita la serie de la lóteria: ");
                Serie = int.Parse(Console.ReadLine());
                if(Serie <=-1)
                {
                    Console.WriteLine("La serie no puede ser un negativa. Intente de nuevo: ");
                }
                else
                {
                    int[] VectorNumeroApuestas = new int[5];
                    VectorNumeroApuestas[0] = NumerosApuestas.Next(1,100);
                    Console.WriteLine($"El numero de apuestas necesarias son: {VectorNumeroApuestas[0]}");
                }
            }while(Numeros <=-1);
        }
    }
}
