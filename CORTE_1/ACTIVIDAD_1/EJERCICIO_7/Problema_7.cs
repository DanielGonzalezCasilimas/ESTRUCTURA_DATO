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
namespace Problema_7
{
    class Problema_7
    {

        static void Main(string[] args)
        {
            int total,promedio;

            Console.WriteLine("");
            Console.WriteLine("Ingrese el número de ventas de A: ");
            Console.WriteLine("");
            Console.WriteLine("El producto A es el más vendido(Es mayor a 400)");
            
            Console.WriteLine("");
            Console.WriteLine("Ningún producto tiene ventas inferiores de 200");

            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese  el número de ventas de B: ");
            Console.WriteLine("");
            Console.WriteLine("El producto B no es el más vendido");
            
            
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Ingrese el número de ventas de C: ");
            Console.WriteLine("");
            Console.WriteLine("Ningún producto tiene ventas inferior de 200");

            int C = int.Parse(Console.ReadLine());

            total = A + B + C;

            promedio = total/3;

            Console.WriteLine("");
            Console.WriteLine("El total de las ventas es de: "+total);

            Console.WriteLine("");
            Console.WriteLine("El promedio de las ventas es de: "+promedio);

            Console.WriteLine("");
            Console.WriteLine("¡AVISO!");
            Console.WriteLine("-------");
            Console.WriteLine("");
            Console.WriteLine("Estos son los valorees correctos");

            int AA = 600;
            int BB = 400;
            int CC = 500;
            int Suma;             
            int Promedio;

            Suma = AA + BB + CC; 
            Promedio = Suma / 3;
            
            Console.WriteLine("");
            Console.WriteLine("¿Cual es el valor de A, B y C?");

            Console.WriteLine("");
            Console.WriteLine("El valor de A es: {0}", AA);

            Console.WriteLine("");
            Console.WriteLine("El valor de B es: {0}", BB);

            Console.WriteLine("");
            Console.WriteLine("El valor de C es: {0}", CC);

            Console.WriteLine("");
            Console.WriteLine("Sabiendo que {0} + {1} + {2} = {3} y el promedio de este es: {4}", AA, BB, CC, Suma, Promedio);
        }
    }
}
