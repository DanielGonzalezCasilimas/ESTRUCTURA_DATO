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

namespace PUNTO11
{
    class Punto_11
    {
        static void Main(string[] args)
        {
            int Entrada;
            int CantidadMujeres;
            int CantidadHombres;
            int SaldoMujeres = 0;
            int SaldoHombres = 0;
            int GananciaMujeres1 = 0;
            int GananciaMujeres2 = 0;
            int GananciaHombres1 = 0;
            int GananciaHombres2 = 0;
            int AcumuladorMujer = 0;
            int AcumuladorHombre = 0;

            Console.WriteLine("");
            Console.WriteLine("EMPRESA");
            Console.WriteLine("=======");
            Console.WriteLine("");
            Console.WriteLine("Ingrese 1 para empleados mujeres y 2 para empleados hombres");
            Entrada = int.Parse(System.Console.ReadLine());

            if (Entrada == 1 )
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese la cantidad de empleadas mujeres");
                CantidadMujeres = int.Parse(System.Console.ReadLine());

                for (int i = 1; i <= CantidadMujeres; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digite el sueldo de cada empleada");
                    Console.WriteLine("Digite el valor de la empleada " + i);
                    SaldoMujeres = int.Parse(System.Console.ReadLine());

                    if (SaldoMujeres > 1000000)
                    {
                        GananciaMujeres1++;
                    }

                    else if (SaldoMujeres < 1000000)
                    {
                        GananciaMujeres2++;
                    }
                    AcumuladorMujer += SaldoMujeres;
                }
                Console.WriteLine("");
                Console.WriteLine("La cantidad de empleadas mujeres son: {0}", CantidadMujeres);
                Console.WriteLine("La cantidad de mujeres que ganan más de $1.000.000 son: {0}", GananciaMujeres1);
                Console.WriteLine("La cantidad de mujeres que ganan menos de $1.000.000 son: {0}", GananciaMujeres2);
                Console.WriteLine("La suma total de dinero de las empleadas mujeres son: ${0}", AcumuladorMujer);
            }

            if (Entrada == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese la cantidad de empleados hombres");
                CantidadHombres = int.Parse(System.Console.ReadLine());

                for (int n = 1; n <= CantidadHombres; n++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digite el sueldo de cada empleado");
                    Console.WriteLine("Digite el valor del empleado " + n);
                    SaldoHombres = int.Parse(System.Console.ReadLine());

                    if (SaldoHombres > 900000)
                    {
                        GananciaHombres1++;
                    }

                    else if (SaldoHombres < 900000)
                    {
                        GananciaHombres2++;
                    }
                    AcumuladorHombre += SaldoHombres;
                }
                Console.WriteLine("");
                Console.WriteLine("La cantidad de empleados hombres son: {0}", CantidadHombres);
                Console.WriteLine("La cantidad de hombres que ganan menos de $900.000 son: {0}", GananciaHombres2);
                Console.WriteLine("La cantidad de hombres que ganan más de $900.000s son: {0}", GananciaHombres1);
                Console.WriteLine("La suma total de dinero de los empleados hombres son: ${0}", AcumuladorHombre);
            }
        }
    }
}