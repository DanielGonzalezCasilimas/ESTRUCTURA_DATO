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

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
           int num2 = 0;
           int opc = 0;
           int resultado = 0;
           
           Console.WriteLine("Por favor ingrese dos numeros mayores de 100.");
           Console.WriteLine(" ");
           Console.WriteLine("Primer numero: ");
           num1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Segundo numero:");
           num2 = Convert.ToInt32(Console.ReadLine());
           
          if (num1 < 100){
           Console.WriteLine("El pirmer numero no es valido, no podra continuar :(");
          }
          else{
          Console.WriteLine("Puede continuar si el segundo numero es mayor a 100");
 
           if (num2 < 100){
               Console.WriteLine("El segundo numero no es valido :(");
           }
             else{
             Console.WriteLine("Puede continuar.");
             Console.WriteLine(" ");
             
             Console.WriteLine("1. OPERACION DE SUMA");
             Console.WriteLine("2. OPERACION DE RESTA");
             Console.WriteLine("3. OPERACION DE MULTIPLICACION");
             Console.WriteLine("4. OPERACION DE DIVISION");
             Console.WriteLine("Escoja la operacion que desea desarrollar");
             opc = Convert.ToInt32(Console.ReadLine());
 
             switch (opc){
                 case 1:
                 Console.WriteLine("Usted escogio la suma.");
                 resultado = num1+num2;
                 Console.WriteLine("El resultado de la suma de los numeros " + num1+ " y " +num2+ " es:" +resultado);
                 break;
                 case 2:
                 Console.WriteLine("Usted escogio la resta.");
                 resultado = num1-num2;
                 Console.WriteLine("El resultado de la resta de los numeros " + num1+ " y " +num2+ " es:" +resultado);
                 break;
                 case 3:
                 Console.WriteLine("Usted escogio la multiplicacion.");
                 resultado = num1*num2;
                 Console.WriteLine("El resultado de la multiplicacion de los numeros " + num1+ " y " +num2+ " es:" +resultado);
                 break;
                 case 4:
                 Console.WriteLine("Usted escogio la division.");
                 resultado = num1/num2;
                 Console.WriteLine("El resultado de la division de los numeros " + num1+ " y " +num2+ " es:" +resultado);
                 break;
                 default: Console.WriteLine("NO ES UNA OPCION :/"); break;
             }
             Console.ReadKey();
            }
         
        }
    }
}
