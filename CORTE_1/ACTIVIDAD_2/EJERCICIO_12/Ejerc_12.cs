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

namespace Ejerc._12
{
    class Program
    {
        static void Main(string[] args)
        {
          //Realizar un programa para una ferretería que desean calcular el precio por Metro según el Tipo de Cable, el sistema debe pedir los productos a calcular, debe pedir el valor del metro a cada producto y al final la cantidad de metros. Existe una regla que si la cantidad de metros si están en el rango de 20 metros a 40 metros se les debe dar un descuento del 5% sobre cada producto, si superan los 40 metros deben dar un  12%  de  descuento.  Al  final  el programa  me  debe  generar  el total  de  la  factura  con  los  descuentos según las cantidades discriminadas.
            Console.WriteLine("BIENVENIDOS A NUESTRA FERRETERIA!! :)");
            Console.WriteLine("A continuacion se va a desplegar una barra de opciones con los cables disponibles en el momento");
            Console.WriteLine("1. Cable electrico.");
            Console.WriteLine("2. Cable electronico.");
            Console.WriteLine("3. Cable de alta tension.");
            Console.WriteLine("3. Cable numero 12 (NORMAL).");

            double Cable_elctrico =  1500;
            double Cable_electronico = 800;
            double Cable_de_alta_tension = 10000;
            double Cable_normal = 2000;
            String entrada1,entrada2,entrada3,entrada4;
            int cantidad1 = 0, cantidad2 = 0, cantidad3 = 0, cantidad4 =0;
            double resultado1 = 0;
            double resultado2 = 0;
            double resultado3 = 0; 
            double resultado4 = 0;
            double precio1 = 0;
            double precio2 = 0;
            double precio3 = 0;
            double precio4 = 0;
            double precio11 = 0;
            double precio22 = 0;
            double precio33 = 0;
            double precio44 = 0;
            double total = 0;
 
            Console.WriteLine(" ");
            Console.WriteLine("Por favor digite el o los productos que desea llevar:");
            Console.WriteLine("Presione (enter) la cantidad de veces que sea necesaria dependiendo la canidad de productos para continuar con el proceso.");
            entrada1 = Console.ReadLine();
            entrada2 = Console.ReadLine();
            entrada3 = Console.ReadLine();
            entrada4 = Console.ReadLine(); 

            Console.WriteLine("Ahora por favor ingrese la cantidad de metros que desea llevar segun el procuto");
            Console.WriteLine("Si no agrego los 4 productos en los espacios ponga el numero 0.");
            cantidad1 = Convert.ToInt32(Console.ReadLine());
            cantidad2 = Convert.ToInt32(Console.ReadLine());
            cantidad3 = Convert.ToInt32(Console.ReadLine());
            cantidad4 = Convert.ToInt32(Console.ReadLine());
            
           if(cantidad1 <=40){
              Console.WriteLine("Tiene un descuento del 5%.");
              resultado1 = Cable_elctrico*cantidad1; 
              precio1 = resultado1*0.5;
              precio11 = resultado1-precio1;
              Console.WriteLine("Su total hasta el momento es: "+precio11);
           } 
           if(cantidad1 > 40){
              Console.WriteLine("Tiene un descuento del 12%.");
              resultado1 = Cable_elctrico*cantidad1; 
              precio1 = resultado1*0.12;
              precio11 = resultado1 - precio1;
              Console.WriteLine("Su total hasta el momento es: "+precio11);
           }
           if(cantidad2 <=40){
              Console.WriteLine("Tiene un descuento del 5%.");
              resultado2 = Cable_electronico*cantidad2;
              precio2 = resultado2*0.5;
              precio22 = resultado2 - precio2;
              Console.WriteLine("Su total hasta el momento es: "+precio22);
           }
          if(cantidad2 > 40){
              Console.WriteLine("Tiene un descuento del 12%.");
              resultado2 = Cable_electronico*cantidad2; 
              precio2 = resultado2*0.12;
              precio22= resultado2 - precio2;
              Console.WriteLine("Su total hasta el momento es: "+precio22);
           }
            if(cantidad3 <=40){
              Console.WriteLine("Tiene un descuento del 5%.");
              resultado3 = Cable_de_alta_tension*cantidad3;
              precio3 = resultado3*0.5;
              precio33 = resultado3 - precio3;
              Console.WriteLine("Su total hasta el momento es: "+precio33);
           }
           if(cantidad3 > 40){
              Console.WriteLine("Tiene un descuento del 12%.");
              resultado3 = Cable_de_alta_tension*cantidad3; 
              precio3 = resultado3*0.12;
              precio33 = resultado3 - precio3;
              Console.WriteLine(" Su total hasta el momento es: "+precio33);
           }
            if(cantidad4 <=40){
              Console.WriteLine("Tiene un descuento del 5%.");
              resultado4 = Cable_normal*cantidad4;
              precio4 = resultado4*0.5;
              precio44 = resultado4 - precio4;
              Console.WriteLine("Su total hasta el momento es: "+precio44);
           }
           if(cantidad4 > 40){
              Console.WriteLine("Tiene un descuento del 12%.");
              resultado4 = Cable_normal*cantidad4; 
              precio4 = resultado4*0.12;
              precio44 = resultado4- precio4;
              Console.WriteLine(" Su total hasta el momento es: "+precio44);
           }
         total = precio11 + precio22 + precio33 + precio44;
         Console.WriteLine("EL VALOR TOTAL DE LA FACTORA ES: "+total);

         Console.ReadKey();
        }
    }
}
