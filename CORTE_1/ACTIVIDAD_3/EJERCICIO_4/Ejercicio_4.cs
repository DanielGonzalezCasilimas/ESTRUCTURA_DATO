using System;

namespace Problema_4
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
    class Ejercicio_4
    {
        /*Realizar un programa que calcule la suma:
         *1 + ⅟2!+ ⅟3!+ ... + ⅟n!
         *Donde N lo especifica el usuario.
        */
        static void Main(string[] args)
        {
            double N;
            double OperacionNumerador, OperacionDenominador;
            

            Console.WriteLine("Digita el valor de N:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            OperacionNumerador = 1 + (1 * 3) + (1 * 2) + 1;
            OperacionDenominador =  2 * 3 * N;

            
            Console.WriteLine($"El resultado es: {OperacionNumerador} / {OperacionDenominador}");
        }
    }
}
