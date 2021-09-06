using System;

namespace Ejer._12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vot1 = 0, vot2 = 0, vot3=0, voto, maximo;
            string ganador;
            double total, ov1, ov2, ov3;

            Console.Write("BIENVENIDOS A LAS VOTACIONES ESTUDIANTILES");
            Console.WriteLine(" ");
            Console.WriteLine("A continuacion se mostraran los candidatos, por favor ponga el numero del cantidato por el que quiere votar:");
            Console.WriteLine(" ");
            Console.WriteLine("1. MARIA CAMILA ROA. ");
            Console.WriteLine("2. DAVID ESTEBAN CARDONA. ");
            Console.WriteLine("3. DANIEL STEVAN GONZALES. ");
            Console.WriteLine("4. PARA TERMINAR LAS ELECCIONES. ");
            Console.WriteLine("============================================================================================================================");
            Console.Write(Environment.NewLine);
            do{
             Console.WriteLine(" ingrese su voto:");
             voto = int.Parse(Console.ReadLine());
             if( vot1 == 1){
               vot1 = vot1+1;
             }
             else if (vot2 == 2){
                vot2 = vot2+1;
             }
             else if (vot3 == 3){
                vot3 = vot3+1;
             }

            }while(voto != 4);
            
            total = vot1 + vot2 + vot3;
            ov1 = (total / vot1) * 100;
            ov2 = (total / vot2) * 100;
            ov3 = (total / vot3) * 100;

            Console.WriteLine("MARIA CAMILA TIENE LOS SIGUIENETES VOTOS: " + ov1);
            Console.WriteLine("DAVID ESTEBAN TIENE LOS SIGUIENETES VOTOS: " + ov2);
            Console.WriteLine("DANIEL STEVAN TIENE LOS SIGUIENETES VOTOS: " + ov3);

            maximo = vot1;
            ganador = "MARIA CAMILA ROA";
            if(vot2 > maximo){
             ganador = "DAVID ESTEBAN CARDONA";
            }
            if(vot3 > maximo){
             ganador = "DANIEL STEVAN GONZALES";
            }
          Console.WriteLine("FELICITACIONES: " +ganador+ " USTED ES EL GANADOR DE LAS ELECCIONES.");
          Console.WriteLine("============================================================================================================================");
          Console.ReadLine();
        }
    }
}
