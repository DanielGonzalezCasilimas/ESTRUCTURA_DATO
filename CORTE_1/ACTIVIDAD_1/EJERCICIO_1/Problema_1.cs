using System;

/*GROUP MEMBERS 

 Roa Ruiz Maria Camila
 Barbosa Fierro Luis Esteban
 Cardona Acuña David Esteban
 González Casilimas Daniel Stevan

 SHIFT
 diurnal

 GROUP
 63102C / 239-2A 
*/
namespace Problema_1
{
    class Problema_1
    {

        /*
        Escribir  un  programa  que,  dado  un  número  real  cualquiera,
        encuentre  su  valor absoluto. El valor absoluto de un número x
        es igual a x si x > 0, y a -x si x es menor o igual a 0.
        */

        static void Main(string[] args)
        {
            int Numero;

            Console.WriteLine("Ingrese un número:");
            Numero = int.Parse(System.Console.ReadLine());

            if (Numero > 0)
            {
                //El Math.Abs nos ayuda a devolver el valor del mismo tipo y lo especifica como valor absoluto
                Console.WriteLine("El número es {0} y el valor absoluto es: {1}.",Numero, Math.Abs(Numero));
            }
            else if (Numero < 0)
            {
                Console.WriteLine("El número es {0} y el valor absoluto es: {1}.",Numero, Math.Abs(Numero));
            }

            Console.WriteLine("Gracias por digitar.");
        }
    }
}
