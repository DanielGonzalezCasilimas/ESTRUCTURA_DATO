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
namespace Problema_6
{
    class Problema_6
    {
        static void Main(string[] args)
        {
            //Crea un programa que dado un número entero que designa un periodo de tiempo expresado en segundos, imprima el equivalente en días, horas, minutos

            int Segundos;
            int Minutos, Dias, Horas;
            Console.WriteLine("Ingresa tus segundos:");
            Console.WriteLine("Tu resultado saldrá con numeros enteros...");
            Segundos = int.Parse(Console.ReadLine());

            Dias = Segundos / 86400;
            Horas = Segundos / 3600;
            Minutos = Segundos / 60;

            Console.WriteLine("");
            Console.WriteLine("Tus {0} Segundos equivalen a {1} Dias, {2} Horas, {3} Minutos y {4} Segundos", Segundos, Dias, Horas, Minutos, Segundos);
            Console.WriteLine("");
            Console.WriteLine("Gracias por Digitar");


        }
    }
}
