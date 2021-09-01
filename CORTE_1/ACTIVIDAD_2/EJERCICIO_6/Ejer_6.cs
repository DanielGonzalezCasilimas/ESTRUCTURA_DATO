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

namespace Ejer._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada2;
            int entrada = 0;
            int opc = 0;
            Console.WriteLine("BIENVENIDO. :)");
            Console.WriteLine("Por favor escoja la opcion que desee entre 1 y 2.");
            Console.WriteLine("1. PROGRAMA PARA PASAR UN NUMERO A LETRAS.");
            Console.WriteLine("2. PROGRAMA PARA PASAR UN NUMERO DE LETRAS EN NUMEROS.");
            opc = Convert.ToInt32(Console.ReadLine());
            
            if (opc == 1){
                Console.WriteLine("Usted escogio la primera opcion :)");
                Console.WriteLine("");
                Console.WriteLine("Ingrese un valor entre 1 y 5:");
              entrada = Convert.ToInt32(Console.ReadLine());
              switch (entrada){
                case 1: 
                Console.WriteLine("Uno");
                break;
                case 2: 
                Console.WriteLine("Dos");
                break;
                case 3: 
                
                Console.WriteLine("Tres");
                break;
                case 4: 
                Console.WriteLine("Cuatro");
                break;
                case 5: 
                Console.WriteLine("Cinco");
                break;
                default: Console.WriteLine("Se ingreso un valor fuera de rango"); break;
              }
            }
           
           if (opc ==2){
               Console.WriteLine("Usted escogio la segunda opcion :)");
               Console.WriteLine("");
               Console.WriteLine("Ingrese un número en español entre uno y cinco:");
               entrada2 = Console.ReadLine();
               switch (entrada2){
                case "Uno": 
                Console.WriteLine(1);
                break;
                case "Dos": 
                Console.WriteLine(2);
                break;
                case "Tres": 
                Console.WriteLine(3);
                break;
                case "Cuatro": 
                Console.WriteLine(4);
                break;
                case "Cinco": 
                Console.WriteLine(5);
                break;
                default: Console.WriteLine("Debe ingresar un valor entre uno y cinco"); break;
                }
           }
           Console.ReadKey();
        }
    }
}
