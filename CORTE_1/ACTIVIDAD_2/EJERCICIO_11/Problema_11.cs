using System;

namespace Problema_11
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
    class Problema_11
    {
        /*
        En un censo familiar se desea colocar subsidios a los servicios públicos, 
        se debe crear un programa que ingresen el valor del Agua, Luz y Gas, si es estrato 1 
        debe dar el 20% de descuento a cada servicio, si es estrato 2 el 15% si es de estrato 3 
        o más debe dar el 9% de descuento, al final nos debe dar el total a pagar discriminado por servicio público.
        */
        static void Main(string[] args)
        {
            double Agua, Luz, Gas, Estrato; 
            double ResultadoAgua=0, ResultadoLuz=0, ResultadoGas=0;
            string WhileLoop;
            Console.WriteLine("Bienvenido al censo:");
            Console.WriteLine("Debemos saber cual es el valor de tus servicios y estrato.");
            Console.WriteLine("");
            
            do
            {
                do
                {
                    Console.WriteLine("Teniendo en cuenta...");
                    Console.WriteLine("Digita un numero de estrato '1,2,3,4,5 o 6':");
                    Estrato = int.Parse(System.Console.ReadLine());
                    
                    if(Estrato >6)
                    {
                        Console.WriteLine("No se conoce un estrato mayor a 6 (seis). Intente de nuevo:");
                        Console.WriteLine("");
                    }
                    else if(Estrato <0)
                    {
                        Console.WriteLine("No se conoce un estrato menor a cero. Intente de nuevo:");
                        Console.WriteLine("");
                    }
                    else if(Estrato == 0)
                    {
                        Console.WriteLine("No se conoce un estrato igual a cero. Intente de nuevo:");
                        Console.WriteLine("");
                    } 

                }while(Estrato <= 0 || Estrato > 6);



                do
                {
                    Console.WriteLine("Digita Valor de Servicio de agua:");
                    Agua = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("Digita Valor de Servicio de Luz:");
                    Luz = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("Digita Valor de Gas:");
                    Gas = int.Parse(System.Console.ReadLine());

                    if(Agua <=0 || Luz <=0 || Gas <=0)
                    {
                        Console.WriteLine("No se leen números ceros o negativos. Intente de nuevo:");
                        Console.WriteLine("");
                    }
                }while(Agua <=0 || Luz <=0 || Gas <=0);


                if(Estrato ==1)
                {
                    ResultadoAgua = Agua * 0.2;
                    ResultadoGas = Gas * 0.2;
                    ResultadoLuz = Luz * 0.2;
                }
                if(Estrato ==2)
                {
                    ResultadoAgua = Agua * 0.15;
                    ResultadoGas = Gas * 0.15;
                    ResultadoLuz = Luz * 0.15;
                }
                if(Estrato >=3 && Estrato <=6)
                {
                    ResultadoAgua = Agua * 0.09;
                    ResultadoGas = Gas * 0.09;
                    ResultadoLuz = Luz * 0.09;
                }

                ResultadoAgua = Agua - ResultadoAgua;
                ResultadoLuz = Luz - ResultadoLuz;
                ResultadoGas = Gas - ResultadoGas;

                Console.WriteLine($"Valor total discriminado a pagar para Agua es de {ResultadoAgua}.");
                Console.WriteLine($"Valor total discriminado a pagar para Luz es de {ResultadoLuz}.");
                Console.WriteLine($"Valor total discriminado a pagar para Gas es de {ResultadoGas}.");
                Console.WriteLine("");

                Console.WriteLine("¿Desea conocer otro resultado? s/n.");
                WhileLoop = Console.ReadLine();

                if(WhileLoop !="S" && WhileLoop !="s" && WhileLoop !="n" && WhileLoop !="N")
                {
                    Console.WriteLine("Letra desconocida se a finalizado la ejecución.");
                    break;
                }
                if(WhileLoop =="n" || WhileLoop =="N")
                {
                    Console.WriteLine("Usted a finalizado la ejecución.");
                }

            }while(WhileLoop =="s" || WhileLoop =="S");
        }
    }
}
