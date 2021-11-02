using System;


//Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor, calcular su suma, resta, 
//multiplicación y división, cada una en un método, imprimir dichos resultados.

namespace EJERCICIO_2
{
    class Operaciones
    {
        private int NumeroA = 0;
        private int NumeroB = 0;

        public Operaciones()
        {
            Console.WriteLine("CONSTRUCTOR");
            Console.WriteLine("Ingrese el primer valor");
            NumeroA = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el segundo valor");
            NumeroB = int.Parse(Console.ReadLine()); 
        }

        public void Sumar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La suma de A y B es: {NumeroA + NumeroB}");
        }

        public void Restar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La resta de A y B es: {NumeroA - NumeroB}");
        }

        public void Multiplicar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La multiplicación de A y B es: {NumeroA * NumeroB}");
        }

        public void Dividir()
        {
            Console.WriteLine("");
            Console.WriteLine($"La división de A y B es: {NumeroA / NumeroB}");
        }
        
        static void Main(string[] args)
        {
            Operaciones Ca = new Operaciones();
            Ca.Sumar();
            Ca.Restar();
            Ca.Multiplicar();
            Ca.Dividir();
            Console.ReadKey();
        }
    }
}
