using System;

namespace Problema_5
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
        63102C / 239-2A */
    class Problema_5
    {
        /*
        Crear un programa que identifique la fecha actual y que pida una fecha anterior 
        se requiere que el programa calcule los años, meses y días que han pasado en el intervalo de años.
        */
        static void Main(string[] args)
        {
            int FechaAntiguaMes, FechaAntiguaAño, FechaAntiguaDia;
            int FechaActualMes = 08, FechaActualAño = 2021, FechaActualDia = 20;
            
            Console.WriteLine("Bienvenido ingrese una fecha antigua.");
            Console.WriteLine("");
            Console.WriteLine("Digite Año:");
            FechaAntiguaAño = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite Mes:");
            FechaAntiguaMes = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite Dia:");
            FechaAntiguaDia = int.Parse(System.Console.ReadLine());

            FechaActualAño = FechaActualAño - FechaAntiguaAño;

            FechaActualMes = FechaActualMes - FechaAntiguaMes;

            FechaActualDia = FechaActualDia - FechaAntiguaDia;

            Console.WriteLine($"Actualmente han pasado {FechaActualAño} Año/s, {FechaActualMes} Mes/es, {FechaActualDia} Dia/s.");
        }
    }
}
