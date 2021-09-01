using System;

namespace Problema_3
{
    class Problema_3
    {
        static void Main(string[] args)
        {
            //Escriba un programa que reciba cuatro calificaciones de un estudiante y devuelva el promedio y la máxima calificación.

            int Notas;
            int Mayor = 0;
            int Menor = 0; 
            int Promedio;
            int i;
            int Nota1, Nota2, Nota3, Nota4;
            //Console.WriteLine("Digita cuantas notas vas a ingresar:");
            //cant = int.Parse(Console.ReadLine());//

            //utilizamos la i para el contador
            //contador inicia en cero y debe llegar a 4
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Digita la nota:");
                Notas = int.Parse(Console.ReadLine());

                //cada ingreso de nota cambia su valor y se vuelve a calcular
                if (i == 0)
                {
                    Mayor = Notas;
                    Menor = Notas;
                }
                else if (i != 0)
                {
                    if (Notas < Menor)
                    {
                        Menor = Notas; 
                    }
                    if (Notas > Mayor)
                    {
                        Mayor = Notas;
                    }
                }    
            }
            
            Console.WriteLine("");
            Console.WriteLine("Ingresa las notas de nuevo para saber su promedio.");
            Console.WriteLine("Ingresa la primera nota:");
            Nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la primera nota:");
            Nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la primera nota:");
            Nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la primera nota:");
            Nota4 = int.Parse(Console.ReadLine());
            
            Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            
            Console.WriteLine("");
            Console.WriteLine("Tu Maxima calificacion es:"+Mayor);
            Console.WriteLine("Tu Minima calificacion es:"+Menor);
            Console.WriteLine("Tu Promedio es:"+Promedio);
        }
    }
}
