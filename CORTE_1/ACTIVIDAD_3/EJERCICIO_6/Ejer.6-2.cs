using System;

namespace Ejer._6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que me permite ver los numeros pares desde el numero que ingrese el usuario mayor que 100 hasta 200
            Console.WriteLine("============================================================");
            Console.WriteLine("Bienvenido al programa!");
            int num1 = 0;
            int cont =1;
            Console.WriteLine("Por favor ingrese un numero entre (100) y (200)");
            num1 = Convert.ToInt32(Console.ReadLine());

            if(num1 < 100){
             Console.WriteLine("El numero no es valido, debe ser mayor a 100");
             Console.WriteLine("============================================================");
            }
            if (num1 > 200){
             Console.WriteLine("El numero sobrepasa el valor maximo, por favor ingrese un numero menor a (200)");
             Console.WriteLine("============================================================");
            }
           
            for(cont = num1; cont < 200; cont++){
            if(cont % 2 == 0){
                Console.Write("{0}|", cont);
                num1 ++;
            }
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("============================================================");
        }
    }
}
