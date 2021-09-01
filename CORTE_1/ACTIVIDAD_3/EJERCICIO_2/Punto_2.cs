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

namespace AplicacionBase
{
    class Punto_2
    {
        /*Crear un programa, que dado un número, compruebe si es adecuado para montar pilas triangulares, si se puede montar realizar la ejecución del programa para que dibuje el triangulo.*/
        static void Main(string[] args)
        {
            int latas, fila = 1, altura = 0;
            
            Console.WriteLine("Bienvenido al apilador de latas: ");
            Console.WriteLine("Por favor ingrese el número de latas: ");
            latas = int.Parse(Console.ReadLine());
            
            
            while (fila <= latas)
            {
                altura += 1;
                latas -= fila;
                fila +=1;
                if(altura>latas)
                {
                    break;

                }
                       
                                 
            }
            Console.WriteLine("La altura de la pirámide es: "+altura);



            for(int i= 1; i <= altura; i++)
            {
                for(int esp = 0; esp < altura - i; esp ++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<i;j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();

            }



        }
    }
}
