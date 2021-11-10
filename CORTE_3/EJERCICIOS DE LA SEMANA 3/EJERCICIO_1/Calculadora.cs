using System;

//Created by: Daniel Stevan González Casilimas
//Group: 239-2A
//Shift: Diurno

//Crear clase llamada calculadora que permita recibir y crear método que permita sumar dos valores (a + b). 
//Y que los imprima

namespace EJERCICIO_1
{
    class Calculadora
    {
        private int A = 0;
        private int B = 0;
        private int Suma = 0;
        
        public Calculadora()
        {
            Console.WriteLine("CONSTRUCTOR");
            Console.WriteLine("Ingrese valor A");
            A = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese valor B");
            B = int.Parse(Console.ReadLine()); 
        }

        public void Sumar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La suma de A y B es: {A + B}");
        }

        public (int,int,int) SumaAtributos (int aa, int bb)
        {
            A = aa;
            B = bb; 
            Suma = A + B;

            return(A,B,Suma);
        }

        public void Imprimir ()
        {
            Console.WriteLine("");
            Console.WriteLine($"La suma de A y B es: {A} + {B} = {Suma}");
        }

        static void Main(string[] args)
        {
            Calculadora Ca = new Calculadora();
            Ca.Sumar();

            Console.WriteLine("");
            Console.WriteLine("AHORA CON ATRIBUTOS");
            Console.WriteLine("Ingrese valor A");
            int AA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor B");
            int BB = int.Parse(Console.ReadLine());

            Ca.SumaAtributos(AA,BB);

            Ca.Imprimir();

            Console.ReadKey();
        }
    }
}