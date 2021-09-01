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

namespace Punto8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            int Num;

            Console.WriteLine("");
            Console.WriteLine("Ingrese un mes (1-12)");
            Entrada = Console.ReadLine();
            Num = Convert.ToInt32(Entrada);

            if (Num == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("ENERO");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 31 días");
            }

            if (Num == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("FEBRERO");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 28 días");
            }

            if (Num == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("MARZO");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 31 días");
            }

            if (Num == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("ABRIL");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 30 días");
            }

            if (Num == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("MAYO");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 31 días");
            }

            if (Num == 6)
            {
                Console.WriteLine("");
                Console.WriteLine("JUNIO");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 30 días");
            }

            if (Num == 7)
            {
                Console.WriteLine("");
                Console.WriteLine("JULIO");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 31 días");
            }

            if (Num == 8)
            {
                Console.WriteLine("");
                Console.WriteLine("AGOSTO");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 31 días");
            }

            if (Num == 9)
            {
                Console.WriteLine("");
                Console.WriteLine("SEPTIEMBRE");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 30 días");
            }

            if (Num == 10)
            {
                Console.WriteLine("");
                Console.WriteLine("OCTUBRE");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 31 días");
            }

            if (Num == 11)
            {
                Console.WriteLine("");
                Console.WriteLine("NOVIEMBRE");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 30 días");
            }

            if (Num == 12)
            {
                Console.WriteLine("");
                Console.WriteLine("DICIEMBRE");
                Console.WriteLine("=====");
                Console.WriteLine("Tiene 31 días");
            }

            else
            if (Num < 0 || Num > 12)
            {
                Console.WriteLine("");
                Console.WriteLine("Lo lamento, has ingresado un valor fuera del rango permitido");
            }
        }
    }
}
