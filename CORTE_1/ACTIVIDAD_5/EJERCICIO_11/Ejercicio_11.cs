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
{
    /*De una empresa de transporte se quiere guardar el nombre de los conductores que tiene, y los kilómetros que conducen cada día de la semana.
    o Para guardar esta información se van a utilizar dos arreglos:
      ▪Nombre: Vector para guardar los nombres de los conductores.
      ▪kms: Tabla para guardar los kilómetros que realizan cada día de la semana.
    o Se quiere generar un nuevo vector (“total_kms”) con los kilómetros totales que realza cada conductor.Al finalizar se debe mostrar la tabla con la lista de conductores*/
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de conductores");
            int Conductores = int.Parse(Console.ReadLine());
            string [] nombres = new string [Conductores];
            string [] dias = new string [8];
            dias[0]= "Lunes";
            dias[1]= "Martes";
            dias[2]= "Miércoles";
            dias[3]= "Jueves";
            dias[4]= "Viernes";
            dias[5]= "Sábado";
            dias[6]= "Domingo";
            dias[7]= "Totalkms";
            int [] total_kms = new int [Conductores];
            int [,] empresa_Transporte = new int[Conductores,7];

            for(int i = 0 ; i < Conductores; i++)
            {
                Console.Write($"Ingrese el nombre del conductor {i+1}: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese los kilometros semanales:");

                for(int k = 0; k < 7;k++ )
                {
                 Console.Write($"{dias[k]} = -");   
                 empresa_Transporte[i,k] = int.Parse(Console.ReadLine());
                 
                }
            }
            
            for(int l=0; l < Conductores; l++)
            {
                int sumatoria_kms=0;
                for(int p = 0; p < 7 ;p++)
                {
                    sumatoria_kms = sumatoria_kms + empresa_Transporte[l,p];
                }
                total_kms[l] = sumatoria_kms;
            }

            

            for(int i = 0; i < Conductores; i++)
            {
                Console.WriteLine($"Conductor {i+1}: {nombres[i]} ");
                    for(int l = 0; l < 7;l++)
                    {
                        Console.WriteLine($"{dias[l]}: {empresa_Transporte[i,l]}km ");
                    }
                    Console.WriteLine($"Total kms semanales: {total_kms[i]}Km");
                    Console.WriteLine();
            }
            


            
        }
    }
}
