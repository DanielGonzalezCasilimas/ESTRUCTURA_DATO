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

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Entrada;
            int Par = 0;
            int Impar = 0;
            int Suma1 = 0;
            int Suma2 = 0;
            int Promedio1 = 0;
            int Promedio2 = 0;
            
            Console.WriteLine("");
            Console.WriteLine("Ingrese 10 números evaluando pares e impares");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite el numero " + i);
                Entrada = int.Parse(System.Console.ReadLine());
                
                if (Entrada % 2 == 0)
                {
                    Par++;
                    Suma1 += Entrada;
                    Promedio1 = Suma1 / Par;
                }
                
                else
                if (Entrada % 2 !=0)
                {
                    Impar++;
                    Suma2 += Entrada;
                    Promedio2 = Suma2 / Impar;
                }
                
            }

            Console.WriteLine("");
            Console.WriteLine("De los 10 numeros ingresados, la cantidad de pares obtenida es: {0}", Par);
            Console.WriteLine("La suma de los numeros pares es : {0}", Suma1);
            Console.WriteLine("El promedio de los numeros pares es : {0}", Promedio1);

            Console.WriteLine("");
            Console.WriteLine("De los 10 numeros ingresados, la cantidad de numeros Impares: {0}", Impar);
            Console.WriteLine("La suma de los numeros impares es : {0}", Suma2);
            Console.WriteLine("El promedio de los numeros impares es : {0}", Promedio2);
        }
    }
}
