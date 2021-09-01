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
namespace Problema_9
{
    class Problema_9
    {   /*Crea un programaque calcule el equivalente humano 
    de la edad de un perro. Los dos  primeros  años  de  vida  
    de  un  perro  equivalen  cada  uno  a  diez  y  medio  años 
    humanos, y los siguientes años de vida de un perro equivalen cada uno a cuatro años humanos.
    */ 
        static void Main(string[] args)
        {
            String Entrada;
            Double Años;
            Double EdadPerro;
            
            Console.WriteLine("");
            Console.WriteLine("Programa que calcula el equivalente de edad humano en años de un perro");

            Console.WriteLine("");
            Console.WriteLine("Ingrese su edad en años");
            Entrada = Console.ReadLine();
            Años = Convert.ToInt32(Entrada);

            if(Años < 0)
            {
                Console.WriteLine();
                Console.WriteLine("No se puede calcular la edad del perro ya que la persona no tiene edad");
            }

            else
            {
                if(Años <= 2 )
                {
                    EdadPerro = Años * 10.5;   

                    Console.WriteLine("");
                    Console.WriteLine("El perro tiene {0} años", EdadPerro);
                }

                else
                {
                    EdadPerro = 21 + (Años - 2) * 4;

                    Console.WriteLine("");
                    Console.WriteLine("El perro tiene {0} años", EdadPerro);
                }
            }
        }
    }
}
