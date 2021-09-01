using System;

namespace Problema_8
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
    class Problema_8
    {
        /*Realizar un programa que pida dos números y presente por pantalla la ecuación de segundo 
        grado que tiene por soluciones estos dos números. Ejemplo: 5 y -3, la ecuación sería 
        (x+5) (x-3) = x 2x-15, los coeficientes son 1, 2 y -15. El programa permitirá repetir 
        esta operación tantas veces como el usuario quiera, introduciendo números diferentes, hasta que decida terminar el programa (por ejemplo pulsando ‘S’). 
        */
        static void Main(string[] args)
        {
            int NumeroUno;
            int NumeroDos;
            string Loop;
            do
            {
                Console.WriteLine("Digite Primer numero:");
                NumeroUno = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite Segundo numero:");
                NumeroDos = int.Parse(Console.ReadLine());
                Console.WriteLine("");


                if (NumeroUno >=0 && NumeroDos >=0)
                {
                    Console.WriteLine($"La ecuación es: (x+{NumeroUno}) (x+{NumeroDos})");
                }
                if(NumeroUno <0 && NumeroDos <0)
                {
                    Console.WriteLine($"La ecuación es: (x{NumeroUno}) (x{NumeroDos})");
                }
                if(NumeroUno <0 && NumeroDos >=0)
                {
                    Console.WriteLine($"La ecuación es: (x{NumeroUno}) (x+{NumeroDos})");
                }
                if(NumeroUno>=0 && NumeroDos<0)
                {
                    Console.WriteLine($"La ecuación es: (x+{NumeroUno}) (x{NumeroDos})");
                }

                int Coeficiente = NumeroUno * NumeroDos;
                Console.WriteLine($"Los coeficientes son: 1  2  {Coeficiente}");

                Console.WriteLine("Desea continuar con otra ejecucion?: S/N:");
                Loop = Console.ReadLine();

            }while( Loop == "S" || Loop =="s");
        }
    }
}
