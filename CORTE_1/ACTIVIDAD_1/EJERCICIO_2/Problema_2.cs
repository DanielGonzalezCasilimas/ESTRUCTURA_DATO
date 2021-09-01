using System;
/*GROUP MEMBERS

 Roa Ruiz Maria Camila
 Barbosa Fierro Luis Esteban
 Cardona Acuña David Esteban
 González Casilimas Daniel Stevan

 SHIFT
 diurnal

 GROUP
 63102C / 239-2A */
namespace Problema_2
{
    class Problema_2
    {
        /*En un videoclub se ofrece la promoción de llevarse tres películas 
        por el precio de las dos más baratas. Haga un programa que, 
        dados los tres precios de las películas, determine la cantidad a pagar
        */

        static void Main(string[] args)
        {
            string Entrada;
            double Pel1;
            double Pel2;
            double Pel3;
            double Cant;

            Console.WriteLine("");
            Console.WriteLine("Videoclub");
            Console.WriteLine("---------");
            Console.WriteLine("");
            Console.WriteLine("Promoción");
            Console.WriteLine("---------");
            Console.WriteLine("Llevarse tres peliculas por el precio de las dos más baratas");

            Console.WriteLine("");
            Console.WriteLine("Ingrese el precio de la primera pelicula");
            Entrada = Console.ReadLine();
            Pel1 = Convert.ToInt32(Entrada);

            Console.WriteLine("");
            Console.WriteLine("Ingrese el precio de la segunda pelicula");
            Entrada = Console.ReadLine();
            Pel2 = Convert.ToInt32(Entrada);

            Console.WriteLine("");
            Console.WriteLine("Ingrese el precio de la tercera pelicula");
            Entrada = Console.ReadLine();
            Pel3 = Convert.ToInt32(Entrada);

            if (Pel1 > Pel2 && Pel1 > Pel3)
            {
                Cant = Pel2 + Pel3;

                Console.WriteLine("");
                Console.WriteLine("Sabiendo que la primera pelicula cuesta ${0}, la segunda pelicula cuesta ${1} y la tercera pelicual cuesta ${2}. Entonces el total a pagar es: ${3}", Pel1, Pel2, Pel3, Cant);
            }
                
                if (Pel2 > Pel1 && Pel2 > Pel3)
                {
                    Cant = Pel1 + Pel3;

                    Console.WriteLine("");
                    Console.WriteLine("Sabiendo que la primera pelicula cuesta ${0}, la segunda pelicula cuesta ${1} y la tercera pelicual cuesta ${2}. Entonces el total a pagar es: ${3}", Pel1, Pel2, Pel3, Cant);
                }

                    if (Pel3 > Pel1 && Pel3 > Pel2)
                    {
                        Cant = Pel1 + Pel2;

                        Console.WriteLine("");
                        Console.WriteLine("Sabiendo que la primera pelicula cuesta ${0}, la segunda pelicula cuesta ${1} y la tercera pelicual cuesta ${2}. Entonces el total a pagar es: ${3}", Pel1, Pel2, Pel3, Cant);
                    }
            Console.ReadKey();
        }
    }
}
