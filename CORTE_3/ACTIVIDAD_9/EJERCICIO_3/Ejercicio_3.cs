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
        63102C / 239-2A 
*/

/*
Plantear una clase Club y otra clase Socio.
    La clase Socio debe tener los siguientes atributos privados: nombre y la 
    antigüedad en el club (en años). En el constructor pedir la carga del nombre 
    y su antigüedad. La clase Club debe tener como atributos 3 objetos de la 
    clase Socio. Definir una responsabilidad para imprimir el nombre del socio 
    con mayor antigüedad en el club
*/

namespace EJERCICIO_3
{
   class Socio
    {
        private string nombre;
        private int antigüedadAños;

        public Socio()
        {
            Console.Write("Por favor ingrese el nombre del socio: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese los años la antigüedad del socio: ");
            antigüedadAños = int.Parse(Console.ReadLine());
        }

        public void informacionSocio ()
        {
            Console.WriteLine($"{nombre} tiene una antigüedad de {antigüedadAños} años");
        }
        public int retornarAntigüedad()
        {
            return antigüedadAños;
        }
        
    }

    class Club
    
    {
        private Socio socio1,socio2,socio3;

        public Club ()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }
         public void socioMásAntiguo()
        {
            Console.WriteLine("El Socio con mayor antigüedad es: ");

            if(socio1.retornarAntigüedad()>socio2.retornarAntigüedad() && socio1.retornarAntigüedad()>socio3.retornarAntigüedad()){
                socio1.informacionSocio();
            }
            if(socio2.retornarAntigüedad()>socio1.retornarAntigüedad() && socio2.retornarAntigüedad()>socio3.retornarAntigüedad()){
                socio2.informacionSocio();
            }
            if(socio3.retornarAntigüedad()>socio1.retornarAntigüedad() && socio3.retornarAntigüedad()>socio2.retornarAntigüedad()){
                socio3.informacionSocio();
            }
            
        }

        static void Main(string[] args)
        {
            Club club1 = new Club();
            club1.socioMásAntiguo();
            Console.ReadKey();
        }
    }
}
