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
{
    /*Crear un programa que me dé la opción de escoger la cantidad de niveles que debe tener un triángulo Ingresar 3 datos y decir qué clase de triangulo es. Para formar un triángulo hay que tener en cuenta que la suma de sus dos lados inferiores tiene que ser mayor al lado superior*/
    class Punto_9
    {
        static void Main(string[] args)
        {
            int LadoS,Lado1,Lado2;
            Console.WriteLine("Ingresar el tamaño del lado superior: ");
            LadoS = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño del lado: ");
            Lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño del lado: ");
            Lado2 = int.Parse(Console.ReadLine());

            if((Lado1+Lado2)<LadoS)
            {
                if(Lado1 == Lado2 && Lado1 == LadoS && Lado2==LadoS)
                {
                    Console.WriteLine("Es un triángulo equilátero");

                }
                if(Lado1 == Lado2 || Lado2==LadoS || LadoS == Lado1)
                {
                    Console.WriteLine("Es un triángulo isóceles");
                }
                else
                {
                    Console.WriteLine("Es un triángulo escaleno");
                }
                                
            }
            else
            {
                Console.WriteLine("No es un triángulo");

            }


        }
    }
}
