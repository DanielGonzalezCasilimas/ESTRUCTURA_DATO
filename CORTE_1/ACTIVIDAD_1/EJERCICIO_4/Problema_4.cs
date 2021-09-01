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
namespace Problema_4
{
    class Problema_4
    {
        static void Main(string[] args)
        {
            /*
            Considere siguiente proceso repetitivo para un número entero dado: si el número es 1, 
            el proceso termina. De lo contrario, si es par se divide entre 2, y si es impar se multiplica 
            por 3 y se le suma 1. Si empezamos con 6, por ejemplo, obtendremos la sucesión de números 6, 3, 10, 5, 16, 8, 4, 2, 1. 
            La conjetura de Collatz dice que, a  partir  de  cualquier  número  inicial,  la  sucesión  obtenida  siempre  termina  en  1.
            Escriba un programa que permita verificar la conjetura de Collatz para cualquier entero dado, y que imprima la secuencia correspondiente.
            */

            int i = int.Parse(Console.ReadLine());
            {
                while(i!=1)
                {
                    if (i%2==0)
                    {
                        i = i/2;
                    }
                    else
                    {
                        i = (i * 3)+1;
                    }
                    Console.WriteLine(i);
                }
            } 
        }
    }
}
