using System;

namespace Problema_1
{
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
    class Problema_1
    {
        /*
        Crear un programa que pida una calificación de 0 a 100 para las materias de Matemáticas, 
        español, inglés y Física para 5 estudiantes que se registren al iniciar el programa los resultados 
        deberán mostrar la información de la siguiente manera:Insuficiente (Menor a 50) Suficiente (De 50 a 59)
        Bien (De 60 a 69) Notable (De 70 a 89) Sobresaliente (De 90 a 100) en cada estudiante y materia.
        */
        static void Main(string[] args)
        {
            int NotaEs1, NotaEs2, NotaEs3, NotaEs4;
            int NotaEs21, NotaEs22, NotaEs23, NotaEs24;
            int NotaEs31, NotaEs32, NotaEs33, NotaEs34;
            int NotaEs41, NotaEs42, NotaEs43, NotaEs44;
            int NotaEs51, NotaEs52, NotaEs53, NotaEs54;


            do
            {
                Console.WriteLine("Hola Estudiante 1:");
                Console.WriteLine("¡Digite una nota de 0 a 100!");
                Console.Write("Para la materia de Matematicas:");
                NotaEs1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Español:");
                NotaEs2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Ingles:");
                NotaEs3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Fisica:");
                NotaEs4 = int.Parse(Console.ReadLine());

                if (NotaEs1 <=-1 || NotaEs1 >=101 || NotaEs2 <=-1 || NotaEs2 >=101 || NotaEs3 <=-1 || NotaEs3 >=101 || NotaEs4 <=-1 || NotaEs4 >=101)
                {
                Console.WriteLine("Las notas distintas a 0 o 100 son erroneas.");
                }
            }while(NotaEs1 <=-1 || NotaEs1 >=101 || NotaEs2 <=-1 || NotaEs2 >=101 || NotaEs3 <=-1 || NotaEs3 >=101 || NotaEs4 <=-1 || NotaEs4 >=101);

            Console.WriteLine("__________________________________________________");

            do
            {
                Console.WriteLine("Hola Estudiante 2:");
                Console.WriteLine("¡Digite una nota de 0 a 100!");
                Console.WriteLine("Para la materia de Matematicas:");
                NotaEs21 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Español:");
                NotaEs22 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Ingles:");
                NotaEs23 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Fisica:");
                NotaEs24 = int.Parse(Console.ReadLine());

                if(NotaEs21 <=-1 || NotaEs21 >=101 || NotaEs22 <=-1 || NotaEs22 >=101 || NotaEs23 <=-1 || NotaEs23 >=101 || NotaEs24 <=-1 || NotaEs24 >=101)
                {
                    Console.WriteLine("Las notas distintas a 0 o 100 son erroneas.");
                }
            }while(NotaEs21 <=-1 || NotaEs21 >=101 || NotaEs22 <=-1 || NotaEs22 >=101 || NotaEs23 <=-1 || NotaEs23 >=101 || NotaEs24 <=-1 || NotaEs24 >=101);

            Console.WriteLine("__________________________________________________");

            do
            {
                Console.WriteLine("Hola Estudiante 3:");
                Console.WriteLine("¡Digite una nota de 0 a 100!");
                Console.WriteLine("Para la materia de Matematicas:");
                NotaEs31 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Español:");
                NotaEs32 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Ingles:");
                NotaEs33 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Fisica:");
                NotaEs34 = int.Parse(Console.ReadLine());

                if(NotaEs31 <=-1 || NotaEs31 >=101 || NotaEs32 <=-1 || NotaEs32 >=101 || NotaEs33 <=-1 || NotaEs33 >=101 || NotaEs34 <=-1 || NotaEs34 >=101)
                {
                    Console.WriteLine("Las notas distintas a 0 o 100 son erroneas.");
                }
            }while(NotaEs31 <=-1 || NotaEs31 >=101 || NotaEs32 <=-1 || NotaEs32 >=101 || NotaEs33 <=-1 || NotaEs33 >=101 || NotaEs34 <=-1 || NotaEs34 >=101);

            Console.WriteLine("__________________________________________________");

            do
            {
                Console.WriteLine("Hola Estudiante 4:");
                Console.WriteLine("¡Digite una nota de 0 a 100!");
                Console.WriteLine("Para la materia de Matematicas:");
                NotaEs41 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Español:");
                NotaEs42 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Ingles:");
                NotaEs43 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Fisica:");
                NotaEs44 = int.Parse(Console.ReadLine());

                if(NotaEs41 <=-1 || NotaEs41 >=101 || NotaEs42 <=-1 || NotaEs42 >=101 || NotaEs43 <=-1 || NotaEs43 >=101 || NotaEs44 <=-1 || NotaEs44 >=101)
                {
                    Console.WriteLine("Las notas distintas a 0 o 100 son erroneas.");
                }
            }while(NotaEs41 <=-1 || NotaEs41 >=101 || NotaEs42 <=-1 || NotaEs42 >=101 || NotaEs43 <=-1 || NotaEs43 >=101 || NotaEs44 <=-1 || NotaEs44 >=101);

            Console.WriteLine("__________________________________________________");

            do
            {
                Console.WriteLine("Hola Estudiante 5:");
                Console.WriteLine("¡Digite una nota de 0 a 100!");
                Console.WriteLine("Para la materia de Matematicas:");
                NotaEs51 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Español:");
                NotaEs52 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Ingles:");
                NotaEs53 = int.Parse(Console.ReadLine());

                Console.WriteLine("Para la materia de Fisica:");
                NotaEs54 = int.Parse(Console.ReadLine());

                if(NotaEs51 <=-1 || NotaEs51 >=101 || NotaEs52 <=-1 || NotaEs52 >=101 || NotaEs53 <=-1 || NotaEs53 >=101 || NotaEs54 <=-1 || NotaEs54 >=101)
                {
                    Console.WriteLine("Las notas distintas a 0 o 100 son erroneas.");
                }
            }while(NotaEs51 <=-1 || NotaEs51 >=101 || NotaEs52 <=-1 || NotaEs52 >=101 || NotaEs53 <=-1 || NotaEs53 >=101 || NotaEs54 <=-1 || NotaEs54 >=101);
            
            //-----------------------------------------------------------------------------------------

            Console.WriteLine("ESTUDIANTE 1:");
            if(NotaEs1 < 50)
            {
                Console.WriteLine($"Tu nota para Matemáticas es {NotaEs1}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs1 >= 50 && NotaEs1 < 60)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs1}, siendo Suficiente.");
            }
            else if(NotaEs1 >= 60 && NotaEs1 <= 69)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs1}, siendo Bien.");
            }
            else if(NotaEs1 >= 70 && NotaEs1 < 90)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs1}, siendo Notable.");
            }
            else if(NotaEs1 >= 90 && NotaEs1 <= 100)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs1}, siendo Sobresaliente.");
            }

            //-----------------------------------------------------------------------------------------------------

            if(NotaEs2 < 50)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs2}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs2 >= 50 && NotaEs2 < 60)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs2}, siendo Suficiente.");
            }
            else if(NotaEs2 >= 60 && NotaEs2 <= 69)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs2}, siendo Bien.");
            }
            else if(NotaEs2 >= 70 && NotaEs2 < 90)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs2}, siendo Notable.");
            }
            else if(NotaEs2 >= 90 && NotaEs2 <= 100)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs2}, siendo Sobresaliente.");
            }

            //-------------------------------------------------------------------------------------------------------

            if(NotaEs3 < 50)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs3}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs3 >= 50 && NotaEs3 < 60)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs3}, siendo Suficiente.");
            }
            else if(NotaEs3 >= 60 && NotaEs3 <= 69)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs3}, siendo Bien.");
            }
            else if(NotaEs3 >= 70 && NotaEs3 < 90)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs3}, siendo Notable.");
            }
            else if(NotaEs3 >= 90 && NotaEs3 <= 100)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs3}, siendo Sobresaliente.");
            }

            //---------------------------------------------------------------------------------------------------------

            if(NotaEs4 < 50)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs4}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs4 >= 50 && NotaEs4 < 60)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs4}, siendo Suficiente.");
            }
            else if(NotaEs4 >= 60 && NotaEs4 <= 69)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs4}, siendo Bien.");
            }
            else if(NotaEs4 >= 70 && NotaEs4 < 90)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs4}, siendo Notable.");
            }
            else if(NotaEs4 >= 90 && NotaEs4 <= 100)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs4}, siendo Sobresaliente.");
            }

            //--------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------

            Console.WriteLine("ESTUDIANTE 2:");
            if(NotaEs21 < 50)
            {
                Console.WriteLine($"Tu nota para Matemáticas es {NotaEs21}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs21 >= 50 && NotaEs21 < 60)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs21}, siendo Suficiente.");
            }
            else if(NotaEs21 >= 60 && NotaEs21 <= 69)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs21}, siendo Bien.");
            }
            else if(NotaEs21 >= 70 && NotaEs21 < 90)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs21}, siendo Notable.");
            }
            else if(NotaEs21 >= 90 && NotaEs21 <= 100)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs21}, siendo Sobresaliente.");
            }

            //-----------------------------------------------------------------------------------------------------

            if(NotaEs22 < 50)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs22}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs22 >= 50 && NotaEs22 < 60)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs22}, siendo Suficiente.");
            }
            else if(NotaEs22 >= 60 && NotaEs22 <= 69)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs22}, siendo Bien.");
            }
            else if(NotaEs22 >= 70 && NotaEs22 < 90)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs22}, siendo Notable.");
            }
            else if(NotaEs22 >= 90 && NotaEs22 <= 100)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs22}, siendo Sobresaliente.");
            }

            //-------------------------------------------------------------------------------------------------------

            if(NotaEs23 < 50)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs23}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs23 >= 50 && NotaEs23 < 60)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs23}, siendo Suficiente.");
            }
            else if(NotaEs23 >= 60 && NotaEs23 <= 69)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs23}, siendo Bien.");
            }
            else if(NotaEs23 >= 70 && NotaEs23 < 90)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs23}, siendo Notable.");
            }
            else if(NotaEs23 >= 90 && NotaEs23 <= 100)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs23}, siendo Sobresaliente.");
            }

            //---------------------------------------------------------------------------------------------------------

            if(NotaEs24 < 50)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs24}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs24 >= 50 && NotaEs24 < 60)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs24}, siendo Suficiente.");
            }
            else if(NotaEs24 >= 60 && NotaEs24 <= 69)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs24}, siendo Bien.");
            }
            else if(NotaEs24 >= 70 && NotaEs24 < 90)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs24}, siendo Notable.");
            }
            else if(NotaEs24 >= 90 && NotaEs24 <= 100)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs24}, siendo Sobresaliente.");
            }

            //--------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------

            Console.WriteLine("ESTUDIANTE 3:");
            if(NotaEs31 < 50)
            {
                Console.WriteLine($"Tu nota para Matemáticas es {NotaEs31}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs31 >= 50 && NotaEs31 < 60)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs31}, siendo Suficiente.");
            }
            else if(NotaEs31 >= 60 && NotaEs31 <= 69)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs31}, siendo Bien.");
            }
            else if(NotaEs31 >= 70 && NotaEs31 < 90)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs31}, siendo Notable.");
            }
            else if(NotaEs31 >= 90 && NotaEs31 <= 100)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs31}, siendo Sobresaliente.");
            }

            //-----------------------------------------------------------------------------------------------------

            if(NotaEs32 < 50)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs32}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs32 >= 50 && NotaEs32 < 60)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs32}, siendo Suficiente.");
            }
            else if(NotaEs32 >= 60 && NotaEs32 <= 69)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs32}, siendo Bien.");
            }
            else if(NotaEs32 >= 70 && NotaEs32 < 90)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs32}, siendo Notable.");
            }
            else if(NotaEs32 >= 90 && NotaEs32 <= 100)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs32}, siendo Sobresaliente.");
            }

            //-------------------------------------------------------------------------------------------------------

            if(NotaEs33 < 50)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs33}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs33 >= 50 && NotaEs33 < 60)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs33}, siendo Suficiente.");
            }
            else if(NotaEs33 >= 60 && NotaEs33 <= 69)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs33}, siendo Bien.");
            }
            else if(NotaEs33 >= 70 && NotaEs33 < 90)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs33}, siendo Notable.");
            }
            else if(NotaEs33 >= 90 && NotaEs33 <= 100)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs33}, siendo Sobresaliente.");
            }

            //---------------------------------------------------------------------------------------------------------

            if(NotaEs34 < 50)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs34}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs34 >= 50 && NotaEs34 < 60)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs34}, siendo Suficiente.");
            }
            else if(NotaEs34 >= 60 && NotaEs34 <= 69)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs34}, siendo Bien.");
            }
            else if(NotaEs34 >= 70 && NotaEs34 < 90)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs34}, siendo Notable.");
            }
            else if(NotaEs34 >= 90 && NotaEs34 <= 100)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs34}, siendo Sobresaliente.");
            }

            //--------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------

            Console.WriteLine("ESTUDIANTE 4:");
            if(NotaEs41 < 50)
            {
                Console.WriteLine($"Tu nota para Matemáticas es {NotaEs41}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs41 >= 50 && NotaEs41 < 60)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs41}, siendo Suficiente.");
            }
            else if(NotaEs41 >= 60 && NotaEs41 <= 69)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs41}, siendo Bien.");
            }
            else if(NotaEs41 >= 70 && NotaEs41 < 90)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs41}, siendo Notable.");
            }
            else if(NotaEs41 >= 90 && NotaEs41 <= 100)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs41}, siendo Sobresaliente.");
            }

            //-----------------------------------------------------------------------------------------------------

            if(NotaEs42 < 50)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs42}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs42 >= 50 && NotaEs42 < 60)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs42}, siendo Suficiente.");
            }
            else if(NotaEs42 >= 60 && NotaEs42 <= 69)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs42}, siendo Bien.");
            }
            else if(NotaEs42 >= 70 && NotaEs42 < 90)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs42}, siendo Notable.");
            }
            else if(NotaEs42 >= 90 && NotaEs42 <= 100)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs42}, siendo Sobresaliente.");
            }

            //-------------------------------------------------------------------------------------------------------

            if(NotaEs43 < 50)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs43}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs43 >= 50 && NotaEs43 < 60)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs43}, siendo Suficiente.");
            }
            else if(NotaEs43 >= 60 && NotaEs43 <= 69)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs43}, siendo Bien.");
            }
            else if(NotaEs43 >= 70 && NotaEs43 < 90)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs43}, siendo Notable.");
            }
            else if(NotaEs43 >= 90 && NotaEs43 <= 100)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs43}, siendo Sobresaliente.");
            }

            //---------------------------------------------------------------------------------------------------------

            if(NotaEs44 < 50)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs44}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs44 >= 50 && NotaEs44 < 60)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs44}, siendo Suficiente.");
            }
            else if(NotaEs44 >= 60 && NotaEs44 <= 69)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs44}, siendo Bien.");
            }
            else if(NotaEs44 >= 70 && NotaEs44 < 90)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs44}, siendo Notable.");
            }
            else if(NotaEs44 >= 90 && NotaEs44 <= 100)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs44}, siendo Sobresaliente.");
            }

            //--------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------

            Console.WriteLine("ESTUDIANTE 5:");
            if(NotaEs51 < 50)
            {
                Console.WriteLine($"Tu nota para Matemáticas es {NotaEs51}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs51 >= 50 && NotaEs51 < 60)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs51}, siendo Suficiente.");
            }
            else if(NotaEs51 >= 60 && NotaEs51 <= 69)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs51}, siendo Bien.");
            }
            else if(NotaEs51 >= 70 && NotaEs51 < 90)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs51}, siendo Notable.");
            }
            else if(NotaEs51 >= 90 && NotaEs51 <= 100)
            {
                Console.WriteLine($"Tu nota para Matematicas es {NotaEs51}, siendo Sobresaliente.");
            }

            //-----------------------------------------------------------------------------------------------------

            if(NotaEs52 < 50)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs52}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs52 >= 50 && NotaEs52 < 60)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs52}, siendo Suficiente.");
            }
            else if(NotaEs52 >= 60 && NotaEs52 <= 69)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs52}, siendo Bien.");
            }
            else if(NotaEs52 >= 70 && NotaEs52 < 90)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs52}, siendo Notable.");
            }
            else if(NotaEs52 >= 90 && NotaEs52 <= 100)
            {
                Console.WriteLine($"Tu nota para Español es {NotaEs52}, siendo Sobresaliente.");
            }

            //-------------------------------------------------------------------------------------------------------

            if(NotaEs53 < 50)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs53}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs53 >= 50 && NotaEs53 < 60)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs53}, siendo Suficiente.");
            }
            else if(NotaEs53 >= 60 && NotaEs53 <= 69)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs53}, siendo Bien.");
            }
            else if(NotaEs53 >= 70 && NotaEs53 < 90)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs53}, siendo Notable.");
            }
            else if(NotaEs53 >= 90 && NotaEs53 <= 100)
            {
                Console.WriteLine($"Tu nota para Inglés es {NotaEs53}, siendo Sobresaliente.");
            }

            //---------------------------------------------------------------------------------------------------------

            if(NotaEs54 < 50)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs54}, menor a 50, siendo Insuficiente.");
            }
            else if(NotaEs54 >= 50 && NotaEs54 < 60)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs54}, siendo Suficiente.");
            }
            else if(NotaEs54 >= 60 && NotaEs54 <= 69)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs54}, siendo Bien.");
            }
            else if(NotaEs54 >= 70 && NotaEs54 < 90)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs54}, siendo Notable.");
            }
            else if(NotaEs54 >= 90 && NotaEs54 <= 100)
            {
                Console.WriteLine($"Tu nota para Fisica es {NotaEs54}, siendo Sobresaliente.");
            }
        }
    }
}
