using System;

/*
Created By : Daniel Stvena González Casilimas
Shift : diurnal
Group : 63102C / 239-2A 
*/

//Desarrolle una app que permita registrar "n" estudiantes por teclado, asimismo, permita registrar "n" calificaciones 
//por cada uno y finalmente, calcular el promedio de calificaciones de los aprobados y reprobados.

namespace EJERCICIO_1
{
    class Estudiantes
    {
        private float Examenes = 0f;
        private float Estudiante = 0f;
        private float Promedio = 0f;
        private float Sumatoria = 0f;
        private float Total_Promedios = 0f;
        private float Promedio_General = 0f;
        private float Aprobado = 0f;
        private float Reprobado = 0f;
        private float PromedioAprobados = 0f;
        private float PromedioReprobados = 0f;
        private float TotalAprobados = 0f;
        private float TotalReprobados = 0f;

        public Estudiantes()
        {
            Console.WriteLine("CONSTRUCTOR");
            Console.WriteLine("Ingrese el número de estudiantes de la clase: ");
            Estudiante = float.Parse(Console.ReadLine());
        }

        public void Promedios()
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el número de calificaciones: ");
            Examenes = float.Parse(Console.ReadLine());

            float [,] Lista_Estudiantes = new float[(int)Estudiante,(int)Examenes];

            for(int i = 0; i < Estudiante;i++)
            {
                Sumatoria = 0f;
                Promedio = 0f;
                Console.WriteLine($"Ingrese las calificaciones del estudiante {i+1} ");
                for(int k=0; k < Examenes;k++ )
                {
                    Console.Write($"Exámen {k+1 } = ");
                    Lista_Estudiantes[i,k] = float.Parse(Console.ReadLine());
                    Sumatoria += Lista_Estudiantes[i,k];
                }

                Promedio = Sumatoria/Examenes;
                Total_Promedios += Promedio;

                Console.WriteLine($"El promedio del estudiante {i+1} es de: {Promedio}");
                
                if (Promedio > 3.5)
                {
                    Aprobado += Promedio;
                    PromedioAprobados ++; 
                }

                else 
                {
                    Reprobado += Promedio;
                    PromedioReprobados++;
                }

            }

            Promedio_General=Total_Promedios/Estudiante;
            TotalAprobados = Aprobado/PromedioAprobados;
            TotalReprobados = Reprobado/PromedioReprobados;
            
        }

        public void Imprimir()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"El promedio general del grupo es: {Promedio_General}");
            Console.WriteLine($"El promedio de Aprobados es: {TotalAprobados}");
            Console.WriteLine($"El promedio de Reprobado es: {TotalReprobados}");
        }

        static void Main(string[] args)
        {
            Estudiantes Metodo = new Estudiantes();
            Metodo.Promedios();
            Metodo.Imprimir();
            Console.ReadKey();
        }
    }
}
