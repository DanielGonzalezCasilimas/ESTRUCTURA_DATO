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

namespace AplicacionBase
//Modifica el programa para que me indique por medio de un menú que si quiero ingresar o que los números que se introducen en el array se generen de forma aleatoria (valores entre 100 y 999).
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            int opcion=0,longitud_Array;
            int salir=1;
        do{
            Console.Write("Ingrese la longitud del vector: ");
            longitud_Array=int.Parse(Console.ReadLine());
            int [] Array = new int [longitud_Array];
            Console.WriteLine();
            Console.WriteLine("Menú:");
            Console.WriteLine("----------");
            Console.WriteLine("1.Los números se generan aleatoria.");
            Console.WriteLine("2. Los números los ingresa el usuario.");
            Console.WriteLine("Ingrese una opción");
            opcion=int.Parse(Console.ReadLine());

            Random aleatorio = new Random();

           if(opcion==1)
            {
                for (int i = 0; i < longitud_Array; i++)
                {
				Array [i] = aleatorio.Next (100,999);
                }
			}
            if(opcion==2)
            {
                for(int i = 0; i < longitud_Array;i++)
                {
                    Console.Write($"Ingrese el número del elemento {i+1}: ");
                    Array[i]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Números del array:");
            for(int i= 0;i < longitud_Array;i++ )
            {
                Console.Write($"|{Array [i]}|");
            }
            Console.WriteLine();
            Console.WriteLine("Para salir del programa ingrese 0");
            salir=int.Parse(Console.ReadLine());         
        }
        while(salir!=0);

        Console.WriteLine("Gracias");
        
        }
    }
}

