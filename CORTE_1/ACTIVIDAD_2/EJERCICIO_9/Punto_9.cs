using System;

namespace AplicacionBase
{
    class Punto_9
    {
        /*

    GROUP MEMBERS:
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan

    SHIFT:
        Diurnal
    
    GROUP:

        63102C / 239-2A */
        static void Main(string[] args)
        //Escriba un programa que pregunte primero si se quiere calcular el área de un triángulo o la de un círculo. Si se contesta que se quiere calcular el área de un triángulo (escribiendo T o t), el programa tiene que pedir entonces la base y la altura y escribir el área. Si se contesta que se quiere calcular el área de un círculo (escribiendo C o c), el programa tiene que pedir entonces el radio y escribir el área.Se recuerda que el área de un triángulo es base por altura dividido por 2 y que el área de un círculo es Pi (aproximadamente 3,141592) por el radio al cuadrado.
        {
          
           
           
                float Área;
                char Opcion;

                do
                {

                Console.WriteLine("Menú : ");
                Console.WriteLine("--------");
                Console.WriteLine("1. Área Triángulo (T)");
                Console.WriteLine("2. Área círculo (C)");
                Console.WriteLine("3. Salir (S)");

                Console.Write("Seleccione una opción: ");
                Opcion = char.Parse(Console.ReadLine());

                if(Opcion == 'T'|| Opcion == 't' )
                {
                    int Base,Altura;
                    Console.Write("Ingrese por favor la base del triángulo: ");
                    Base = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese la altura del triángulo: ");
                    Altura = int.Parse(Console.ReadLine());

                    Área = (Base * Altura)/2;
                    Console.WriteLine("El área del triángulo es de: "+Área+" m^2");

                }
                if(Opcion== 'C'||Opcion=='c')
                {
                    float Radio;
                    float PI = 3.1415926535897931f;
                    Console.Write("Ingrese el radio del círculo: ");
                    Radio = float.Parse(Console.ReadLine());

                    Radio = Radio * Radio;
                    Área = PI * Radio;
                    Console.WriteLine("El área del círculo es de: "+Área+" m^2");                   


                } 


                }while(Opcion != 'S');

                Console.WriteLine("Gracias...");
                
            
        }
    }
}
