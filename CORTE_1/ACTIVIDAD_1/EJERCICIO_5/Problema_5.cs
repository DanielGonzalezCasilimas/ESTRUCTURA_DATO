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
namespace Problema_5
{
    class Program
    {   /*
        Calcule la raíz cuadrada de un número dado.  Recuerde que se debe validar que el número sea positivo.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un numero para sacar la raiz cuadrada:");
            double num1 = 0;
            double resultado = 0;
           num1 = Convert.ToInt32(Console.ReadLine());
           
           if(num1 <= 0){
               Console.WriteLine("El programa no se ejecutara ya que ingreso un numero negativo.");
            }  
           else{
            resultado = Math.Sqrt(num1); 
           }
           
           Console.WriteLine("La raiz cuadrada de: " + num1 + " es:  "+ resultado);
        }
    }
}
