using System;

//Created by: Daniel Stevan González Casilimas
//Group: 239-2A
//Shift: Diurno

//Continuar la aplicación "Calculadora" pero ahora desarrolle los métodos necesarios para "restar", multiplicar y 
//dividir dos numeros

namespace EJERCICIO_3
{
    class Calculadora2
    {
        private int A = 0;
        private int B = 0;

        public Calculadora2()
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

        public void Restar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La resta de A y B es: {A - B}");
        }

        public void Multiplicar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La multiplicación de A y B es: {A * B}");
        }

        public void Dividir()
        {
            Console.WriteLine("");
            Console.WriteLine($"La división de A y B es: {A / B}");
        }
        
        static void Main(string[] args)
        {
            Calculadora2 Ca = new Calculadora2();
            Ca.Sumar();
            Ca.Restar();
            Ca.Multiplicar();
            Ca.Dividir();
            Console.ReadKey();
        }
    }
}
