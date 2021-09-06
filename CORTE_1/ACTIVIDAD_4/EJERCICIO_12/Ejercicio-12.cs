using System;

namespace Punt_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int agend = 0;
            int asign = 0;
            int dias = 0;
            int horas = 0;
            string actividad;
            Console.WriteLine("====================================================================");
            Console.WriteLine("BIENVENIDO A SU AGENDA :)");
            Console.WriteLine("Estamos en el año 2021; por favor elija cuantas agendaciones desea hacer para sus actividades:");
            Console.WriteLine("TENGA EN CUENTA QUE SOLO PUEDE ESCOGER EL MES EN UN RANGO DE 12 MESES");
            Console.WriteLine("1. Enero ");
            Console.WriteLine("2. Febrero ");
            Console.WriteLine("3. Marzo ");
            Console.WriteLine("4. Abril ");
            Console.WriteLine("5. Mayo ");
            Console.WriteLine("6. Junio ");
            Console.WriteLine("7. Julio ");
            Console.WriteLine("8. Agosto ");
            Console.WriteLine("9. Septiempre");
            Console.WriteLine("10. Octubre ");
            Console.WriteLine("11. Noviembre");
            Console.WriteLine("12. Diciembre");
            Console.WriteLine("Ingrese su numero de asignaciones:");
            asign = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====================================================================");
            
            for(int j = 0; j < asign; j++){

             string[] Meses;
             Meses = new string[13];

             Meses[0] = "NO escogio ningun mes.";
             Meses[1] = "Enero";
             Meses[2] = "Febrero";
             Meses[3] = "Marzo";
             Meses[4] = "Abril";
             Meses[5] = "Mayo";
             Meses[6] = "Junio";
             Meses[7] = "Julio";
             Meses[8] = "Agosto";
             Meses[9] = "Septiempre";
             Meses[10] = "Octubre";
             Meses[11] = "Noviembre";
             Meses[12] = "Diciembre";

             string[] Dias;
             Dias = new string[32];
             Dias[0] = "No ha escogido ningun dia";
             Dias[1] = "Lunes";
             Dias[2] = "Martes";
             Dias[3] = "Miercoles";
             Dias[4] = "Jueves";
             Dias[5] = "Viernes";
             Dias[6] = "Sabado";
             Dias[7] = "Domingo";
             Dias[8] = "Lunes";
             Dias[9] = "martes";
             Dias[10] = "Miercoles";
             Dias[11] = "Jueves";
             Dias[12] = "Viernes";
             Dias[13] = "Sabado";
             Dias[14] = "Domingo";
             Dias[15] = "Lunes";
             Dias[16] = "Martes";
             Dias[17] = "Miercoles";
             Dias[18] = "Jueves";
             Dias[19] = "Viernes";
             Dias[20] = "Sabado";
             Dias[21] = "Domingo";
             Dias[22] = "Lunes";
             Dias[23] = "Martes";
             Dias[24] = "Miercoles";
             Dias[25] = "Jueves";
             Dias[26] = "Viernes";
             Dias[27] = "Sabado";
             Dias[28] = "Domingo";
             Dias[29] = "Lunes";
             Dias[30] = "Martes";
             Dias[31] = "Miercoles";


             if (agend < 13){
              Console.WriteLine("Ahora por favor ingrese el/los numero(s) que le correspondan al mes que desea");
              agend = Convert.ToInt32(Console.ReadLine());

            
              
                if(dias< 31){
                Console.WriteLine("Por favor ingrese el numero del dia para agendar su actividad:");
                dias = Convert.ToInt32(Console.ReadLine());
                }
                if (horas < 2400){
                Console.WriteLine("Por ultimo ingrese la hora en la que desea asignar su actividad.");
                Console.WriteLine("IMPORTANTE! DEBE SER EN HORA MILITAR: Si su hora es a las 10:00 AM la conversion es asi -> 1000.");
                Console.WriteLine("Automaticamente el programa le hara saber si es en la mañana o en la tarde.");
                horas = Convert.ToInt32(Console.ReadLine());
        
                 if( horas < 1200){
                 Console.WriteLine("====================================================================");

                 Console.WriteLine("El mes que ha escogido es: "+ Meses[agend]);
                 Console.WriteLine("El dia en el cual se asigno su actividad es: " + Dias[dias]+" "+dias);
                 Console.WriteLine("La hora en que asigno su actividad es: "+ horas + " De la mañana");
                 Console.WriteLine("Por favor escriba el nombre de la avtividad: ");
                 actividad = Console.ReadLine();
                 Console.WriteLine("====================================================================");

                 }
                 else{
                 Console.WriteLine("====================================================================");
                 Console.WriteLine("El mes que ha escogido es: "+ Meses[agend]);
                 Console.WriteLine("El dia en el cual se asigno su actividad es: " + Dias[dias]+" "+dias);
                 Console.WriteLine("La hora en que asigno su actividad es: "+ horas + " De la tarde");
                 Console.WriteLine("Por favor escriba el nombre de la avtividad: ");
                 actividad = Console.ReadLine();
                 Console.WriteLine("====================================================================");

                }

              }

             }
            }
        }
        
    } 
}
