using System;

namespace Problema_10
{
    /*  *GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
        *SHIFT
        diurnal
        *GROUP
        63102C / 239-2A 
    */
    class Problema_10
    {
        /*
        En Colombia se tienen 3 puntos de reparto de vacunas que se pretende funcionen de la siguiente manera. 
        Cada día, empezar con 1000 vacunas disponibles en cada punto y a través de un programa que controla las entregas avisar 
        si el inventario baja de 200 unidades, al final el programa debe generar un reporte de la cantidad de vacunas utilizadas en cada punto.
        */
        static void Main(string[] args)
        {
            int Vacunas, Vacunass;
            int LugarUno, LugarDos, LugarTres, CantidadUno = 1000, CantidadDos = 1000, CantidadTres = 1000;
            

            Console.WriteLine("En este momento hay 3000 Vacunas, 1000 en cada punto (3).");
            Console.WriteLine("Usted se encuentra en el punto de entrega N°.1...");
            Console.WriteLine("¿Cuantas Vacunas quiere entregar en el punto 1?:");
            LugarUno = int.Parse(Console.ReadLine());
            if (LugarUno >=800 )
            {
                Console.WriteLine($"Usted ha entregado {LugarUno} unidades de vacunas disponibles. Ha bajado de las 200 unidades estipuladas.");
                CantidadUno = CantidadUno - LugarUno;
                Console.WriteLine($"En este momento se tiene {CantidadUno} vacunas disponibles en el punto N°1 .");
            }
            else
            {
                CantidadUno = CantidadUno - LugarUno;
                Console.WriteLine($"En este momento hay {CantidadUno} unidades de vacunas disponibles.");
            }
            Console.WriteLine("");
            

            Console.WriteLine("Usted se encuentra en el punto de entrega N°.2...");
            Console.WriteLine("¿Cuantas Vacunas quiere entregar en el punto 2?:");
            LugarDos = int.Parse(Console.ReadLine());
            if (LugarDos >=800 )
            {
                Console.WriteLine($"Usted ha entregado {LugarDos} unidades de vacunas disponibles. Ha bajado de las 200 unidades estipuladas.");
                CantidadDos = CantidadDos - LugarDos;
                Console.WriteLine($"En este momento se tiene {CantidadDos} vacunas disponibles en el punto N°2 .");
            }
            else
            {
                CantidadDos = CantidadDos - LugarDos;
                Console.WriteLine($"En este momento hay {CantidadDos} unidades de vacunas disponibles.");
            }
            Console.WriteLine("");


            Console.WriteLine("Usted se encuentra en el punto de entrega N°.3...");
            Console.WriteLine("¿Cuantas Vacunas quiere entregar en el punto 3?:");
            LugarTres = int.Parse(Console.ReadLine());
            if (LugarTres >=800 )
            {
                Console.WriteLine($"Usted ha entregado {LugarTres} unidades de vacunas disponibles. Ha bajado de las 200 unidades estipuladas.");
                CantidadTres = CantidadTres - LugarTres;
                Console.WriteLine($"En este momento se tiene {CantidadTres} vacunas disponibles en el punto N°3 .");
            }
            else
            {
                CantidadTres = CantidadTres - LugarTres;
                Console.WriteLine($"En este momento hay {CantidadTres} unidades de vacunas disponibles.");
            }
            Console.WriteLine("");
            Vacunas = CantidadUno + CantidadDos + CantidadTres;
            Vacunass = LugarUno + LugarDos + LugarTres;

            if (Vacunas ==0 )
            {
                Console.WriteLine($"Se ha finalizado las entregas de vacunas. Se tienen {Vacunas} vacunas disponibles.");
            }
            Console.WriteLine("");
            Console.WriteLine($"En el punto N°1 se han entregado {LugarUno}");
            Console.WriteLine($"En el punto N°2 se han entregado {LugarDos}");
            Console.WriteLine($"En el punto N°3 se han entregado {LugarTres}");
            Console.WriteLine("");
            Console.WriteLine($"Han quedado un total de {Vacunas} unidades de vacunas disponibles. Se han entregado en total una cantidad de: {Vacunass}");
            Console.WriteLine("Se ha finalizado las entregas de vacunas.");
        }
    }
}
