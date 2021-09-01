using System;

namespace AplicacionBase
{
    /*

    GROUP MEMBERS:
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
 
    SHIFT:
        diurnal

    GROUP:

        63102C / 239-2A */
    class Punto_10
    {
        static void Main(string[] args)
        //Elaborar un algoritmo para calcular e imprimir el precio de un terreno del cual se tienen los siguientes datos:  largo,  ancho  y precio por metro  cuadrado,  si  el  terreno tiene más  de  400  metros  cuadrados  se hace un descuento del 10% si el terreno tiene más de 500 metros cuadrados el descuento es del 17% y si tiene más de 1000 metros cuadrados el descuento es del 25%.
        {
            float Largo,Ancho,Área,Precio;
            double Descuento, PrecioTotal;
            Console.WriteLine("¿Cuál es el precio por metro cuadrado: ");
            Precio = float.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese la medida del largo del terreno en metros:  ");
            Largo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la medida del ancho en metros: ");
            Ancho = float.Parse(Console.ReadLine());

            Área = Largo * Ancho;

            PrecioTotal = Precio * Área;

            
            if(Área > 400)
            {
                if(Área > 500)
                {
                    if(Área>1000)
                    {
                        Console.WriteLine("Tiene un descuento del 25%");

                        Descuento = PrecioTotal * 0.25;

                        PrecioTotal = PrecioTotal - Descuento;
                        Console.WriteLine($"En total son {Área}m^2. Debe pagar ${PrecioTotal}");

                    }
                    else
                    {
                        Console.WriteLine("Tiene un descuento del 17%");
                        Descuento = PrecioTotal * 0.17;

                        PrecioTotal = PrecioTotal - Descuento;
                        Console.WriteLine($"En total son {Área}m^2. Debe pagar ${PrecioTotal}");

                    }

                }
                else
                {
                    Console.WriteLine("Tiene un descuento del 10%");
                    
                    Descuento = PrecioTotal * 0.10;

                    PrecioTotal = PrecioTotal - Descuento;

                    Console.WriteLine($"En total son {Área}m^2. Debe pagar ${PrecioTotal}");

                }                
                
            }
            else
            {
                Console.WriteLine("No tiene descuento.");

                Console.WriteLine($"En total son {Área}m^2, debe pagar ${PrecioTotal}");

            }

        }
    }
}
