using System;

namespace AplicacionBase
{
    class Punto_7
    {
        /*
    GROUP MEMBERS:
        Roa Ruiz María Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    
    SHIFT:
        Diurnal

    GROUP:
        63102C / 239-2A */
        static void Main(string[] args)
        {
            /*Realizar un programa que pida al usuario dos números y una letra: “i” ó “p”. El programa presentará los números pares (si se pulsó la “p”) ó impares (si se pulsó la “i”) que hay desde el primer número al segundo que introdujo el usuario. Si se pulsa alguna tecla distinta de “p” ó “i”, el programa no imprime ningún número.*/

            int whileLoop = 1;

            do
            {
                int Numero1,Numero2;
                char Opcion;
                Console.WriteLine("Bienvenido a la aplicación de pares e impares!!");

                Console.WriteLine("Ingrese el #1: ");
                Numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el #2: ");
                Numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la letra P, para mostrar números pares o I, para mostrar los números impares: ");

                Opcion= char.Parse(Console.ReadLine());

                if(Opcion =='P'||Opcion=='p')
                {
                    Console.WriteLine("Ha ingresado la opción de números pares: ");
                    for(int i = Numero1;i<=Numero2;i++)
                    {
                        if(i%2==0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                if(Opcion == 'I'||Opcion=='i')
                {
                    Console.WriteLine("Ha ingresado la opción de números impares: ");
                    for(int i = Numero1;i<=Numero2;i++)
                    {
                        if(i%2!=0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ha ingresado una opción inválida");
                }
                Console.WriteLine("Gracias...");
                Console.WriteLine();
                Console.WriteLine("Ingrese 0 para salir: ");

                whileLoop = int.Parse(Console.ReadLine());
            }
            while(whileLoop != 0);

            
            
        }
    }
}
