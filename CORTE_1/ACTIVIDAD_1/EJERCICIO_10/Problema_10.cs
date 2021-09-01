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
namespace Problema_10
{
    class Problema_10
    {   /*Crea un programaque pida una contraseña por teclado e indique si es correcta o incorrecta. 
        La contraseña correcta es “iloveyou123”. Una vez funcione, añade código para que si la contraseña era incorrecta la pida de nuevo.
        */
        static void Main(string[] args)
        {

            string contraseña;
            do
            {
                Console.WriteLine("Ingrese su contraseña:");
                contraseña = Console.ReadLine();
                Console.WriteLine("");

                if(contraseña != "iloveyou123" )
                {
                    Console.WriteLine("Contraseña Incorrecta.");
                }
                Console.WriteLine("");
                
            } while (contraseña != "iloveyou123");


            Console.WriteLine("Contraseña Correcta.");
            Console.WriteLine("");
            Console.WriteLine("Bienvenido.");
        }
    }
}
