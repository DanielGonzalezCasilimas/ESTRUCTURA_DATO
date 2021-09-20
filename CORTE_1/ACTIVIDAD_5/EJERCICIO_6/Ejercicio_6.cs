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

namespace AplicacionBase
/*En la clase de estructuras de datos asiste un grupo de N alumnos. El profesor de dicha asignatura aplica 3 exámenes. Realice un programa que genere un array de N alumnos y sus 3 calificaciones y que calcule e imprima:
o El promedio de calificaciones de cada alumno.
o El promedio general de grupo.
o El número del estudiante que tuvo el mayor promedio de calificación.*/
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            int EXAMENES = 3;
            int estudiantes;
            int promedioMayor=0;
            int total_Promedios=0;
            int promedio=0;
            int promedio_General;
            int estudiante_Promedio_Mayor=0;
            Console.WriteLine("Ingrese el número de estudiantes de la clase: ");
            estudiantes = int.Parse(Console.ReadLine());
            int [,] clase_Estructura_Datos = new int[estudiantes,EXAMENES];

            for(int i = 0; i < estudiantes;i++)
            {
                Console.WriteLine($"Ingrese las calificaciones del estudiante {i+1}: ");
                for(int k=0; k < EXAMENES;k++ )
                {
                    Console.Write($"Exámen {k+ 1 } = ");
                    clase_Estructura_Datos[i,k]=int.Parse(Console.ReadLine());
                    promedio += clase_Estructura_Datos[i,k];
                }
                promedio = promedio/3;
                total_Promedios+=promedio;
                if(promedio>promedioMayor)
                {
                    promedioMayor=promedio;
                    estudiante_Promedio_Mayor=i+1;
                    
                }
                Console.WriteLine($"El promedio del estudiante {i+1} es de: {promedio}");
                promedio=0;
            }
            promedio_General=total_Promedios/estudiantes;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"El promedio general del grupo es: {promedio_General}");
            Console.WriteLine($"El mayor promedio es del estudiante {estudiante_Promedio_Mayor} con {promedioMayor}" );
        }
    }
}
