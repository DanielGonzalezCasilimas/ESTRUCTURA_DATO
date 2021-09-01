using System;

namespace Ejer._3_2
{
    class Program
    {
        static void Main(string[] args)
        //Programa que cuando el ususario ingrese 5 numeros bote esa misma cantida de asteriscos por cada numero.
        {
            int num1 = 0, num2 = 2,num3 = 0, num4 = 0, num5 = 5;
            int cont1 = 1, cont2 = 1, cont3 = 1, cont4 = 1, cont5 = 1;
            Console.WriteLine("============================================================");
            Console.WriteLine("Bienvenido al programa.");
            Console.WriteLine("Por favor ingrese el primer numero:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("El numero es: " +num1+ " La cantidad de asteriscos es: ");
            for (cont1 = 1;cont1 <= num1;cont1++ ){
             Console.Write("*");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("============================================================");
            Console.WriteLine("Por favor ingrese el segundo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("El numero es: " +num2+ " La cantidad de asteriscos es: ");
            for( cont2 = 1; cont2 <= num2; cont2++){
                Console.Write("*");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("============================================================");
            Console.WriteLine("Por favor ingrese el tercer numero:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("El numero es: " +num3+ " La cantidad de asteriscos es: ");
            for( cont3 = 1; cont3 <= num3; cont3++){
                Console.Write("*");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("============================================================");
            Console.WriteLine("Por favor ingrese el cuarto numero:");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("El numero es: " +num4+ " La cantidad de asteriscos es: ");
            for( cont4 = 1; cont4 <= num4; cont4++){
                Console.Write("*");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("============================================================");
            Console.WriteLine("Por favor ingrese el quinto numero:");
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("El numero es: " +num5+ " La cantidad de asteriscos es: ");
            for( cont5 = 1; cont5 <= num5; cont5++){
                Console.Write("*");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("GRACIAS POR USAR EL PROGRAMA :); LLEGO AL MAXIMO DE NUMEROS");
            Console.WriteLine("============================================================");
            Console.ReadKey();
        }
    }
}
