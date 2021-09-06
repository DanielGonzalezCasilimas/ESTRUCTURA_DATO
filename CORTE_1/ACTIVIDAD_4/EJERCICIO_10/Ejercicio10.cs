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

namespace PUNTO_10
{
    class Punto10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A continuación verá una matriz del nivel de los estudiantes de una academia");
            
            int[,] Estudiantes = new int[12, 12];

            Estudiantes[0,0] = 5;
            Estudiantes[0,1] = 7;
            Estudiantes[0,2] = 11;
            Estudiantes[0,3] = 8;
            Estudiantes[1,0] = 14;
            Estudiantes[1,1] = 23;
            Estudiantes[1,2] = 2;
            Estudiantes[1,3] = 10;
            Estudiantes[2,0] = 15;
            Estudiantes[2,1] = 6;
            Estudiantes[2,2] = 25;
            Estudiantes[2,3] = 3;
            
            Console.WriteLine("");
            Console.WriteLine($"En el nivel Básico de Ingles hay : {Estudiantes[0,0]} estudiantes");
            Console.WriteLine($"En el nivel Básico de Francés hay : {Estudiantes[0,1]} estudiantes");
            Console.WriteLine($"En el nivel Básico de Alemán hay : {Estudiantes[0,2]} estudiantes");
            Console.WriteLine($"En el nivel Básico de Ruso hay : {Estudiantes[0,3]} estudiantes");

            Console.WriteLine("");
            Console.WriteLine($"En el nivel Medio de Ingles hay : {Estudiantes[1,0]} estudiantes");
            Console.WriteLine($"En el nivel Medio de Francés hay : {Estudiantes[1,1]} estudiantes");
            Console.WriteLine($"En el nivel Medio de Alemán hay : {Estudiantes[1,2]} estudiantes");
            Console.WriteLine($"En el nivel Medio de Ruso hay : {Estudiantes[1,3]} estudiantes");

            Console.WriteLine("");
            Console.WriteLine($"En el nivel Perfeccionamiento de Ingles hay : {Estudiantes[2,0]} estudiantes");
            Console.WriteLine($"En el nivel Perfeccionamiento de Francés hay : {Estudiantes[2,1]} estudiantes");
            Console.WriteLine($"En el nivel Perfeccionamiento de Alemán hay : {Estudiantes[2,2]} estudiantes");
            Console.WriteLine($"En el nivel Perfeccionamiento de Ruso hay : {Estudiantes[2,3]} estudiantes");

        }
    }
}
